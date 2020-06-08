using System.Collections.Generic;
using System.Linq;
using TPCourse.Source.Types;

namespace TPCourse.Source.Table.Column.DataTypes.Date
{
	class DateConstants
	{
		public static readonly Dictionary<string, string> DayFormatName_Code_Dict = new Dictionary<string, string>
		{
			{ "Полностью",  "dddd" },
			{ "Сокращенно", "ddd" },
			{ "Число",      "dd" }
		};

		public static readonly Dictionary<string, string> MonthFormatName_Code_Dict = new Dictionary<string, string>
		{
			{ "Полностью",  "MMMM" },
			{ "Сокращенно", "MMM" },
			{ "Число",      "MM" }
		};

		public static readonly Dictionary<string, string> YearFormatName_Code_Dict = new Dictionary<string, string>
		{
			{ "Полностью", "yyyy" },
			{ "Две цифры", "yy" }
		};

		public static readonly Dictionary<string, string> SeparatorName_Code_Dict = new Dictionary<string, string>
		{
			{ ".",      "." },
			{ "/",      "\\/" },
			{ "-",      "-" },
			{ "Пробел", " " }
		};
		
		public static readonly Dictionary<DateDay, NameCodePair>   DayFormat_NameCodePair_Dict = 
			Utils.GetDictionary(DateDay.Full, DayFormatName_Code_Dict);

		public static readonly Dictionary<DateMonth, NameCodePair> MonthFormat_NameCodePair_Dict = 
			Utils.GetDictionary(DateMonth.Full, MonthFormatName_Code_Dict);

		public static readonly Dictionary<DateYear, NameCodePair> YearFormat_NameCodePair_Dict = 
			Utils.GetDictionary(DateYear.Full, YearFormatName_Code_Dict);

		public static readonly Dictionary<DateSeparator, NameCodePair> SeparatorFormat_NameCodePair_Dict = 
			Utils.GetDictionary(DateSeparator.Hyphen, SeparatorName_Code_Dict);


		public static readonly Dictionary<NameCodePair, DateDay> NameCodePair_DayFormat_Dict = 
			DayFormat_NameCodePair_Dict.ToDictionary(x => x.Value, x => x.Key);

		public static readonly Dictionary<NameCodePair, DateSeparator> NameCodePair_SeparatorFormat_Dict = 
			SeparatorFormat_NameCodePair_Dict.ToDictionary(x => x.Value, x => x.Key);

		public static readonly Dictionary<NameCodePair, DateMonth> NameCodePair_MonthFormat_Dict = 
			MonthFormat_NameCodePair_Dict.ToDictionary(x => x.Value, x => x.Key);

		public static readonly Dictionary<NameCodePair, DateYear> NameCodePair_YearFormat_Dict = 
			YearFormat_NameCodePair_Dict.ToDictionary(x => x.Value, x => x.Key);
	}
}
