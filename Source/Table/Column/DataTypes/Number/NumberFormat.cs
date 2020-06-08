using System.Globalization;
using TPCourse.Source.Table.Column.DataTypes.Base;

namespace TPCourse.Source.Table.Column.DataTypes.Number
{
	public class NumberFormat : DataTypeFormat
	{
		public int Precision;
		public bool HasSeparator;

		public NumberFormat(int presicion, bool bSeparator, CultureInfo culture)
			: base(culture)
		{
			Precision = presicion;
			HasSeparator = bSeparator;
		}

		public NumberFormat()
			: base()
		{
			Precision = default;
			HasSeparator = true;
		}

		// N|F[precision]
		public override string ToString()
		{
			string format = (HasSeparator) ? "N" : "F";
			format += Precision;

			return format;
		}
	}
}
