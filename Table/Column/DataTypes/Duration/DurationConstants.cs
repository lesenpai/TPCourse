using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCourse.Table.Column.DataTypes.Duration
{
	class DurationConstants
	{
		public static readonly Dictionary<string, string> DurationPrecisionName_Code_Dictionary = new Dictionary<string, string>
		{
			// [-][d.]hh:mm:ss[.fffffff]
			{ "Миллисекунд", "hh\\:mm\\:ss\\.F"}, // 'F' should be replaced 
			{ "Секунд",      "hh\\:mm\\:ss" },
			{ "Минут",       "hh\\:mm" },
			{ "Часов",       "hh" }
		};

		public static readonly string[] DurationMillisecondsPrecisions =
		{
			"f",
			"ff",
			"fff",
			"ffff",
			"fffff",
			"ffffff",
			"fffffff"
		};
	}
}
