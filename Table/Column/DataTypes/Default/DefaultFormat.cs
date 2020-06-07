using System.Globalization;

namespace TPCourse.Table.Column.DataTypes.Format
{
	public class DefaultFormat : DataTypeFormat
	{
		public DefaultFormat(CultureInfo culture)
			: base(culture)
		{
		}

		public DefaultFormat()
			: base()
		{
		}

		public override string ToString()
		{
			return "";
		}
	}
}
