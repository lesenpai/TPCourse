using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using TPCourse.Table.Column.DataTypes;

namespace TPCourse.Table.Column
{ 
	public partial class AddTableColumnDialog : Form
	{
		public Result<TableColumnProperties> Result;
		private const string FORM_CAPTURE = "Добавление столбца";
		private const string LBL_DATA_FORMAT_LABEL_NONE = "( ... )";
		/*private readonly string[] DATA_FORMATS = { "default", "number", "percent", "currency", "date", "time" };//
		private readonly Dictionary<string, UserControl> DATA_FORMAT_USER_CONTROL_DICTIONARY = new Dictionary<string, UserControl>
		{
			{"default", *//*DefaultFormatUserControl*//* }
		}*/

		//private User

		public AddTableColumnDialog()
		{
			InitializeComponent();
			var items = new List<string>();

			// Тип данных
			foreach (var item in Enum.GetNames(typeof(DataType)))
			{
				items.Add(item.ToString());
			}

			CmBox_ColumnDataType.DataSource = items;

			// Формат данных
			//Lbl_DataTypeFormatLabel.Text = LBL_DATA_TYPE_FORMAT_LABEL_NONE;
		}

		private void Btn_OK_Click(object sender, EventArgs e)
		{
			if (!ValidateColumnName())
			{
				MessageBox.Show("Имя колонки не может быть пустым.", FORM_CAPTURE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			/*var props = new TableColumnProperties(TBox_ColumnName.Text, (TableColumnDataType)Enum.Parse(typeof(TableColumnDataType), CmBox_ColumnDataType.Text));
			Result = Result.Successful(props);
			Close();*/
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			Result = Result.Calceled();
		}

		private bool ValidateColumnName()
		{
			return !string.IsNullOrEmpty(TBox_ColumnName.Text);
		}

		/*private void Btn_ConfigureDataTypeFormat_Click(object sender, EventArgs e)
		{
			var dataType = (TableColumnDataType)Enum.Parse(typeof(TableColumnDataType), CmBox_ColumnDataType.Text);
			switch (dataType)
			{
				case TableColumnDataType.Number:
					// ConfigureNumberFormatDialog.ShowDialog();
					break;
			}
		}*/

		/*
			Пользовательский код отрисовки.
			*/
		private void TabCtrl_DataTypeConfiguration_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics g = e.Graphics;
			Brush _textBrush;

			// Get the item from the collection.
			TabPage _tabPage = TabCtrl_DataTypeConfiguration.TabPages[e.Index];

			// Get the real bounds for the tab rectangle.
			Rectangle _tabBounds = TabCtrl_DataTypeConfiguration.GetTabRect(e.Index);

			if (e.State == DrawItemState.Selected)
			{

				// Draw a different background color, and don't paint a focus rectangle.
				_textBrush = new SolidBrush(Color.Red);
				g.FillRectangle(Brushes.Gray, e.Bounds);
			}
			else
			{
				_textBrush = new System.Drawing.SolidBrush(e.ForeColor);
				e.DrawBackground();
			}

			// Use our own font.
			Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

			// Draw string. Center the text.
			StringFormat _stringFlags = new StringFormat();
			_stringFlags.Alignment = StringAlignment.Center;
			_stringFlags.LineAlignment = StringAlignment.Center;
			g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
		}
	}
}
