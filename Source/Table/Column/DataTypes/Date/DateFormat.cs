using System.Globalization;
using TPCourse.Source.Table.Column.DataTypes.Base;
using TPCourse.Source.Types;

namespace TPCourse.Source.Table.Column.DataTypes.Date
{
	public class DateFormat : DataTypeFormat
	{
		public DateDay Day;
		public DateMonth Month;
		public DateYear Year;
		public DateSeparator Separator;

		public DateFormat(DateDay day, DateMonth month, DateYear year, DateSeparator separator, CultureInfo culture)
			: base(culture)
		{
			Day = day;
			Month = month;
			Year = year;
			Separator = separator;
		}

		public DateFormat()
			: base()
		{
			Day = default;
			Month = default;
			Year = default;
			Separator = default;
		}

		// <day><separator><month><separator><year>[.millisecond]
		public override string ToString()
		{
			DateConstants.DayFormat_NameCodePair_Dict.TryGetValue(Day, out NameCodePair pair);
			var day = pair.Code;

			DateConstants.MonthFormat_NameCodePair_Dict.TryGetValue(Month, out pair);
			var month = pair.Code;

			DateConstants.YearFormat_NameCodePair_Dict.TryGetValue(Year, out pair);
			var year = pair.Code;

			DateConstants.SeparatorFormat_NameCodePair_Dict.TryGetValue(Separator, out pair);
			var separator = pair.Code;

			return
				  day   + separator
				+ month + separator
				+ year;
		}
	}
}
