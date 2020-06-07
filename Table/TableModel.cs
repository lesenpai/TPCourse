using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TPCourse.Table.Column;

namespace TPCourse.Table
{
	public class TableModel
	{
		private readonly TableForm _form;
		private readonly DataGridView _table;
		public readonly List<TableColumnDescriptor> TableColumnsDescriptors = new List<TableColumnDescriptor>();

		public TableModel(TableForm form)
		{
			_form = form;
			_table = _form.DGView_Table;

			//var columnProps = new TableColumnProperties("Column", TableColumnDataType.String);
			//AddColumn_(columnProps);
		}

		// TODO: дать нормальное имя
		private void AddColumn_(TableColumnDescriptor columnProps)
		{
			TableColumnsDescriptors.Add(columnProps);
			_table.Columns.Add("c" + columnProps.Index, columnProps.Name + '\n' + columnProps.DataType);
		}

		public void AddColumn(TableColumnDescriptor columnProps)
		{
			columnProps.Index = (TableColumnsDescriptors.Count > 0) ? TableColumnsDescriptors.Max(p => p.Index) + 1 : 0;
			AddColumn_(columnProps);
		}

		public /*bool*/void TryParseCellValue(Point coord)
		{
			string value = (string)_table.Rows[coord.X].Cells[coord.Y].Value;
			var dataType = TableColumnsDescriptors.ElementAt(coord.X).DataType;
			
			/*switch(dataType)
			{
				case TableColumnDataType.Number:
					//datatypeparser.tryNumber(value, format)
					break;

				case TableColumnDataType.Float:
					//..parser.float
					break;

				case TableColumnDataType.Percent:
					//..parser.percent
					break;

				case TableColumnDataType.Currency:
					//..parser.currnecy
					break;

				case TableColumnDataType.Date:
					//..parser.date
					break;

				case TableColumnDataType.Time:
					//..parser.date
					break;
			}*/
		}
	}
}
