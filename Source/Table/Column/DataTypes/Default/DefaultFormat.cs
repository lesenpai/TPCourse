using System.Globalization;
using TPCourse.Source.Table.Column.DataTypes.Base;

namespace TPCourse.Source.Table.Column.DataTypes.Default
{
	public class DefaultFormat : DataTypeFormat
	{
		public DefaultFormat(string culture)
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
