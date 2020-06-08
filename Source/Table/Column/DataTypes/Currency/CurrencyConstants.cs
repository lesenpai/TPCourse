using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCourse.Source.Table.Column.DataTypes.Currency
{
	public class CurrencyConstants
	{
		public static readonly Dictionary<string, string> Sign_Culture_Dictionary = new Dictionary<string, string>
		{
			{ "$ (USD)", "en-US" },
			{ "₽ (RUB)", "ru-RU" },
			{ "€ (EUR)", "fr-FR" }
		};
	}
}
