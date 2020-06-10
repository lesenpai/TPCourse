using System;
using System.Windows.Forms;
using System.Collections.Generic;
using TPCourse.Source.Types;
using TPCourse.Source.Table.Column;
using TPCourse.Source.Table.Column.DataTypes;
using TPCourse.Source.Table;
using System.Globalization;

namespace TPCourse.Table
{
	public partial class TableForm : Form
	{
		public event EventHandler ModelChanged;

		public void OnModelChanged() => ModelChanged.Invoke(null, null);

		public TableModel Model;
		//public TableView _view;

		// индекс столбца, у которого вызвали контекстное меню
		private int CtxMenuColumnIndex = -1;

		public TableForm()
		{
			InitializeComponent();
			Model = new TableModel(this);
		}

		/*
			@param propertyChangedHandler: обработчик события изменения модели данных
			*/
		public void Init(TableDescriptor desc, FormClosedEventHandler closedHandler, EventHandler modelChangedHandler)
		{
			Text = desc.Name; // unique
			FormClosed += closedHandler;
			ModelChanged += modelChangedHandler;
		}

		public void Init(TableData tableData, FormClosedEventHandler closedHandler, EventHandler modelChangedHandler)
		{
			Init(tableData.Descriptor, closedHandler, modelChangedHandler);

			var columnDescriptors = tableData.ColumnDescriptors;
			Model.ColumnDescriptors = columnDescriptors;

			foreach(var desc in columnDescriptors)
			{
				DGView_Table.Columns.Add(
					desc.Name, 
					desc.Name + "\n"
					+ desc.DataType + "\n"
					+ desc.Format.ToString());
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
				OnModelChanged();
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
				CultureInfo.GetCultureInfo(columnDescriptor.Format.Culture), 
				out string formatted))
			{
				cell.Value = formatted;
			}

			OnModelChanged();
		}

		/*
			@view Контекстное меню
			@summary Редактирование свойств столбца.
			*/
		private void TSMItem_ColumnHeader__EditColumn_Click(object sender, EventArgs e)
		{
			var dialog = new AddColumnDialog();
			ColumnDescriptor descriptor = Model.ColumnDescriptors[CtxMenuColumnIndex];
			dialog.ShowDialog(descriptor);

			var result = dialog.Result;

			if(result.Success)
			{
				OnModelChanged();
				Model.UpdateColumnDescriptor(result.Value, CtxMenuColumnIndex);
				Model.UpdateColumnCells(result.Value, CtxMenuColumnIndex);
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
			OnModelChanged();
			DGView_Table.Columns.RemoveAt(CtxMenuColumnIndex);
			Model.ColumnDescriptors.RemoveAt(CtxMenuColumnIndex);
		}
	}
}
