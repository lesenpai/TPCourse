using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCourse.Source.Types;
using TPCourse.Table;

namespace TPCourse.Source.Table
{
	// TODO MAYBE REMOVE 'IResult<TableDescriptor' - лишнее
	public partial class AddTableDialog : Form, IResult<TableDescriptor>
	{
		public Result<TableDescriptor> @Result { get; set; }
		private MainModel _mainModel;
		private MainView _mainView;
		private const string FORM_CAPTURE = "Добавление таблицы";

		public AddTableDialog()
		{
			InitializeComponent();

			@Result = new Result<TableDescriptor>(new TableDescriptor());
		}

		public void Init(MainModel mainModel, MainView mainView)
		{
			_mainModel = mainModel;
			_mainView = mainView;
		}

		public void Init(MainModel mainModel, MainView mainView, string tableName)
		{
			Init(mainModel, mainView);
			TB_TableName.Text = tableName;
		}

		private void Btn_OK_Click(object sender, EventArgs e)
		{
			var validation = ValidateTableName(TB_TableName.Text);

			if (!validation.Success)
			{
				MessageBox.Show(
					validation.Value,
					FORM_CAPTURE,
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);

				return;
			}

			@Result.Value.Name = TB_TableName.Text;
			@Result.Success = true;

			// добавление кнопки таблицы на главное окно
			//_mainView.AddTableButton(@Result.Value.Name);

			Close();
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			@Result.Success = false;

			Close();
		}

		private Result<string> ValidateTableName(string name)
		{
			if(string.IsNullOrEmpty(name))
			{
				return Result<string>.False("Имя таблицы не может быть пустым");
			}

			if(_mainModel.TableDatas.Any(x => x.Descriptor.Name == name))
			{
				return Result<string>.False("Таблица с таким именем уже существует");
			}

			return Result<string>.True();
		}
	}
}
