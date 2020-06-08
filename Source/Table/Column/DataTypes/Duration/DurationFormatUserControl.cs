using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCourse.Source.Table.Column.DataTypes.Duration
{
	public partial class DurationFormatUserControl : UserControl, INotifyAnyControlChanged
	{
		/* INofifyAnyControlChanged */
		public event EventHandler AnyControlChanged;
		public void OnAnyControlChanged(object sender, EventArgs e) => AnyControlChanged.Invoke(null, null);
		/* INofifyAnyControlChanged ; */

		public DurationFormatUserControl(EventHandler handler)
		{
			InitializeComponent();

			AnyControlChanged += handler;
			CmBox_Precision.SelectedIndexChanged            += OnAnyControlChanged;
			CmBox_MillisecondPrecision.SelectedIndexChanged += OnAnyControlChanged;

			CmBox_Precision.DataSource = DurationConstants.PrecisionFormatName_Code_Dict.Keys.ToList();
			CmBox_MillisecondPrecision.DataSource = DurationConstants.MillisecondPrecisionFormatName_Code_Dict.Keys.ToList();

			CmBox_Precision.SelectedIndex = (int)DurationPrecision.Second;
		}

		private void SetMillisecondConfigurationState(bool state)
		{
			Lbl_MillisecondPrecision.Enabled = state;
			CmBox_MillisecondPrecision.Enabled = state;
		}

		private void CmBox_Precision_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetMillisecondConfigurationState(CmBox_Precision.Text == "Миллисекунд");
		}

		/*private void RBtn_ShowDays_CheckedChanged(object sender, EventArgs e)
		{
			CmBox_Precision.DataSource = (RBtn_ShowDays.Checked) ? PRECISION_NAME__CODE__DICTIONARY.Keys.ToArray() : PRECISION_NAME__CODE__DICTIONARY_NO_DAYS.Keys.ToArray();
		}*/
	}
}
