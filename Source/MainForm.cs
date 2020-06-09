using System;
using System.Windows.Forms;
using TPCourse.Source.Types;
using TPCourse.Table;
using System.Linq;
using TPCourse.Source.Table;
using System.IO;
using System.Xml.Serialization;

namespace TPCourse.Source
{
	public partial class MainForm : Form
	{
		public MainView View { get; set; }
		public MainModel Model { get; set; }

		public bool IsFileOpen { get; set; }
		public bool IsFileSaved { get; set; }

		public const string DEFAULT_FILE_NAME = "untitled";
		private const string APP_NAME = "TPCourse";

		public string FileName { get; set; }

		private string CtxMenuTableButtonName;

		public MainForm()
		{
			InitializeComponent();

			View = new MainView(this);
			Model = new MainModel(this);

			WindowState = FormWindowState.Maximized;

			SetText(DEFAULT_FILE_NAME);

			FileName = DEFAULT_FILE_NAME;

			IsFileOpen = false;
			IsFileSaved = true;
		}

		public void SetText(string fileName)
		{
			Text = fileName + " - " + APP_NAME;
		}

		/*
			Добавить таблицу.
			*/
		private void TSMI_Menu__AddTable_Click(object sender, EventArgs e)
		{
			Model.AddNewTable();
		}

		public void TableForm_ModelChanged(object sender, EventArgs e)
		{
			IsFileSaved = false;
		}

		/*
			Обработка MouseUp по кнопку, ассоциируемой с таблицей (TableButton)
			*/
		public void TableBtn_X_MouseUp(object sender, MouseEventArgs e)
		{
			var button = (Button)sender;
			TableForm tableForm = new TableForm();

			tableForm.Init(
				Model.TableDatas.Where(i => i.Descriptor.Name == button.Text).ElementAt(0),
				TableForm_FormClosed,
				TableForm_ModelChanged);

			switch (e.Button)
			{
				case MouseButtons.Left: 
				{
					// если окно таблицы, с которой связяна эта кнопка, НЕ открыто
					if(!MdiChildren.Any(i => i.Text == button.Text)) 
					{
						Model.AddExistingTable(TableData.Get(tableForm));
					}
					else 
					{
						Form mdiForm = MdiChildren.Where(i => i.Text == button.Text).ElementAt(0);
						mdiForm.BringToFront();
					}

					break;
				}

				case MouseButtons.Right:
				{
					CtxMenuTableButtonName = button.Text;

					CtxMS_TableBtnX.Show(Cursor.Position);

					break;
				}
			}
		}

		// Обработка закрытия окна таблицы.
		public void TableForm_FormClosed(object sender, EventArgs e)
		{
			// сохранить данные таблицы в TableData[]
			var tableForm = (TableForm)sender;
			Model.UpdateTableData(TableData.Get(tableForm));
		}

		/*
			@view контекстное меню
			Переименовать таблицу.
			*/
		private void TSMI_TableBtnX__Rename_Click(object sender, EventArgs e)
		{
			TableButton button = FLPanel_Tables.Controls.Cast<TableButton>()
				.Where(x => x.Text == CtxMenuTableButtonName)
				.ElementAt(0);

			string oldName = button.Text;

			var dialog = new AddTableDialog();
			dialog.Init(Model, View, oldName);
			dialog.ShowDialog();

			var result = dialog.Result;

			if(result.Success)
			{
				Model.RenameTable(oldName, result.Value.Name);

				IsFileSaved = false;
			}
		}

		/*
			@view контекстное меню
			Удалить таблицу.
			*/
		private void TSMI_TableBtnX__Delete_Click(object sender, EventArgs e)
		{
			string tableName = CtxMenuTableButtonName;
			Model.DeleteTable(tableName);
		}

		/*
			Файл -> Сохранить Как
			*/
		private void TSMI_Menu_File_SaveAs_Click(object sender, EventArgs e)
		{
			var dialogResult = SFDialog.ShowDialog();

			if(dialogResult == DialogResult.OK)
			{
				WriteToFile(SFDialog.FileName);
			}
		}

		/*
			Файл -> Сохранить
			*/
		private void TSMI_Menu_File_Save_Click(object sender, EventArgs e)
		{
			if(IsFileOpen)
			{
				WriteToFile(FileName);
			}
		}

		private void WriteToFile(string fileName)
		{
			try
			{
				using (var writer = new StreamWriter(fileName))
				{
					var data = Model.Update();
					var serializer = new XmlSerializer(typeof(ProjectData));
					serializer.Serialize(writer, data);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Не удалось сохранить файл." + "\n\n" + ex.Message + "\n\n" + ex.InnerException,
					APP_NAME,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void ReadFile(string fileName)
		{
			try
			{
				FLPanel_Tables.Controls.Clear();
				ProjectData data;

				using(var reader = File.OpenText(OFDialog.FileName))
				{
					var serializer = new XmlSerializer(typeof(ProjectData));
					data = (ProjectData)serializer.Deserialize(reader);
				}

				Model.Set(data);

				FileName = OFDialog.FileName;

				IsFileOpen = true;
				IsFileSaved = true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(
					"Не удалось открыть файл." + "\n\n" + ex.Message + "\n\n" + ex.InnerException,
					APP_NAME,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		/*
			Файл -> Открыть
			*/
		private void TSMI_Menu_File_Open_Click(object sender, EventArgs e)
		{
			// если файл не сохранен
			if(!IsFileSaved)
			{
				var askSaveFileDialogResult = MessageBox.Show(
					$"Сохранить изменения в файле \"{FileName}\"?",
					APP_NAME,
					MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Question);

				switch (askSaveFileDialogResult)
				{
					case DialogResult.Yes:
					{
						var safeDialogResult = SFDialog.ShowDialog();

						if (safeDialogResult == DialogResult.OK)
						{
							WriteToFile(SFDialog.FileName);
						}

						IsFileSaved = true;

						var openDialogResult = OFDialog.ShowDialog();

						if(openDialogResult == DialogResult.OK)
						{
							ReadFile(OFDialog.FileName);
						}

						break;
					}

					case DialogResult.No:
					{
						var openDialogResult = OFDialog.ShowDialog();

						if (openDialogResult == DialogResult.OK)
						{
							ReadFile(OFDialog.FileName);
						}

						break;
					}

					case DialogResult.Cancel:
					{
						return;
					}
				}
			}
			else
			{
				var openDialogResult = OFDialog.ShowDialog();

				if(openDialogResult == DialogResult.OK)
				{
					foreach(var form in MdiChildren)
					{
						form.Close();
					}

					ReadFile(OFDialog.FileName);
				}
			}
		}

		/*
			Обработка закрытия формы пользователем.
			*/
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// если файл не сохранен
			if (!IsFileSaved)
			{
				var askSaveFileDialogResult = MessageBox.Show(
					$"Сохранить изменения в файле \"{FileName}\"?",
					APP_NAME,
					MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Question);

				switch (askSaveFileDialogResult)
				{
					case DialogResult.Yes:
					{
						var safeDialogResult = SFDialog.ShowDialog();

						if (safeDialogResult == DialogResult.OK)
						{
							WriteToFile(SFDialog.FileName);
						}
						else
						{
							e.Cancel = true;
						}

						break;
					}

					case DialogResult.Cancel:
					{
						e.Cancel = true;

						break;
					}
				}
			}
		}
	}
}
