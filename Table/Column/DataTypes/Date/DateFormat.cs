using System.Globalization;
using TPCourse.Table.Column.DataTypes.Date;

namespace TPCourse.Table.Column.DataTypes.Format
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

		public override string ToString()
		{
			// [day.]<separator><month><separator><year>[.millisecond]
			// TOADD dataType constants
			return ""; // DUMMY

		}
	}
}
