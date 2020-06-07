using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TPCourse.Table.Column.DataTypes.DataTypeFormatUserControls
{
	public partial class DateFormatUserControl : UserControl, INotifyAnyControlChanged
	{
		/* INofifyAnyControlChanged */
		public event EventHandler AnyControlChanged;
		public void OnAnyControlChanged(object sender, EventArgs e) => AnyControlChanged.Invoke(null, null);
		/* INofifyAnyControlChanged ; */

		public DateFormatUserControl(EventHandler eventHandler)
		{
			InitializeComponent();

			AnyControlChanged += eventHandler;
			CmBox_Day.SelectedIndexChanged += OnAnyControlChanged;
			CmBox_Month.SelectedIndexChanged += OnAnyControlChanged;
			CmBox_Year.SelectedIndexChanged += OnAnyControlChanged;
			CmBox_Separator.SelectedIndexChanged += OnAnyControlChanged;

			CmBox_Day.DataSource = ColumnConstants.DateDayFormatName_Code_Dictionary.Keys.ToArray();
			CmBox_Month.DataSource = ColumnConstants.DateMonthFormatName_Code_Dictionary.Keys.ToArray();
			CmBox_Year.DataSource = ColumnConstants.DateYearFormatName_Code_Dictionary.Keys.ToArray();
			CmBox_Separator.DataSource = ColumnConstants.DateSeparatorName_Code_Dictionary.Keys.ToArray();

			CmBox_Day.SelectedIndex = 2;
			CmBox_Month.SelectedIndex = 1;
			CmBox_Year.SelectedIndex = 0;
			CmBox_Separator.SelectedIndex = 3;
		}
	}
}
