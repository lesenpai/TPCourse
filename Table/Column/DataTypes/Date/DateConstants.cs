using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCourse.Types;

namespace TPCourse.Table.Column.DataTypes.Date
{
	class DateConstants
	{
		/*public static readonly Dictionary<string, string> DateDayFormatName_Code_Dictionary = new Dictionary<string, string>
		{
			{ "Полностью",  "dddd" },
			{ "Сокращенно", "ddd" },
			{ "Число",      "dd" }
			// TOREPLACE
			// { DateType.Full, ("Полностью", "dddd") }
			// Dictionary<DateType, KeyValuePair<string, string>>
		};*/

		public static readonly Dictionary<DateDay, NameCodePair> DayFormat_NameCodePair_Dictionary = new Dictionary<DateDay, NameCodePair>
		{
			{ DateDay.Full, new NameCodePair   ("Полностью",  "dddd") },
			{ DateDay.Short, new NameCodePair  ("Сокращенно", "ddd") },
			{ DateDay.Number, new NameCodePair ("Число",      "dd") }
		};

		/*public static readonly Dictionary<string, string> DateMonthFormatName_Code_Dictionary = new Dictionary<string, string>
		{
			{ "Полностью",  "MMMM" },
			{ "Сокращенно", "MMM" },
			{ "Число",      "MM" }
		};*/

		public static readonly Dictionary<DateMonth, NameCodePair> MonthFormat_NameCodePair_Dictionary = new Dictionary<DateMonth, NameCodePair>
		{
			{ DateMonth.Full, new NameCodePair   ("Полностью",  "MMMM") },
			{ DateMonth.Short, new NameCodePair  ("Сокращенно", "MMM") },
			{ DateMonth.Number, new NameCodePair ("Число",      "MM") }
		};

		/*public static readonly Dictionary<string, string> DateYearFormatName_Code_Dictionary = new Dictionary<string, string>
		{
			{ "Полностью", "yyyy" },
			{ "Две цифры", "yy" }
		};*/

		public static readonly Dictionary<DateYear, NameCodePair> YearFormat_NameCodePair_Dictionary = new Dictionary<DateYear, NameCodePair>
		{
			{ DateYear.Full, new NameCodePair     ("Полностью", "yyyy") },
			{ DateYear.TwoDigit, new NameCodePair ("Две цифры", "yy") }
		};

		/*public static readonly Dictionary<string, string> DateSeparatorName_Code_Dictionary = new Dictionary<string, string>
		{
			{ ".",      "." },
			{ "/",      "/" },
			{ "-",      "-" },
			{ "Пробел", " " }
		};*/

		public static readonly Dictionary<DateSeparator, NameCodePair> SeparatorFormat_NameCodePair_Dictionary = new Dictionary<DateSeparator, NameCodePair>
		{
			{ DateSeparator.Point, new NameCodePair  (".",      ".") },
			{ DateSeparator.Slash, new NameCodePair  ("/",      "/") },
			{ DateSeparator.Hyphen, new NameCodePair ("Пробел", " ") }
		};
	}
}
