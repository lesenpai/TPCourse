using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCourse.Types
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
	}
}
