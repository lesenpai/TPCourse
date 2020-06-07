using System.Windows.Forms;

namespace TPCourse.Table.Column.DataTypes.DataTypeFormatUserControls
{
	partial class DateFormatUserControl : UserControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.Lbl_Separator = new System.Windows.Forms.Label();
			this.Lbl_Day = new System.Windows.Forms.Label();
			this.Lbl_Month = new System.Windows.Forms.Label();
			this.Lbl_Year = new System.Windows.Forms.Label();
			this.CmBox_Day = new System.Windows.Forms.ComboBox();
			this.CmBox_Month = new System.Windows.Forms.ComboBox();
			this.CmBox_Year = new System.Windows.Forms.ComboBox();
			this.CmBox_Separator = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// Lbl_Separator
			// 
			this.Lbl_Separator.AutoSize = true;
			this.Lbl_Separator.Location = new System.Drawing.Point(3, 90);
			this.Lbl_Separator.Name = "Lbl_Separator";
			this.Lbl_Separator.Size = new System.Drawing.Size(73, 13);
			this.Lbl_Separator.TabIndex = 0;
			this.Lbl_Separator.Text = "Разделитель";
			// 
			// Lbl_Day
			// 
			this.Lbl_Day.AutoSize = true;
			this.Lbl_Day.Location = new System.Drawing.Point(3, 6);
			this.Lbl_Day.Name = "Lbl_Day";
			this.Lbl_Day.Size = new System.Drawing.Size(34, 13);
			this.Lbl_Day.TabIndex = 1;
			this.Lbl_Day.Text = "День";
			// 
			// Lbl_Month
			// 
			this.Lbl_Month.AutoSize = true;
			this.Lbl_Month.Location = new System.Drawing.Point(3, 33);
			this.Lbl_Month.Name = "Lbl_Month";
			this.Lbl_Month.Size = new System.Drawing.Size(40, 13);
			this.Lbl_Month.TabIndex = 2;
			this.Lbl_Month.Text = "Месяц";
			// 
			// Lbl_Year
			// 
			this.Lbl_Year.AutoSize = true;
			this.Lbl_Year.Location = new System.Drawing.Point(3, 63);
			this.Lbl_Year.Name = "Lbl_Year";
			this.Lbl_Year.Size = new System.Drawing.Size(25, 13);
			this.Lbl_Year.TabIndex = 3;
			this.Lbl_Year.Text = "Год";
			// 
			// CmBox_Day
			// 
			this.CmBox_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmBox_Day.FormattingEnabled = true;
			this.CmBox_Day.Location = new System.Drawing.Point(82, 3);
			this.CmBox_Day.Name = "CmBox_Day";
			this.CmBox_Day.Size = new System.Drawing.Size(121, 21);
			this.CmBox_Day.TabIndex = 4;
			// 
			// CmBox_Month
			// 
			this.CmBox_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmBox_Month.FormattingEnabled = true;
			this.CmBox_Month.Location = new System.Drawing.Point(82, 30);
			this.CmBox_Month.Name = "CmBox_Month";
			this.CmBox_Month.Size = new System.Drawing.Size(121, 21);
			this.CmBox_Month.TabIndex = 5;
			// 
			// CmBox_Year
			// 
			this.CmBox_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmBox_Year.FormattingEnabled = true;
			this.CmBox_Year.Location = new System.Drawing.Point(82, 60);
			this.CmBox_Year.Name = "CmBox_Year";
			this.CmBox_Year.Size = new System.Drawing.Size(121, 21);
			this.CmBox_Year.TabIndex = 6;
			// 
			// CmBox_Separator
			// 
			this.CmBox_Separator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmBox_Separator.FormattingEnabled = true;
			this.CmBox_Separator.Location = new System.Drawing.Point(82, 87);
			this.CmBox_Separator.Name = "CmBox_Separator";
			this.CmBox_Separator.Size = new System.Drawing.Size(121, 21);
			this.CmBox_Separator.TabIndex = 7;
			// 
			// DateFormatUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CmBox_Separator);
			this.Controls.Add(this.CmBox_Year);
			this.Controls.Add(this.CmBox_Month);
			this.Controls.Add(this.CmBox_Day);
			this.Controls.Add(this.Lbl_Year);
			this.Controls.Add(this.Lbl_Month);
			this.Controls.Add(this.Lbl_Day);
			this.Controls.Add(this.Lbl_Separator);
			this.Name = "DateFormatUserControl";
			this.Size = new System.Drawing.Size(221, 122);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label Lbl_Separator;
		private Label Lbl_Day;
		private Label Lbl_Month;
		private Label Lbl_Year;
		public ComboBox CmBox_Day;
		public ComboBox CmBox_Month;
		public ComboBox CmBox_Year;
		public ComboBox CmBox_Separator;
	}
}
