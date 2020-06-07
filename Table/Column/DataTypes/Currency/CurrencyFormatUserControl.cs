using System;
using System.Collections.Generic;using System.Windows.Forms;
using System.Globalization;
using TPCourse.Table.Column;

namespace TPCourse.Table.Column.DataTypes.DataTypeFormatUserControls
{
	public partial class CurrencyFormatUserControl : UserControl, INotifyAnyControlChanged
	{
		/* INofifyAnyControlChanged */
		public event EventHandler AnyControlChanged;
		public void OnAnyControlChanged(object sender, EventArgs e) => AnyControlChanged.Invoke(null, null);
		/* INofifyAnyControlChanged ; */

		public CurrencyFormatUserControl(EventHandler handler)
		{
			InitializeComponent();

			AnyControlChanged += handler;
			NUD_Precision.ValueChanged += OnAnyControlChanged;
			CmBox_Currency.SelectedIndexChanged += OnAnyControlChanged;

			var items = new List<string>();

			foreach(var item in ColumnConstants.CurrencyCulture_Sign_Dictionary.Values)
			{
				items.Add(item);
			}

			CmBox_Currency.DataSource = items;
		}
	}
}
