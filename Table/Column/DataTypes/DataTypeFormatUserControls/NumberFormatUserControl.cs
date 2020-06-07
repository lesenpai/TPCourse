using System;
using System.Windows.Forms;

namespace TPCourse.Table.Column.DataTypes.DataTypeFormatUserControls
{
	public partial class NumberFormatUserControl : UserControl, INotifyAnyControlChanged
	{
		/* INofifyAnyControlChanged */
		public event EventHandler AnyControlChanged;
		public void OnAnyControlChanged(object sender, EventArgs e) => AnyControlChanged.Invoke(null, null);
		/* INofifyAnyControlChanged ; */

		public NumberFormatUserControl(EventHandler handler)
		{
			InitializeComponent();

			AnyControlChanged += handler;
			NUD_Precision.ValueChanged += OnAnyControlChanged;
			RBtn_DigitGroupSeparator.CheckedChanged += OnAnyControlChanged;
		}
	}
}
