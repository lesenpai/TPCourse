using System;
using System.Windows.Forms;

namespace TPCourse.Source.Table.Column.DataTypes.Percent
{
	public partial class PercentFormatUserControl : UserControl, INotifyAnyControlChanged
	{
		/* INofifyAnyControlChanged */
		public event EventHandler AnyControlChanged;

		public void OnAnyControlChanged(object sender, EventArgs e) => AnyControlChanged.Invoke(null, null);
		/* INofifyAnyControlChanged ; */

		public PercentFormatUserControl(EventHandler handler)
		{
			InitializeComponent();

			AnyControlChanged += handler;
			NUD_Precision.ValueChanged += OnAnyControlChanged;
		}
	}
}
