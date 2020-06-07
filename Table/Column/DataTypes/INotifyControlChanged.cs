using System;

namespace TPCourse.Table.Column.DataTypes
{
	public interface INotifyAnyControlChanged
	{
		event EventHandler AnyControlChanged;

		void OnAnyControlChanged(object sender, EventArgs e);
	}
}
