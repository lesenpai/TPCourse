using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using TPCourse.Table.Column.DataTypes;
using TPCourse.Table.Column.DataTypes.DataTypeFormatUserControls;

namespace TPCourse.Table.Column
{ 
	public partial class AddTableColumnDialog : Form
	{
		public Result<TableColumnDescriptor> Result;
		private const string FORM_CAPTURE = "Добавление столбца";
		//private const string LBL_DATA_FORMAT_LABEL_NONE = "( ... )";
		private readonly Dictionary<string, UserControl> DATA_FORMAT__USER_CONTROL__DICTIONARY;
		private bool Is_CmBox_ColumnDateType_DataSource_set = false;

		//private User

		public AddTableColumnDialog()
		{
			InitializeComponent();

			var items = new List<string>();
			DATA_FORMAT__USER_CONTROL__DICTIONARY = new Dictionary<string, UserControl>
			{
				{ "Default",  new DefaultFormatUserControl(FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) },
				{ "Number",   new NumberFormatUserControl(FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) },
				{ "Percent",  new PercentFormatUserControl(FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) },
				{ "Currency", new CurrencyFormatUserControl(FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) },
				{ "Date",     new DateFormatUserControl(FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) },
				{ "Duration", new DurationFormatUserControl(FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) }
			};

			// Тип данных
			foreach (var item in Enum.GetNames(typeof(DataType)))
			{
				items.Add(item.ToString());
			}

			CmBox_ColumnDataType.DataSource = items;
			Is_CmBox_ColumnDateType_DataSource_set = true;

			// Формат данных
			DATA_FORMAT__USER_CONTROL__DICTIONARY.TryGetValue(
				CmBox_ColumnDataType.Text,
				out UserControl userControl);
			//FC_Pnl_DataTypeFormatConfiguration.Controls.Add(userControl);
			FC_Pnl_DataTypeFormatConfiguration.Control = (INotifyAnyControlChanged)userControl;

			// Результат диалога
			Result = new Result<TableColumnDescriptor>(new TableColumnDescriptor());
		}

		private void Btn_OK_Click(object sender, EventArgs e)
		{
			if (!ValidateColumnName())
			{
				MessageBox.Show("Название столбца не может быть пустым.", FORM_CAPTURE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			Result.Value.Name = TBox_ColumnName.Text;
			Result.Value.DataType = (DataType)Enum.Parse(typeof(DataType), CmBox_ColumnDataType.Text);
			(Result.Value.Format, Result.Value.Culture) = GetDataTypeFormat((UserControl)FC_Pnl_DataTypeFormatConfiguration.Controls[0]);
			Result.Success = true;

			Close();
		}

		private (string, CultureInfo) GetDataTypeFormat(UserControl control)
		{
			switch (CmBox_ColumnDataType.Text)
			{
				case "Default":
					return ("", CultureInfo.InvariantCulture);

				case "Number":
					return GetNumberFormat((NumberFormatUserControl)control);

				case "Percent":
					return GetPercentFormat((PercentFormatUserControl)control);

				case "Currency":
					return GetCurrencyFormat((CurrencyFormatUserControl)control);

				case "Date":
					return GetDateFormat((DateFormatUserControl)control);

				case "Duration": 
					return GetDurationFormat((DurationFormatUserControl)control);

				default:
					return ("", CultureInfo.InvariantCulture);
			}
		}

		private (string, CultureInfo) GetNumberFormat(NumberFormatUserControl c) => GetNumberFormat(c.RBtn_DigitGroupSeparator.Checked, (int)c.NUD_Precision.Value);

		private (string, CultureInfo) GetNumberFormat(bool bSeparator, int precision)
		{
			// N|F[precision]
			string format = "";
			format += (bSeparator) ? "N" : "F";
			format += precision;

			return (format, CultureInfo.InvariantCulture);
		}

		private (string, CultureInfo) GetPercentFormat(int precision)
		{
			// P<precision>
			return ("P" + precision, CultureInfo.InvariantCulture);
		}

		private (string, CultureInfo) GetPercentFormat(PercentFormatUserControl c) => GetPercentFormat((int)c.NUD_Precision.Value);

		private (string, CultureInfo) GetCurrencyFormat(CurrencyFormatUserControl c)
		{
			// C<precision>, CultureInfo (USD:en-US, RUB:ru-RU, EUR:fr-FR)
			var formatString = GetCurrencyFormat((int)c.NUD_Precision.Value);
			c.CURRENCY__CULTURE__DICTIONARY.TryGetValue(c.CmBox_Currency.Text, out CultureInfo culture);
			return (formatString, culture);
		}

		private (string, CultureInfo) GetDateFormat(DateFormatUserControl c)
		{
			// <day><separator><month><separator><year>
			c.DAY_FORMAT_NAME__CODE__DICTIONARY.TryGetValue(c.CmBox_Day.Text, out string day);
			c.MONTH_FORMAT_NAME__CODE__DICTIONARY.TryGetValue(c.CmBox_Month.Text, out string month);
			c.YEAR_FORMAT_NAME__CODE__DICTIONARY.TryGetValue(c.CmBox_Year.Text, out string year);
			c.SEPARATOR_NAME__CODE__DICTIONARY.TryGetValue(c.CmBox_Separator.Text, out string separator);

			return (GetDateFormat(day, month, year, separator), CultureInfo.InvariantCulture);
		}

		private string GetDateFormat(string day, string month, string year, string separator)
		{
			return day + separator + month + separator + year;
		}

		private (string, CultureInfo) GetDurationFormat(DurationFormatUserControl c)
		{
			c.PRECISION_NAME__CODE__DICTIONARY.TryGetValue(c.CmBox_Precision.Text, out string hmsPart);

			return (GetDurationFormat(
				c.RBtn_ShowDays.Checked,
				hmsPart,
				c.CmBox_MillisecondPrecision.Enabled,
				c.CmBox_MillisecondPrecision.Text),
				CultureInfo.InvariantCulture);
		}

		private string GetDurationFormat(bool bDisplayDays, string hmsPart, bool bDisplayMilliseconds, string millisecondPart)
		{
			// <days>:<hour>:<minute>:<second>:<ms>
			string format = (bDisplayDays) ? "d\\." : "";
			format += hmsPart;
			
			if(bDisplayMilliseconds)
			{
				format += millisecondPart;
			}

			return format;
		}

		private string GetCurrencyFormat(int precision)
		{
			// C<precision>
			return "C" + precision;
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			Result = Result.Calceled();
		}

		private bool ValidateColumnName()
		{
			return !string.IsNullOrEmpty(TBox_ColumnName.Text);
		}

		/*
			Обновление образца форматированной строки
			*/
		private void FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged(object sender, EventArgs e)
		{
			// typeof(panel.Control) -> Formatter.TryFormat()
			// TODO: константы ключей словаря типДанных:контрол; словарь типДанных(constStringValue):типUserControl
			if(!Is_CmBox_ColumnDateType_DataSource_set)
			{
				return;
			}

			string sDataType = CmBox_ColumnDataType.Text;
			DataType dataType = (DataType)Enum.Parse(typeof(DataType), sDataType);
			string source;

			switch(dataType)
			{
				case DataType.Number:
					source = "1234.56789";
					break;

				case DataType.Percent:
					source = "1.0045";
					break;

				case DataType.Currency:
					source = "1234,99";
					break;

				case DataType.Date:
					source = "01.01.2020";
					break;

				case DataType.Duration:
					source = "7.05:40:12";
					break;

				default:
					source = "";
					break;
			}

			DATA_FORMAT__USER_CONTROL__DICTIONARY.TryGetValue(sDataType, out UserControl control);
			(string format, CultureInfo culture) = GetDataTypeFormat(control);
			Formatter.TryFormat(source, dataType, format, culture, out string sample);
			Lbl_SampleValue.Text = sample;
		}

		/*
			Обновление раскладки параметров выбранного формата
			*/
		private void CmBox_ColumnDataType_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Обновление раскладки параметров выбранного формата
			if (!Is_CmBox_ColumnDateType_DataSource_set)
			{
				return;
			}

			var sDataType = CmBox_ColumnDataType.Text;
			DATA_FORMAT__USER_CONTROL__DICTIONARY.TryGetValue(sDataType, out UserControl control);
			FC_Pnl_DataTypeFormatConfiguration.Control = (INotifyAnyControlChanged)control;
			FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged(null, null);
		}
	}
}
