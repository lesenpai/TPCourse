using System;
using System.Xml.Serialization;

namespace TPCourse.Source.Table.Column.DataTypes.Base
{
	// Базовый класс свойств формата
	[
		XmlInclude(typeof(Default.DefaultFormat)),
		XmlInclude(typeof(Number.NumberFormat)),
		XmlInclude(typeof(Percent.PercentFormat)),
		XmlInclude(typeof(Currency.CurrencyFormat)),
		XmlInclude(typeof(Date.DateFormat)),
		XmlInclude(typeof(Duration.DurationFormat)),
	]
	[Serializable]
	public abstract class DataTypeFormat
	{
		public string Culture;

		public DataTypeFormat(string culture)
		{
			Culture = culture;
		}

		public DataTypeFormat()
		{
			Culture = ColumnConstants.DefaultCulture;
		}
	}
}
