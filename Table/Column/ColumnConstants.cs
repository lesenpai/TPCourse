using System.Collections.Generic;

namespace TPCourse.Table.Column
{
	public class ColumnConstants
	{
		public static readonly Dictionary<string, string> CurrencyCulture_Sign_Dictionary = new Dictionary<string, string>
		{
			{ "en-US", "$ (USD)" },
			{ "ru-RU", "₽ (RUB)" },
			{ "fr-FR", "€ (EUR)" }
		};

		public static readonly Dictionary<string, string> DateDayFormatName_Code_Dictionary = new Dictionary<string, string>
		{
			{ "Полностью",  "dddd" },
			{ "Сокращенно", "ddd" },
			{ "Число",      "dd" }
		};

		public static readonly Dictionary<string, string> DateMonthFormatName_Code_Dictionary = new Dictionary<string, string>
		{
			{ "Полностью",  "MMMM" },
			{ "Сокращенно", "MMM" },
			{ "Число",      "MM" }
		};

		public static readonly Dictionary<string, string> DateYearFormatName_Code_Dictionary = new Dictionary<string, string>
		{
			{ "Полностью", "yyyy" },
			{ "Две цифры", "yy" }
		};

		public static readonly Dictionary<string, string> DateSeparatorName_Code_Dictionary = new Dictionary<string, string>
		{
			{ ".",      "." },
			{ "/",      "/" },
			{ "-",      "-" },
			{ "Пробел", " " }
		};

		public static readonly Dictionary<string, string> DurationPrecisionName_Code_Dictionary = new Dictionary<string, string>
		{
			// [-][d.]hh:mm:ss[.fffffff]
			{ "Миллисекунд", "hh\\:mm\\:ss\\.F"}, // 'F' should be replaced 
			{ "Секунд",      "hh\\:mm\\:ss" },
			{ "Минут",       "hh\\:mm" },
			{ "Часов",       "hh" }
		};

		public static readonly string[] DurationMillisecondsPrecisions =
		{
			"f",
			"ff",
			"fff",
			"ffff",
			"fffff",
			"ffffff",
			"fffffff"
		};
	}
}
