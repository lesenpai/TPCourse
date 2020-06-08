using System;
using System.Windows.Forms;

namespace TPCourse.Source.Types
{

	//TODO: "..." если имя не влезает, всплывающий текст с полным именем
	public class TableButton : Button
	{
		public TableButton() 
		{ 
		}

		public void Init(string tableName, EventHandler clickHandler)
		{
			Text = tableName; // unique
			Click += clickHandler;
		}
	}
}
