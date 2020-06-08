using System.Globalization;
using TPCourse.Source.Table.Column.DataTypes.Base;

namespace TPCourse.Source.Table.Column.DataTypes.Percent
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

		//P[precision]
		public override string ToString()
		{
			return "P" + Precision;
		}
	}
}
