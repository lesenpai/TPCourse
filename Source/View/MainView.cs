using TPCourse.Source.Types;

namespace TPCourse.Source
{
	public class MainView
	{
		public MainForm Form;

		public MainView(MainForm form)
		{
			Form = form;
		}

		public void AddTableButton(string name)
		{
			var button = new TableButton();
			button.Init(name, Form.TableBtn_X_MouseUp, Form.TableBtn_X_MouseHover);
				
			Form.FLPanel_Tables.Controls.Add(button);
			Form.FLPanel_Tables.SetFlowBreak(button, true);
		}
	}
}
