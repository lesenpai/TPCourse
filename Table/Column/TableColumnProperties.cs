using TPCourse.Table.Column.DataTypes;

namespace TPCourse.Table.Column
{
	/*
		Свойства колонки.
		*/
	public class TableColumnProperties
	{
		public string Name;
		public DataType DataType;
		public string Format;
		public int Index;

		public TableColumnProperties(string name, DataType dataType, string format, int index)
		{
			Name = name;
			DataType = dataType;
			Format = format;
			Index = index;
		}
	}
}
