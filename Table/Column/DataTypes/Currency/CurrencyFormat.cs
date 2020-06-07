using System.Globalization;

namespace TPCourse.Table.Column.DataTypes.Format
{
	public class CurrencyFormat : DataTypeFormat
	{
		public int Precision;

		public CurrencyFormat(int presicion, CultureInfo culture)
			: base(culture)
		{
			Precision = presicion;
		}

		public CurrencyFormat()
			: base()
		{
			Precision = default;
		}

		public override string ToString()
		{
			//C[precision]
			return "C" + Precision;
		}
	}
}
