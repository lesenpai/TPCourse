using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCourse.Source.Types;
using TPCourse.Table.Column.DataTypes;

namespace TPCourse.Source
{
	/*
		Вспомогательные/служебные/переферийные функции
		*/
	public class Utils
	{
		public static Dictionary<T, NameCodePair> GetDictionary<T>(T enum_, Dictionary<string, string> dict)
		{
			var result = new Dictionary<T, NameCodePair>();
			List<T> items = new List<T>();
			items.AddRange(Enum.GetValues(typeof(T)) as IEnumerable<T>);

			for (int i = 0; i < dict.Count; i++)
			{
				result.Add(items[i], new NameCodePair(dict.ElementAt(i)));
			}

			return result;
		}

		public static T GetDataTypeComponent<T>(string name, Dictionary<string, string> ncDict, Dictionary<NameCodePair, T> ncPairComponentDict)
		{
			ncDict.TryGetValue(name, out string code);
			var ncPair = new NameCodePair(name, code);
			ncPairComponentDict.TryGetValue(ncPair, out T result);

			return result;
		}
	}
}
