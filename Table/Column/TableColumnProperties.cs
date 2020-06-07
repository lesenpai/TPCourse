using System.Globalization;
using TPCourse.Table.Column.DataTypes;

namespace TPCourse.Table.Column
{
	/*
		Свойства колонки.
		*/
	public class TableColumnDescriptor
	{
		public string Name;
		public DataType DataType;
		public string Format;
		public CultureInfo Culture;

		public int Index;

		public TableColumnDescriptor()
		{
			Name = "";
			DataType = DataType.Default;
			Format = "";
			Culture = CultureInfo.InvariantCulture;
			Index = -1;
		}

		public TableColumnDescriptor(string name, DataType dataType, string format, CultureInfo culture, int index)
		{
			Name = name;
			DataType = dataType;
			Format = format;
			Culture = culture;
			Index = index;
		}
	}
}
