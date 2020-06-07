using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCourse.Table.Column.DataTypes.Date
{
	class DateConstants
	{
		public static readonly Dictionary<string, string> DateDayFormatName_Code_Dictionary = new Dictionary<string, string>
		{
			{ "Полностью",  "dddd" },
			{ "Сокращенно", "ddd" },
			{ "Число",      "dd" }
			// TOREPLACE
			// { DateType.Full, ("Полностью", "dddd") }
			// Dictionary<DateType, KeyValuePair<string, string>>
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
	}
}
