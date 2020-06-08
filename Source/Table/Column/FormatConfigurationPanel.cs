using System;
using System.Windows.Forms;
using TPCourse.Source.Table.Column.DataTypes;
using TPCourse.Table.Column.DataTypes;

namespace TPCourse.Source.Table.Column
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

		/*
			Инициализатор.
			Необходим т.к. для конструктора Visual Studio требуются пустые конструкторы элементов.
			*/
		public void Init(INotifyAnyControlChanged control, EventHandler eventHandler)
		{
			ChildControlChanged += eventHandler;
			Control = control;
		}

		// Требуется для корректоной работы файла-конструктора.
		public FormatConfigurationPanel()
		{
		}
	}
}
