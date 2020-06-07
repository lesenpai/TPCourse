using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCourse.Table.Column.DataTypes.DataTypeFormatUserControls
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
