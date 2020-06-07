using System;
using System.Collections.Generic;using System.Windows.Forms;
using System.Globalization;

namespace TPCourse.Table.Column.DataTypes.DataTypeFormatUserControls
{
	public partial class CurrencyFormatUserControl : UserControl, INotifyAnyControlChanged
	{
		/* INofifyAnyControlChanged */
		public event EventHandler AnyControlChanged;
		public void OnAnyControlChanged(object sender, EventArgs e) => AnyControlChanged.Invoke(null, null);	
		/* INofifyAnyControlChanged ; */

		public readonly Dictionary<string, CultureInfo> CURRENCY__CULTURE__DICTIONARY = new Dictionary<string, CultureInfo>
		{
			{ "$ (USD)", CultureInfo.GetCultureInfo("en-US") },
			{ "₽ (RUB)", CultureInfo.GetCultureInfo("ru-RU") },
			{ "€ (EUR)", CultureInfo.GetCultureInfo("fr-FR") }
		};

		public CurrencyFormatUserControl(EventHandler handler)
		{
			InitializeComponent();

			AnyControlChanged += handler;
			NUD_Precision.ValueChanged += OnAnyControlChanged;
			CmBox_Currency.SelectedIndexChanged += OnAnyControlChanged;

			var items = new List<string>();

			foreach (var item in CURRENCY__CULTURE__DICTIONARY.Keys)
			{
				items.Add(item.ToString());
			}

			CmBox_Currency.DataSource = items;
		}
	}
}
