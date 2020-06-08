using System.Globalization;
using TPCourse.Source.Table.Column.DataTypes.Base;
using TPCourse.Source.Table.Column.DataTypes.Default;
using TPCourse.Table.Column.DataTypes;

namespace TPCourse.Source.Table.Column
{
	/*
		Свойства колонки.
		*/
	public class ColumnDescriptor
	{
		public string Name;
		public DataType DataType;
		public DataTypeFormat Format;

		public int Index { get; set; }

		public ColumnDescriptor()
		{
			Name = "";
			DataType = DataType.Default;
			Format = new DefaultFormat();
			Index = -1;
		}

		public ColumnDescriptor(string name, DataType dataType, DataTypeFormat dataTypeFormat, int index)
		{
			Name = name;
			DataType = dataType;
			Format = dataTypeFormat;
			Index = index;
		}
	}
}
