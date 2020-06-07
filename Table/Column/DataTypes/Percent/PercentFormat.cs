using System.Globalization;

namespace TPCourse.Table.Column.DataTypes.Format
{
	public class PercentFormat : DataTypeFormat
	{
		public int Precision;

		public PercentFormat(int presicion, CultureInfo culture)
			: base(culture)
		{
			Precision = presicion;
		}

		public PercentFormat()
			: base()
		{
			Precision = default;
		}

		public override string ToString()
		{
			//P[precision]
			return "P" + Precision;
		}
	}
}
