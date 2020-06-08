using System.Globalization;
using TPCourse.Source.Table.Column.DataTypes.Base;
using TPCourse.Source.Types;

namespace TPCourse.Source.Table.Column.DataTypes.Duration
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

		public override string ToString()
		{
			DurationConstants.PrecisionFormat_NameCodePair_Dict.TryGetValue(Precision, out NameCodePair pair);
			var precision = pair.Code;
			
			if(Precision == DurationPrecision.Millisecond)
			{
				DurationConstants.MillisecondPrecisionFormat_NameCodePair_Dict.TryGetValue(MillisecondPrecision, out NameCodePair msNcPair);
				
				return precision + msNcPair.Code;
			}
			else
			{
				return precision;
			}
		}
	}
}
