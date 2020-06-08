using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCourse.Source.Table;
using TPCourse.Source.Table.Column;

namespace TPCourse.Source.Types
{
	public class ColumnData
	{
		public ColumnDescriptor Descriptor { get; set; }
		public List<CellData> Cells { get; set; }

		public ColumnData(ColumnDescriptor descriptor, List<CellData> cells)
		{
			Descriptor = descriptor;
			Cells = cells;
		}
	}
}
