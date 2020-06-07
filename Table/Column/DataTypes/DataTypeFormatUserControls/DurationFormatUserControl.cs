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
	public partial class DurationFormatUserControl : UserControl, INotifyAnyControlChanged
	{
		/* INofifyAnyControlChanged */
		public event EventHandler AnyControlChanged;
		public void OnAnyControlChanged(object sender, EventArgs e) => AnyControlChanged.Invoke(null, null);
		/* INofifyAnyControlChanged ; */

		public const string DAYS_FORMAT_PREFIX = "d\\.";
		// [-][d.]hh:mm:ss[.fffffff]
		public readonly Dictionary<string, string> PRECISION_NAME__CODE__DICTIONARY = new Dictionary<string, string>
		{
			{ "Миллисекунд", "hh\\:mm\\:ss\\.F"}, // 'F' will be replaced 
			{ "Секунд",      "hh\\:mm\\:ss" },
			{ "Минут",       "hh\\:mm" },
			{ "Часов",       "hh" },
			{ "Дней",        "" }
		};
		public readonly Dictionary<string, string> PRECISION_NAME__CODE__DICTIONARY_NO_DAYS;
		public readonly string[] MILLISECONDS_PRECISIONS = 
		{ 
			"fffffff",
			"ffffff",
			"fffff",
			"ffff",
			"fff",
			"ff",
			"f"
		};

		public DurationFormatUserControl(EventHandler handler)
		{
			InitializeComponent();

			AnyControlChanged += handler;
			RBtn_ShowDays.CheckedChanged                    += OnAnyControlChanged;
			CmBox_Precision.SelectedIndexChanged            += OnAnyControlChanged;
			CmBox_MillisecondPrecision.SelectedIndexChanged += OnAnyControlChanged;

			PRECISION_NAME__CODE__DICTIONARY_NO_DAYS = PRECISION_NAME__CODE__DICTIONARY.Where((x) => x.Key != "Дней").ToDictionary(x => x.Key, x => x.Value);

			CmBox_Precision.DataSource = PRECISION_NAME__CODE__DICTIONARY_NO_DAYS.Keys.ToArray();
			CmBox_Precision.SelectedIndex = 1;
			CmBox_MillisecondPrecision.DataSource = MILLISECONDS_PRECISIONS;
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

		private void RBtn_ShowDays_CheckedChanged(object sender, EventArgs e)
		{
			CmBox_Precision.DataSource = (RBtn_ShowDays.Checked) ? PRECISION_NAME__CODE__DICTIONARY.Keys.ToArray() : PRECISION_NAME__CODE__DICTIONARY_NO_DAYS.Keys.ToArray();
		}
	}
}
