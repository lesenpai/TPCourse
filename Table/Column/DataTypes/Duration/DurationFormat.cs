using System.Globalization;
using TPCourse.Table.Column.DataTypes.Duration;

namespace TPCourse.Table.Column.DataTypes.Format
{
	public class DurationFormat : DataTypeFormat
	{
		public DurationPrecision Precision;
		public DurationMillisecondPrecision MillisecondPrecision;

		public DurationFormat(DurationPrecision precision, DurationMillisecondPrecision millisecondPrecision, CultureInfo culture)
			: base(culture)
		{
			Precision = precision;
			MillisecondPrecision = millisecondPrecision;
		}

		public DurationFormat()
			: base()
		{
			Precision = default;
			MillisecondPrecision = default;
		}
	}
}
