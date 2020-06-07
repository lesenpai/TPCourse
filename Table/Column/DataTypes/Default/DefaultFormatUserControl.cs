using System;
using System.Windows.Forms;

namespace TPCourse.Table.Column.DataTypes.DataTypeFormatUserControls
{
	public partial class DefaultFormatUserControl : UserControl, INotifyAnyControlChanged
	{
		/* INofifyAnyControlChanged */
		public event EventHandler AnyControlChanged;
		public void OnAnyControlChanged(object sender, EventArgs e) => AnyControlChanged.Invoke(null, null);
		/* INofifyAnyControlChanged ; */

		public DefaultFormatUserControl(EventHandler handler)
		{
			InitializeComponent();

			AnyControlChanged += handler;
		}
	}
}
