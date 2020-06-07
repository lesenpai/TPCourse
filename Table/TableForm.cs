﻿using System.Windows.Forms;
using System.Drawing;
using TPCourse.Table.Column;
using TPCourse.Table.Column.DataTypes;

namespace TPCourse.Table
{
	public partial class TableForm : Form
	{
		private TableModel _model;
		private TableView _view;

		public TableForm()
		{
			InitializeComponent();
			_model = new TableModel(this);
			_view = new TableView(this);
		}

		/*private void DGView_Table_SizeChanged(object sender, System.EventArgs e)
		{
			_view.Btn_AddColumn_UpdateLocation();
		}*/

		private void Btn_AddColumn_Click(object sender, System.EventArgs e)
		{
			var dialog = new AddTableColumnDialog();
			dialog.ShowDialog();
			var result = dialog.Result;
			if(result.Success)
			{
				_model.AddColumn(result.Value);
			}
		}

		// Отформатировать содержимое ячейки в соответствии с тип даннх её столбца
		private void DGView_Table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{

		}

		
		/*
			Правка ячейки завершилась.
			*/
		private void DGView_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			var cell = DGView_Table.Rows[e.RowIndex].Cells[e.ColumnIndex];
			TableColumnDescriptor columnDescriptor = _model.TableColumnsDescriptors[e.ColumnIndex];

			// DateType.Duration: prepare
			/*
				 getMajorPartType
			*/

			if (Formatter.TryFormat((string)cell.Value, columnDescriptor.DataType, columnDescriptor.Format, columnDescriptor.Culture, out string formatted))
			{
				cell.Value = formatted;
			}
		}
	}
}
