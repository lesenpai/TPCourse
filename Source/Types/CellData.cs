using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCourse.Source.Types
{
	// TODO: REMOVE - NOTUSED
	public class CellData
	{
		public string Value { get; set; }

		public CellData(string value)
		{
			Value = value;
		}

		// сохраняет значение с исходной точностью (для числовых типов)
		//public object FullValue { get; set; }
	}
}
