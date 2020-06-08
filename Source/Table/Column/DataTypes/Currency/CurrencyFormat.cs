using System.Globalization;
using TPCourse.Source.Table.Column.DataTypes.Base;

namespace TPCourse.Source.Table.Column.DataTypes.Currency
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

		//C[precision]
		public override string ToString()
		{
			return "C" + Precision;
		}
	}
}
