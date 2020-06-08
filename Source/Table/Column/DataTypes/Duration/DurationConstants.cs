using System.Collections.Generic;
using System.Linq;
using TPCourse.Source.Types;

namespace TPCourse.Source.Table.Column.DataTypes.Duration
{
	class DurationConstants
	{
		// [-][d.]hh:mm:ss[.fffffff]
		public static readonly Dictionary<string, string> PrecisionFormatName_Code_Dict = new Dictionary<string, string>
		{
			{ "Миллисекунд", "hh\\:mm\\:ss\\." }, // 'F' is used for replacement
			{ "Секунд",      "hh\\:mm\\:ss" },
			{ "Минут",       "hh\\:mm" },
			{ "Часов",       "hh" }
		};

		public static readonly Dictionary<string, string> MillisecondPrecisionFormatName_Code_Dict = new Dictionary<string, string>
		{
			{ "f",       "f" },
			{ "ff",      "ff" },
			{ "fff",     "fff" },
			{ "ffff",    "ffff" },
			{ "fffff",   "fffff" },
			{ "ffffff",  "ffffff" },
			{ "fffffff", "fffffff" },
		};

		public static readonly Dictionary<DurationPrecision, NameCodePair> PrecisionFormat_NameCodePair_Dict = 
			Utils.GetDictionary(DurationPrecision.Hour, PrecisionFormatName_Code_Dict);

		public static readonly Dictionary<DurationMillisecondPrecision, NameCodePair> MillisecondPrecisionFormat_NameCodePair_Dict = 
			Utils.GetDictionary(DurationMillisecondPrecision.F1, MillisecondPrecisionFormatName_Code_Dict);


		public static readonly Dictionary<NameCodePair, DurationPrecision> NameCodePair_PrecisionFormat_Dict =
			PrecisionFormat_NameCodePair_Dict.ToDictionary(x => x.Value, x => x.Key);

		public static readonly Dictionary<NameCodePair, DurationMillisecondPrecision> NameCodePair_MillisecondPrecisionFormat_Dict =
			MillisecondPrecisionFormat_NameCodePair_Dict.ToDictionary(x => x.Value, x => x.Key);
	}
}
