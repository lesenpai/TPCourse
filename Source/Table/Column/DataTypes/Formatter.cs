using System;
using System.Globalization;
using TPCourse.Source.Table.Column.DataTypes.Base;

namespace TPCourse.Source.Table.Column.DataTypes
{
	/*
		@summary Форматирует строку по типу данных

		@get format string
		@return formatted string
		*/
	public class Formatter
	{
		private static bool TryFormatDataType<T> (
			string source, string format, CultureInfo culture, out string result,
			Func<string, CultureInfo, (bool, T)> parser) 

			where T : IFormattable
		{
			(bool success, T tResult) = parser(source, culture);
			result = (tResult as IFormattable).ToString(format, culture);//
			return success;
		}

		public static bool TryFormat(string source, DataType dataType, string format, CultureInfo culture, out string result)
		{
			switch(dataType)
			{
				case DataType.Number:
					return TryFormatDataType(source, format, culture, out result, TryParseNumber);

				case DataType.Percent:
					return TryFormatDataType(source, format, culture, out result, TryParsePercent);

				case DataType.Currency: 
					return TryFormatDataType(source, format, culture, out result, TryParseCurrency);

				case DataType.Date:
					return TryFormatDataType(source, format, culture, out result, TryParseDate);

				case DataType.Duration:
					return TryFormatDataType(source, format, culture, out result, TryParseDuration);
				
				default:
					result = "";
					return false;
			}
		}

		private static (bool, double) TryParseNumber(string source, CultureInfo culture)
		{
			var styles = NumberStyles.Number;
			return (double.TryParse(source, styles, culture, out double result), result);
		}

		// <double><" "><%>
		private static (bool, double) TryParsePercent(string source, CultureInfo culture)
		{
			// {" "}<double>" "%{" "}
			source = source.Trim(); // <double>" "%
			var styles = NumberStyles.Number;

			if (source.EndsWith("%"))
			{
				source = source.Substring(0, source.Length - 1); // <double>" "
				return (double.TryParse(source, styles, culture, out double result), result / 100);
			}
			else
			{
				return (double.TryParse(source, styles, culture, out double result), result);
			}
		}

		private static (bool, double) TryParseCurrency(string source, CultureInfo culture)
		{
			var styles = NumberStyles.Currency;
			return (double.TryParse(source, styles, culture, out double result), result);
		}

		private static (bool, DateTime) TryParseDate(string source, CultureInfo culture)
		{
			return (DateTime.TryParse(source, out DateTime result), result);
		}

		private static (bool, TimeSpan) TryParseDuration(string source, CultureInfo culture)
		{
			return (TimeSpan.TryParse(source, out TimeSpan result), result);
		}
	}
}
