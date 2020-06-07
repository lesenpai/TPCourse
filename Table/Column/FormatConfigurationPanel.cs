using System;
using System.Windows.Forms;
using TPCourse.Table.Column.DataTypes;

namespace TPCourse.Table.Column
{
	class FormatConfigurationPanel : Panel, INotifyChildControlChanged
	{
		/* INotifyChildControlChanged */
		public event EventHandler ChildControlChanged;
		private INotifyAnyControlChanged _control;
		public INotifyAnyControlChanged Control
		{
			get => _control;
			set
			{
				if (Controls.Count != 0)
				{
					Controls.RemoveAt(0);
				}

				Controls.Add((UserControl)value);
				_control = value;
			}
		}

		public void OnChildControlChanged(object sender, EventArgs e) => ChildControlChanged.Invoke(null, null);
		/* INotifyChildControlChanged ; */

		public FormatConfigurationPanel(INotifyAnyControlChanged control, EventHandler handler)
		{
			ChildControlChanged += handler;
			Control = control;

			Controls.Add(new Control());
		}
	}
}
