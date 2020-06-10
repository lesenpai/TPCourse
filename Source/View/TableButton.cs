using System;
using System.Windows.Forms;

namespace TPCourse.Source.Types
{
	public class TableButton : Button
	{
		public TableButton() 
		{
			AutoSize = true;
			Height = 30;
		}

		public void Init(string tableName, MouseEventHandler clickHandler, EventHandler mouseHoverHandler)
		{
			Text = tableName; // unique
			MouseUp += clickHandler;
			MouseHover += mouseHoverHandler;
		}
	}
}
