using System;

namespace TPCourse.Table.Column
{
	public interface INotifyChildControlChanged
	{
		event EventHandler ChildControlChanged;

		void OnChildControlChanged(object sender, EventArgs e);
	}
}
