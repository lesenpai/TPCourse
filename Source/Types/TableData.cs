using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TPCourse.Source.Table.Column;
using TPCourse.Source.Types;
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

		/*
			@return Объект TableData
			*/
		public static TableData Get(TableForm form)
		{
			TableData tableData = new TableData();
			tableData.Descriptor = new TableDescriptor(form.Text);
			tableData.ColumnDescriptors = form.Model.ColumnDescriptors;

			List<List<string>> rows = new List<List<string>>();

			foreach(DataGridViewRow row in form.DGView_Table.Rows)
			{
				List<string> cells = new List<string>();

				foreach(DataGridViewCell cell in row.Cells)
				{
					cells.Add(cell.Value as string);
				}

				rows.Add(cells);
			}

			tableData.Rows = rows;

			return tableData;
		}
	}
}
