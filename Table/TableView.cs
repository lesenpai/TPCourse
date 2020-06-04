namespace TPCourse.Table
{
	public class TableView
	{
		private const int BTN_ADD_COLUMN_X_OFFSET = 10;
		TableForm _form;

		public TableView(TableForm form)
		{
			_form = form;
		}

		public void Btn_AddColumn_UpdateLocation()
		{
			_form.Btn_AddColumn.Location = new System.Drawing.Point(
				_form.DGView_Table.Width + BTN_ADD_COLUMN_X_OFFSET, 
				_form.DGView_Table.Location.Y);
		}
	}
}
