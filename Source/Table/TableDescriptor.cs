namespace TPCourse.Source.Table
{
	/*
		Свойства таблицы.
		*/
	public class TableDescriptor
	{
		public string Name { get; set; }

		public TableDescriptor()
		{
			Name = "";
		}

		public TableDescriptor(string name)
		{
			Name = name;
		}
	}
}
