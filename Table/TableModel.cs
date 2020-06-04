using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using TPCourse.Table.Column;

namespace TPCourse.Table
{
	public class TableModel
	{
		private readonly TableForm _form;
		private readonly DataGridView _table;
		private readonly List<TableColumnProperties> _tableColumnsProperties = new List<TableColumnProperties>();

		public TableModel(TableForm form)
		{
			_form = form;
			_table = _form.DGView_Table;

			//var columnProps = new TableColumnProperties("Column", TableColumnDataType.String);
			//AddColumn_(columnProps);
		}

		// TODO: дать нормальное имя
		private void AddColumn_(TableColumnProperties columnProps)
		{
			_tableColumnsProperties.Add(columnProps);
			_table.Columns.Add("c" + columnProps.Index, columnProps.Name + '\n' + columnProps.DataType);
		}

		public void AddColumn(TableColumnProperties columnProps)
		{
			columnProps.Index = _tableColumnsProperties.Max(p => p.Index) + 1;
			AddColumn_(columnProps);
		}

		public /*bool*/void TryParseCellValue(Point coord)
		{
			string value = (string)_table.Rows[coord.X].Cells[coord.Y].Value;
			var dataType = _tableColumnsProperties.ElementAt(coord.X).DataType;
			
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
