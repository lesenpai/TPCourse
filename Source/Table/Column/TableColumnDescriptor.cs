using System;
using System.Globalization;
using TPCourse.Source.Table.Column.DataTypes.Base;
using TPCourse.Source.Table.Column.DataTypes.Default;
using TPCourse.Table.Column.DataTypes;

namespace TPCourse.Source.Table.Column
{
	/*
		Свойства колонки.
		*/
	[Serializable]
	public class ColumnDescriptor
	{
		public string Name { get; set; }
		public DataType DataType { get; set; }
		public DataTypeFormat Format { get; set; }

		public ColumnDescriptor()
		{
			Name = "";
			DataType = DataType.Default;
			Format = new DefaultFormat();
		}

		public ColumnDescriptor(string name, DataType dataType, DataTypeFormat dataTypeFormat, int index)
		{
			Name = name;
			DataType = dataType;
			Format = dataTypeFormat;
		}
	}
}
