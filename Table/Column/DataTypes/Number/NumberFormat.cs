using System.Globalization;

namespace TPCourse.Table.Column.DataTypes.Format
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

		public override string ToString()
		{
			// N|F[precision]
			string format = (HasSeparator) ? "N" : "F";
			format += Precision;

			return format;
		}
	}
}
