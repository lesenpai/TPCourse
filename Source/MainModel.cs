using System;
using System.Collections.Generic;
using TPCourse.Source.Table;
using TPCourse.Table;

namespace TPCourse.Source
{
	public class MainModel
	{
		private MainForm _form;
		private MainView _view;
		public List<TableData> TableDatas { get; set; }

		public MainModel(MainForm form)
		{
			_form = form;
			_view = form.View;
			TableDatas = new List<TableData>();
		}

		public void AddNewTable()
		{
			var dialog = new AddTableDialog();
			dialog.Init(this, _form.View);
			dialog.ShowDialog();
			var result = dialog.Result;

			if(result.Success) // TODO: добавить кнопку таблицы (внизу)
			{
				var tableForm = new TableForm();
				tableForm.Init(result.Value, _form.TableForm_FormClosed);
				tableForm.MdiParent = _form;

				TableDatas.Add(TableData.Get(tableForm));

				_view.AddTableButton(result.Value.Name);

				tableForm.Show();
			}
		}

		/*
			Создание и открытие окна таблицы, TableData которой уже есть в MainModel
			*/
		public void AddExistingTable(TableData tableData)
		{
			TableForm tableForm = new TableForm();
			tableForm.Init(tableData, _form.TableForm_FormClosed);
			tableForm.MdiParent = _form;

			tableForm.Show();
		}

		/*// Обработка закрытия окна таблицы.
		public void TableForm_FormClosed(object sender, EventArgs e)
		{
			// сохранить данные таблицы в TableData[]
			//System.Windows.Forms.MessageBox.Show("on closed");
			var tableForm = (TableForm)sender;
			UpdateTableData(TableData.Get(tableForm));
		}*/

		public void UpdateTableData(TableData tableData)
		{
			var index = TableDatas.FindIndex(x => x.Descriptor.Name == tableData.Descriptor.Name);
			TableDatas[index] = tableData;
		}
	}
}
