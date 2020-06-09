using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCourse.Source.Table;

namespace TPCourse.Source.Types
{
	/*
		Данные проекта (файл программы) - TableData массив
		*/
	public class ProjectData
	{
		public List<TableData> TableDatas { get; set; }

		public ProjectData()
		{
		}

		public ProjectData(List<TableData> tableDatas)
		{
			TableDatas = tableDatas;
		}
	}
}
