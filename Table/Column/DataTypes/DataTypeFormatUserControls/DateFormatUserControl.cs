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
	public partial class DateFormatUserControl : UserControl, INotifyAnyControlChanged
	{
		/* INofifyAnyControlChanged */
		public event EventHandler AnyControlChanged;
		public void OnAnyControlChanged(object sender, EventArgs e) => AnyControlChanged.Invoke(null, null);
		/* INofifyAnyControlChanged ; */

		public readonly Dictionary<string, string> DAY_FORMAT_NAME__CODE__DICTIONARY = new Dictionary<string, string>
		{
			{ "Полностью", "dddd" },
			{ "Сокращенно", "ddd" },
			{ "Число", "dd" }
		};
		public readonly Dictionary<string, string> MONTH_FORMAT_NAME__CODE__DICTIONARY = new Dictionary<string, string>
		{
			{ "Полностью", "MMMM" },
			{ "Сокращенно", "MMM" },
			{ "Число", "MM" }
		};
		public readonly Dictionary<string, string> YEAR_FORMAT_NAME__CODE__DICTIONARY = new Dictionary<string, string>
		{
			{ "Полностью", "yyyy" },
			{ "Две цифры", "yy" }
		};
		public readonly Dictionary<string, string> SEPARATOR_NAME__CODE__DICTIONARY = new Dictionary<string, string>
		{
			{ ".", "." },
			{ "/", "/" },
			{ "-", "-" },
			{ "Пробел", " " }
		};

		public DateFormatUserControl(EventHandler handler)
		{
			InitializeComponent();

			AnyControlChanged += handler;
			CmBox_Day.SelectedIndexChanged += OnAnyControlChanged;
			CmBox_Month.SelectedIndexChanged += OnAnyControlChanged;
			CmBox_Year.SelectedIndexChanged += OnAnyControlChanged;
			CmBox_Separator.SelectedIndexChanged += OnAnyControlChanged;

			CmBox_Day.DataSource = DAY_FORMAT_NAME__CODE__DICTIONARY.Keys.ToArray();
			CmBox_Month.DataSource = MONTH_FORMAT_NAME__CODE__DICTIONARY.Keys.ToArray();
			CmBox_Year.DataSource = YEAR_FORMAT_NAME__CODE__DICTIONARY.Keys.ToArray();
			CmBox_Separator.DataSource = SEPARATOR_NAME__CODE__DICTIONARY.Keys.ToArray();
		}
	}
}
