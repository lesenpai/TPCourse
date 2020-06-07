using System.Globalization;
using TPCourse.Table.Column.DataTypes;
using TPCourse.Table.Column.DataTypes.Format;

namespace TPCourse.Table.Column
{
	/*
		Свойства колонки.
		*/
	public class TableColumnDescriptor
	{
		public string Name;
		public DataType DataType;
		//public string FormatString;
		public DataTypeFormat DataTypeFormat;
		//public CultureInfo Culture;// TOREMOVE

		public int Index;

		public TableColumnDescriptor()
		{
			Name = "";
			DataType = DataType.Default;
			FormatString = "";
			//Culture = CultureInfo.InvariantCulture;
			DataTypeFormat = new DefaultFormat();
			Index = -1;
		}

		public TableColumnDescriptor(string name, DataType dataType, string formatString, DataTypeFormat dataTypeFormat, int index)
		{
			Name = name;
			DataType = dataType;
			FormatString = format;
			Culture = culture;
			Index = index;
		}
	}
}
