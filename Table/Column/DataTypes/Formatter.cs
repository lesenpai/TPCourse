using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCourse.Table.Column.DataTypes
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
			(bool success, T TResult) = parser(source, culture);
			result = (TResult as IFormattable).ToString(format, culture);//
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

		public static (bool, double) TryParseNumber(string source, CultureInfo culture)
		{
			var styles = NumberStyles.Number;
			return (double.TryParse(source, styles, culture, out double result), result);
		}

		public static (bool, double) TryParsePercent(string source, CultureInfo culture)
		{
			source = source.Replace("%", "");
			var styles = NumberStyles.Number;
			return (double.TryParse(source, styles, culture, out double result), result / 100);
		}

		public static (bool, double) TryParseCurrency(string source, CultureInfo culture)
		{
			var styles = NumberStyles.Currency;
			return (double.TryParse(source, styles, culture, out double result), result);
		}

		public static (bool, DateTime) TryParseDate(string source, CultureInfo culture)
		{
			return (DateTime.TryParse(source, out DateTime result), result);
		}

		public static (bool, TimeSpan) TryParseDuration(string source, CultureInfo culture)
		{
			return (TimeSpan.TryParse(source, out TimeSpan result), result);
		}
	}
}
