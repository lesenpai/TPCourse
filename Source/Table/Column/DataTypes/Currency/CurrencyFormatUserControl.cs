using System;
using System.Windows.Forms;
using System.Linq;

namespace TPCourse.Source.Table.Column.DataTypes.Currency
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
			NUD_Precision.ValueChanged          += OnAnyControlChanged;
			CmBox_Currency.SelectedIndexChanged += OnAnyControlChanged;

			CmBox_Currency.DataSource = CurrencyConstants.Sign_Culture_Dictionary.Keys.ToList();
		}
	}
}
