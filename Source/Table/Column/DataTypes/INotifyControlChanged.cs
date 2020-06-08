using System;

namespace TPCourse.Source.Table.Column.DataTypes
{
	public interface INotifyAnyControlChanged
	{
		event EventHandler AnyControlChanged;

		void OnAnyControlChanged(object sender, EventArgs e);
	}
}
