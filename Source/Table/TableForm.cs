﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using TPCourse.Source.Types;
using TPCourse.Source.Table.Column;
using TPCourse.Source.Table.Column.DataTypes;
using TPCourse.Source.Table;

namespace TPCourse.Table
{
	public partial class TableForm : Form
	{
		public TableModel Model;
		//public TableView _view;

		// индекс столбца, у которого вызвали контекстное меню
		private int CtxMenuColumnIndex = -1;

		public TableForm()
		{
			InitializeComponent();
			Model = new TableModel(this);
			//_view = new TableView(this);
		}

		public void Init(TableDescriptor desc, FormClosedEventHandler closedHandler)
		{
			Text = desc.Name; // unique
			FormClosed += closedHandler;
		}

		public void Init(TableData tableData, FormClosedEventHandler closedHandler)
		{
			Init(tableData.Descriptor, closedHandler);

			var columnDescriptors = tableData.ColumnDescriptors;
			Model.ColumnDescriptors = columnDescriptors;

			foreach(var desc in columnDescriptors)
			{
				DGView_Table.Columns.Add("", desc.Name);
			}

			List<List<string>> rows = tableData.Rows;

			for(int rowIndex = 0; rowIndex < rows.Count; rowIndex++)
			{
				List<string> row = rows[rowIndex];
				DGView_Table.Rows.Add(row.ToArray());
			}
		}

		private void Btn_AddColumn_Click(object sender,		EventArgs e)
		{
			var dialog = new AddColumnDialog();
			dialog.ShowDialog();
			var result = dialog.Result;

			if(result.Success)
			{
				Model.AddColumn(result.Value);
			}
		}
		
		/*
			Правка ячейки завершилась.
			*/
		private void DGView_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			var cell = DGView_Table.Rows[e.RowIndex].Cells[e.ColumnIndex];
			ColumnDescriptor columnDescriptor = Model.ColumnDescriptors[e.ColumnIndex];

			if (Formatter.TryFormat(
				(string)cell.Value, 
				columnDescriptor.DataType, 
				columnDescriptor.Format.ToString(),
				columnDescriptor.Format.Culture, 
				out string formatted))
			{
				cell.Value = formatted;
			}
		}

		/*
			@view Контекстное меню
			@brief Редактирование свойств столбца.
			*/
		private void TSMItem_ColumnHeader__EditColumn_Click(object sender, EventArgs e)
		{
			var dialog = new AddColumnDialog();
			/*DataTypeFormat format = Model.ColumnDescriptors[CtxMenuColumnIndex].Format;
			dialog.ShowDialog(format);*/
			ColumnDescriptor descriptor = Model.ColumnDescriptors[CtxMenuColumnIndex];
			dialog.ShowDialog(descriptor);

			var result = dialog.Result;

			if(result.Success)
			{
				Model.UpdateColumnDescriptor(result.Value, CtxMenuColumnIndex);
			}
		}

		/*
			Щелчок заголовка столбца.
			*/
		private void DGView_Table_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				CtxMenuColumnIndex = e.ColumnIndex;
				CtxMS_ColumnHeader.Show(Cursor.Position);
			}
		}

		/*
			Удаление столбца.
			*/
		private void TSMItem_ColumnHeader__RemoveColumn_Click(object sender, EventArgs e)
		{
			DGView_Table.Columns.RemoveAt(CtxMenuColumnIndex);
			Model.ColumnDescriptors.RemoveAt(CtxMenuColumnIndex);
		}
	}
}
