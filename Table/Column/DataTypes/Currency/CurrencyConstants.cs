using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCourse.Table.Column.DataTypes.Currency
{
	class CurrencyConstants
	{
		public static readonly Dictionary<string, string> Culture_Sign_Dictionary = new Dictionary<string, string>
		{
			{ "en-US", "$ (USD)" },
			{ "ru-RU", "₽ (RUB)" },
			{ "fr-FR", "€ (EUR)" }
		};
	}
}
