using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TPCourse.Table.Column.DataTypes;
using TPCourse.Table.Column.DataTypes.DataTypeFormatUserControls;
using TPCourse.Table.Column.DataTypes.Format;

namespace TPCourse.Table.Column
{ 
	public partial class AddTableColumnDialog : Form
	{
		public Result<TableColumnDescriptor> Result;
		private const string FORM_CAPTURE = "Добавление столбца";
		//private const string LBL_DATA_FORMAT_LABEL_NONE = "( ... )";
		private readonly Dictionary<string, UserControl> DATA_FORMAT__USER_CONTROL__DICTIONARY;
		private bool Is_CmBox_ColumnDateType_DataSource_set = false;

		//public DataTypeFormat Format = new DefaultFormat();

		//private User

		public AddTableColumnDialog()
		{
			InitializeComponent();
			FC_Pnl_DataTypeFormatConfiguration.Init(null, FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged);

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
			//FC_Pnl_DataTypeFormatConfiguration.Control = (INotifyAnyControlChanged)userControl;

			// Результат диалога
			Result = new Result<TableColumnDescriptor>(new TableColumnDescriptor());
		}

		/*// задать начальные значения для элементов ввода
		public void SetUserInput(string columnName, string dataType*//*,*//* )
		{
			TableColumnDescriptor d;
			d.
		}*/

		public DialogResult ShowDialog(DataTypeFormat format)
		{
			SetFormatConfiguration(format);

			return ShowDialog();
		}

		// VIEW
		private void SetFormatConfiguration(DataTypeFormat format)
		{
			FormatConfigurationPanel panel = FC_Pnl_DataTypeFormatConfiguration;

			void SetLayout (string typeName)
			{
				DATA_FORMAT__USER_CONTROL__DICTIONARY.TryGetValue(typeName, out UserControl c);
				panel.Control = (INotifyAnyControlChanged)c;
			}

			switch (format)
			{
				case NumberFormat n:
				{
					SetLayout("Number");
					var nControl = (NumberFormatUserControl)panel.Control;
					nControl.NUD_Precision.Value = n.Precision;
					nControl.RBtn_DigitGroupSeparator.Checked = n.HasSeparator;
					//panel.Contorl = c; ?
					break;
				}

				case PercentFormat p:
				{
					SetLayout("Percent");
					var pControl = (PercentFormatUserControl)panel.Control;
					pControl.NUD_Precision.Value = p.Precision;
					break;
				}

				case CurrencyFormat c:
				{
					SetLayout("Currency");
					var cControl = (CurrencyFormatUserControl)panel.Control;
					cControl.NUD_Precision.Value = c.Precision;
					break;
				}

				case DateFormat d:
				{
					SetLayout("Date");
					var dControl = (DateFormatUserControl)panel.Control;
					int dayIndex;

					switch (d.Day)
					{
						default:
						case DataTypes.Date.DateDay.Full:
							dayIndex = 0;
							break;

						case DataTypes.Date.DateDay.Short:
							dayIndex = 1;
							break;

						case DataTypes.Date.DateDay.Number:
							dayIndex = 2;
							break;
					}

					dControl.CmBox_Day.SelectedIndex = dayIndex;
					int monthIndex;

					switch (d.Month)
					{
						default:
						case DataTypes.Date.DateMonth.Full:
							monthIndex = 0;
							break;

						case DataTypes.Date.DateMonth.Short:
							monthIndex = 1;
							break;

						case DataTypes.Date.DateMonth.Number:
							monthIndex = 2;
							break;
					}

					dControl.CmBox_Month.SelectedIndex = monthIndex;
					int yearIndex;

					switch (d.Year)
					{
						default:
						case DataTypes.Date.DateYear.Full:
							yearIndex = 0;
							break;

						case DataTypes.Date.DateYear.TwoDigit:
							yearIndex = 1;
							break;
					}

					dControl.CmBox_Year.SelectedIndex = yearIndex;
					int separatorIndex;

					switch (d.Separator)
					{
						default:
						case DataTypes.Date.DateSeparator.Point:
							separatorIndex = 0;
							break;

						case DataTypes.Date.DateSeparator.Slash:
							separatorIndex = 1;
							break;

						case DataTypes.Date.DateSeparator.Hyphen:
							separatorIndex = 2;
							break;

						case DataTypes.Date.DateSeparator.Space:
							separatorIndex = 3;
							break;
					}

					dControl.CmBox_Separator.SelectedIndex = separatorIndex;

					break;
				}

				case DurationFormat d:
				{
					SetLayout("Duration");
					var control = (DurationFormatUserControl)panel.Control;
					int precisionIndex;

					switch(d.Precision)
					{
						default:
						case DataTypes.Duration.DurationPrecision.Millisecond:
							precisionIndex = 0;
							break;

						case DataTypes.Duration.DurationPrecision.Second:
							precisionIndex = 1;
							break;

						case DataTypes.Duration.DurationPrecision.Minute:
							precisionIndex = 2;
							break;

						case DataTypes.Duration.DurationPrecision.Hour:
							precisionIndex = 3;
							break;
					}

					control.CmBox_Precision.SelectedIndex = precisionIndex;
					int msPrecisionIndex = (int)d.MillisecondPrecision;
					control.CmBox_MillisecondPrecision.SelectedIndex = msPrecisionIndex;

					break;
				}

				default:
				{
					SetLayout("Default");
					var control = (DefaultFormatUserControl)panel.Control;
					//panel.Control = control; ?

					break;
				}
			}

			//SetLayout();
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
			(Result.Value.FormatString, Result.Value.Culture) = GetDataTypeFormat((UserControl)FC_Pnl_DataTypeFormatConfiguration.Control);
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

		// TOREPLACE BY DataTypeFormat.ToString
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
			c.CURRENCY__CULTURE__DICTIONARY.TryGetValue(c.CmBox_Currency.Text, out string culture);

			return (formatString, CultureInfo.GetCultureInfo(culture));
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
				//c.RBtn_ShowDays.Checked,
				hmsPart,
				c.CmBox_MillisecondPrecision.Enabled,
				c.CmBox_MillisecondPrecision.Text),
				CultureInfo.InvariantCulture);
		}

		private string GetDurationFormat(/*bool bDisplayDays, */string hmsPart, bool bDisplayMilliseconds, string millisecondPart)
		{
			// <days>:<hour>:<minute>:<second>:<ms>
			//string format = (bDisplayDays) ? "d\\." : "";
			string format = hmsPart;
			
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
