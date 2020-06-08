using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TPCourse.Source.Table.Column;
using TPCourse.Source.Table.Column.DataTypes;
using TPCourse.Source.Table.Column.DataTypes.Base;
using TPCourse.Source.Table.Column.DataTypes.Currency;
using TPCourse.Source.Table.Column.DataTypes.Date;
using TPCourse.Source.Table.Column.DataTypes.Default;
using TPCourse.Source.Table.Column.DataTypes.Duration;
using TPCourse.Source.Table.Column.DataTypes.Number;
using TPCourse.Source.Table.Column.DataTypes.Percent;

namespace TPCourse.Source.Types
{ 
	public partial class AddColumnDialog : Form
	{
		public Result<ColumnDescriptor> Result;
		private const string FORM_CAPTURE = "Добавление столбца";
		private readonly Dictionary<string, UserControl> DATA_FORMAT__USER_CONTROL__DICTIONARY;
		private bool Is_CmBox_ColumnDateType_DataSource_set = false;

		public AddColumnDialog()
		{
			InitializeComponent();
			FC_Pnl_DataTypeFormatConfiguration.Init(null, FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged);

			var items = new List<string>();
			DATA_FORMAT__USER_CONTROL__DICTIONARY = new Dictionary<string, UserControl>
			{
				{ "Default",  new DefaultFormatUserControl  (FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) },
				{ "Number",   new NumberFormatUserControl   (FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) },
				{ "Percent",  new PercentFormatUserControl  (FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) },
				{ "Currency", new CurrencyFormatUserControl (FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) },
				{ "Date",     new DateFormatUserControl     (FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) },
				{ "Duration", new DurationFormatUserControl (FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged) }
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

			// Результат диалога
			Result = new Result<ColumnDescriptor>(new ColumnDescriptor());
		}

		public DialogResult ShowDialog(ColumnDescriptor descriptor)
		{
			TB_ColumnName.Text = descriptor.Name;
			CmBox_ColumnDataType.SelectedIndex = (int)descriptor.DataType;

			SetFormatConfiguration(descriptor.Format);

			return base.ShowDialog();
		}

		// With default data type format
		public new DialogResult ShowDialog()
		{
			Lbl_SampleValue.Text = "";
			DATA_FORMAT__USER_CONTROL__DICTIONARY.TryGetValue("Default", out UserControl control);
			FC_Pnl_DataTypeFormatConfiguration.Control = control as INotifyAnyControlChanged;

			return base.ShowDialog();
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
					var control = (CurrencyFormatUserControl)panel.Control;
					control.NUD_Precision.Value = c.Precision;

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
						case DateDay.Full:
							dayIndex = 0;
							break;

						case DateDay.Short:
							dayIndex = 1;
							break;

						case DateDay.Number:
							dayIndex = 2;
							break;
					}

					dControl.CmBox_Day.SelectedIndex = dayIndex;
					int monthIndex;

					switch (d.Month)
					{
						default:
						case DateMonth.Full:
							monthIndex = 0;
							break;

						case DateMonth.Short:
							monthIndex = 1;
							break;

						case DateMonth.Number:
							monthIndex = 2;
							break;
					}

					dControl.CmBox_Month.SelectedIndex = monthIndex;
					int yearIndex;

					switch (d.Year)
					{
						default:
						case DateYear.Full:
							yearIndex = 0;
							break;

						case DateYear.TwoDigit:
							yearIndex = 1;
							break;
					}

					dControl.CmBox_Year.SelectedIndex = yearIndex;
					int separatorIndex;

					switch (d.Separator)
					{
						default:
						case DateSeparator.Point:
							separatorIndex = 0;
							break;

						case DateSeparator.Slash:
							separatorIndex = 1;
							break;

						case DateSeparator.Hyphen:
							separatorIndex = 2;
							break;

						case DateSeparator.Space:
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
						case DurationPrecision.Millisecond:
							precisionIndex = 0;
							break;

						case DurationPrecision.Second:
							precisionIndex = 1;
							break;

						case DurationPrecision.Minute:
							precisionIndex = 2;
							break;

						case DurationPrecision.Hour:
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
		}

		private void Btn_OK_Click(object sender, EventArgs e)
		{
			if (!ValidateColumnName())
			{
				MessageBox.Show("Название столбца не может быть пустым.", FORM_CAPTURE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			Result.Value.Name = TB_ColumnName.Text;
			Result.Value.DataType = (DataType)Enum.Parse(typeof(DataType), CmBox_ColumnDataType.Text);
			Result.Value.Format = GetDataTypeFormat(Result.Value.DataType, (UserControl)FC_Pnl_DataTypeFormatConfiguration.Control);
			Result.Success = true;

			Close();
		}

		private DataTypeFormat GetDataTypeFormat(DataType type, UserControl control)
		{
			switch(type)
			{
				case DataType.Number:
					return GetDataTypeFormat((NumberFormatUserControl)control);

				case DataType.Percent:
					return GetDataTypeFormat((PercentFormatUserControl)control);

				case DataType.Currency:
					return GetDataTypeFormat((CurrencyFormatUserControl)control);

				case DataType.Date:
					return GetDataTypeFormat((DateFormatUserControl)control);

				case DataType.Duration:
					return GetDataTypeFormat((DurationFormatUserControl)control);

				default:
					return GetDataTypeFormat((DefaultFormatUserControl)control);
			}
		}

		private NumberFormat GetDataTypeFormat(NumberFormatUserControl c)
		{
			int precision = (int)c.NUD_Precision.Value;
			bool hasSeparator = c.RBtn_DigitGroupSeparator.Checked;

			return new NumberFormat(precision, hasSeparator, ColumnConstants.DefaultCulture);
		}

		private PercentFormat GetDataTypeFormat(PercentFormatUserControl c)
		{
			int precision = (int)c.NUD_Precision.Value;

			return new PercentFormat(precision, ColumnConstants.DefaultCulture);
		}

		private CurrencyFormat GetDataTypeFormat(CurrencyFormatUserControl c)
		{
			int precision = (int)c.NUD_Precision.Value;
			var sign = c.CmBox_Currency.Text;
			CurrencyConstants.Sign_Culture_Dictionary.TryGetValue(sign, out string sCulture);
			var culture = CultureInfo.GetCultureInfo(sCulture);

			return new CurrencyFormat(precision, culture);
		}

		private DateFormat GetDataTypeFormat(DateFormatUserControl c)
		{
			var day = Utils.GetDataTypeComponent(
				c.CmBox_Day.Text, 
				DateConstants.DayFormatName_Code_Dict, 
				DateConstants.NameCodePair_DayFormat_Dict);

			var month = Utils.GetDataTypeComponent(
				c.CmBox_Month.Text,
				DateConstants.MonthFormatName_Code_Dict,
				DateConstants.NameCodePair_MonthFormat_Dict);

			var year = Utils.GetDataTypeComponent(
				c.CmBox_Year.Text,
				DateConstants.YearFormatName_Code_Dict,
				DateConstants.NameCodePair_YearFormat_Dict);

			var separator = Utils.GetDataTypeComponent(
				c.CmBox_Separator.Text,
				DateConstants.SeparatorName_Code_Dict,
				DateConstants.NameCodePair_SeparatorFormat_Dict);

			return new DateFormat(day, month, year, separator, ColumnConstants.DefaultCulture);
		}

		private DurationFormat GetDataTypeFormat(DurationFormatUserControl c)
		{
			var precision = Utils.GetDataTypeComponent(
				c.CmBox_Precision.Text,
				DurationConstants.PrecisionFormatName_Code_Dict,
				DurationConstants.NameCodePair_PrecisionFormat_Dict);

			var millisecondPrecision = Utils.GetDataTypeComponent(
				c.CmBox_MillisecondPrecision.Text,
				DurationConstants.MillisecondPrecisionFormatName_Code_Dict,
				DurationConstants.NameCodePair_MillisecondPrecisionFormat_Dict);

			return new DurationFormat(precision, millisecondPrecision, ColumnConstants.DefaultCulture);
		}

		private DefaultFormat GetDataTypeFormat(DefaultFormatUserControl c)
		{
			return new DefaultFormat();
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			Result = Result<ColumnDescriptor>.False();

			Close();
		}

		private bool ValidateColumnName()
		{
			return !string.IsNullOrEmpty(TB_ColumnName.Text);
		}

		/*
			Обновление образца форматированной строки
			*/
		private void FC_Pnl_DataTypeFormatConfiguration_ChildControlChanged(object sender, EventArgs e)
		{
			if(!Is_CmBox_ColumnDateType_DataSource_set)
			{
				return;
			}

			string sDataType = CmBox_ColumnDataType.Text;
			DataType dataType = (DataType)Enum.Parse(typeof(DataType), sDataType);
			string source;

			// "ru-RU" culture
			switch(dataType)
			{
				case DataType.Number:
					source = "1234,56789";
					break;

				case DataType.Percent:
					source = "1,0045";
					break;

				case DataType.Currency:
					source = "1234,25";
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
			string format = GetDataTypeFormat(dataType, control).ToString();//

			UpdateCulture(control);

			var culture = Result.Value.Format.Culture;
			Formatter.TryFormat(source, dataType, format, culture, out string sample);
			Lbl_SampleValue.Text = sample;
		}

		private void UpdateCulture(UserControl control)
		{
			if (CmBox_ColumnDataType.SelectedIndex == (int)DataType.Currency)
			{
				var sign = (control as CurrencyFormatUserControl).CmBox_Currency.Text;
				CurrencyConstants.Sign_Culture_Dictionary.TryGetValue(sign, out string sCulture);
				Result.Value.Format.Culture = CultureInfo.GetCultureInfo(sCulture);
			}
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

			UpdateCulture(control);
		}
	}
}
