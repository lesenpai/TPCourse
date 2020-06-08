using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TPCourse.Source.Table.Column;

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
				"c" + descriptor.Index, descriptor.Name + '\n' 
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

		public void AddColumn(ColumnDescriptor columnProps)
		{
			columnProps.Index = (ColumnDescriptors.Count > 0) ? ColumnDescriptors.Max(p => p.Index) + 1 : 0;
			AddColumn_(columnProps);
		}
	}
}
