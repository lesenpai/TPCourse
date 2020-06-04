﻿using System.Windows.Forms;
using System.Drawing;
using TPCourse.Table.Column;

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
			var coord = new Point(e.ColumnIndex, e.RowIndex);
			
			//if _model.TryParseDataType(coord);
		}
	}
}