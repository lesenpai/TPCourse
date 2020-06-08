using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCourse.Source.Types
{
	public struct NameCodePair
	{
		public string Name { get; set; }
		public string Code { get; set; }

		public NameCodePair(string name, string code)
		{
			Name = name;
			Code = code;
		}

		public NameCodePair(KeyValuePair<string, string> pair)
		{
			Name = pair.Key;
			Code = pair.Value;
		}
	}
}
