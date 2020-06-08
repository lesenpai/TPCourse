using System;
using System.Windows.Forms;
using TPCourse.Source.Types;
using TPCourse.Table;
using System.Linq;
using System.Collections.Generic;
using TPCourse.Source.Table;

namespace TPCourse.Source
{
	public partial class MainForm : Form
	{
		public MainView View { get; set; }
		public MainModel Model { get; set; }

		public MainForm()
		{
			InitializeComponent();

			View = new MainView(this);
			Model = new MainModel(this);
		}

		/*
			Добавить таблицу.
			*/
		private void TSMI_Menu__AddTable_Click(object sender, EventArgs e)
		{
			Model.AddNewTable();
			// TODO добавить кнопку таблицы в нижнюю панель
			/*var button = new TableButton();
			button.Init()
			FLPanel_Tables.Controls.Add()*/
		}

		/*
			Обработка клика по кнопке, ассоциируемой с таблицей (TableButton)
			*/
		public void TableBtn_X_Click(object sender, EventArgs e)
		{
			/* 
			if lmb: 
				if tables[name] not exist:
					table = table(tableDatas[name])
				table: to upper layer # ctrl.BringToFront()
			else if rmb: 
				show: ctxMenu {edit, remove}
			*/

			var button = (Button)sender;
			MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
			TableForm tableForm = new TableForm();

			tableForm.Init(
				Model.TableDatas.Where(i => i.Descriptor.Name == button.Text).ElementAt(0),
				TableForm_FormClosed);

			switch (mouseEventArgs.Button)
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
			}
		}

		// Обработка закрытия окна таблицы.
		public void TableForm_FormClosed(object sender, EventArgs e)
		{
			// сохранить данные таблицы в TableData[]
			//System.Windows.Forms.MessageBox.Show("on closed");
			var tableForm = (TableForm)sender;
			Model.UpdateTableData(TableData.Get(tableForm));
		}
	}
}
