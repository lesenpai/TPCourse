using System;

namespace TPCourse.Table.Column.DataTypes
{
	public interface INotifyChildControlChanged
	{
		event EventHandler ChildControlChanged;

		void OnChildControlChanged(object sender, EventArgs e);
	}
}
