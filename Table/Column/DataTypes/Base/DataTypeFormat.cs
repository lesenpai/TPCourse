using System.Globalization;

namespace TPCourse.Table.Column.DataTypes.Format
{
	// Базовый класс свойств формата
	public abstract class DataTypeFormat
	{
		public CultureInfo Culture;

		public DataTypeFormat(CultureInfo culture)
		{
			Culture = culture;
		}

		public DataTypeFormat()
		{
			Culture = default;
		}
	}
}
