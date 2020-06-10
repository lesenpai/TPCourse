using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TPCourse.Source.Table.Column;
using TPCourse.Table;

namespace TPCourse.Source.Table
{
	/*
		Данные таблицы.
		Служит для сериализации и десериализации.
		*/
	public class TableData
	{
		public TableDescriptor Descriptor { get; set; }
		public List<ColumnDescriptor> ColumnDescriptors { get; set; }
		public List<List<string>> Rows { get; set; }

		public TableData()
		{ }

		/*
			@return TableData
			*/
		public static TableData Get(TableForm form)
		{
			TableData tableData = new TableData();
			tableData.Descriptor = new TableDescriptor(form.Text);
			tableData.ColumnDescriptors = form.Model.ColumnDescriptors;

			List<List<string>> rows = new List<List<string>>();

			/*if (form.DGView_Table.Rows.Count > 0)
			{
				form.DGView_Table.Rows.RemoveAt(form.DGView_Table.Rows.Count - 1); // игнорирование пустой строки в конце
			}*/

			DataGridView table = form.DGView_Table;

			//foreach (DataGridViewRow row in form.DGView_Table.Rows)
			for(int i = 0; i < table.Rows.Count - 1; i++) // "table.Rows.Count - 1" - игнорирование пустой строки в конце
			{
				List<string> cells = new List<string>();

				DataGridViewRow row = table.Rows[i];

				foreach(DataGridViewCell cell in row.Cells)
				{
					cells.Add(cell.Value as string);
				}

				rows.Add(cells);
			}

			tableData.Rows = rows;

			return tableData; // TODO
		}
	}
}
