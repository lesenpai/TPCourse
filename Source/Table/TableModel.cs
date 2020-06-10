using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TPCourse.Source.Table.Column;
using TPCourse.Source.Table.Column.DataTypes;
using TPCourse.Source.Table.Column.DataTypes.Base;

namespace TPCourse.Table
{
	public class TableModel
	{
		private readonly TableForm _form;
		private readonly DataGridView _table;
		public List<ColumnDescriptor> ColumnDescriptors = new List<ColumnDescriptor>();

		public TableModel(TableForm form)
		{
			_form = form;
			_table = _form.DGView_Table;
		}

		// TODO: дать нормальное имя
		private void AddColumn_(ColumnDescriptor descriptor)
		{
			ColumnDescriptors.Add(descriptor);
			_table.Columns.Add(
				descriptor.Name,
				  descriptor.Name + '\n' 
			        + descriptor.DataType + '\n' 
				+ descriptor.Format.ToString());
		}

		public void UpdateColumnDescriptor(ColumnDescriptor descriptor, int columnIndex)
		{
			ColumnDescriptors[columnIndex] = descriptor;
			_table.Columns[columnIndex].HeaderText = 
				  descriptor.Name + '\n' 
				+ descriptor.DataType + '\n'
				+ descriptor.Format.ToString();
		}

		public void UpdateColumnCells(ColumnDescriptor descriptor, int columnIndex)
		{
			// строка
			for (int i = 0; i < _table.Rows.Count - 1; i++) // "_table.Rows.Count - 1" - игнорируем последнюю пустую строку
			{
				// ячейка
				string oldValue = _table.Rows[i].Cells[columnIndex].Value as string;
				string culture = descriptor.Format.Culture;

				_table.Rows[i].Cells[columnIndex].Value = Formatter.TryFormat(
					oldValue,
					descriptor.DataType,
					descriptor.Format.ToString(),
					CultureInfo.GetCultureInfo(culture),
					out string newValue);

				_table.Rows[i].Cells[columnIndex].Value = newValue;
			}
		}

		public void AddColumn(ColumnDescriptor columnProps)
		{
			AddColumn_(columnProps);
		}
	}
}
