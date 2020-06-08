using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TPCourse.Source.Table.Column.DataTypes.Date
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
			CmBox_Day.SelectedIndexChanged       += OnAnyControlChanged;
			CmBox_Month.SelectedIndexChanged     += OnAnyControlChanged;
			CmBox_Year.SelectedIndexChanged      += OnAnyControlChanged;
			CmBox_Separator.SelectedIndexChanged += OnAnyControlChanged;

			CmBox_Day.DataSource = DateConstants.DayFormatName_Code_Dict.Keys.ToList();
			CmBox_Month.DataSource = DateConstants.MonthFormatName_Code_Dict.Keys.ToList();
			CmBox_Year.DataSource = DateConstants.YearFormatName_Code_Dict.Keys.ToList();
			CmBox_Separator.DataSource = DateConstants.SeparatorName_Code_Dict.Keys.ToList();

			CmBox_Day.SelectedIndex = (int)DateDay.Number;
			CmBox_Month.SelectedIndex = (int)DateMonth.Short;
			CmBox_Year.SelectedIndex = (int)DateYear.Full;
			CmBox_Separator.SelectedIndex = (int)DateSeparator.Space;
		}
	}
}
