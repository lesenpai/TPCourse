using System.Windows.Forms;

namespace TPCourse.Source.Table.Column.DataTypes.Number
{
	partial class NumberFormatUserControl : UserControl
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
			this.Lbl_Precision = new System.Windows.Forms.Label();
			this.RBtn_DigitGroupSeparator = new System.Windows.Forms.CheckBox();
			this.NUD_Precision = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.NUD_Precision)).BeginInit();
			this.SuspendLayout();
			// 
			// Lbl_Precision
			// 
			this.Lbl_Precision.AutoSize = true;
			this.Lbl_Precision.Location = new System.Drawing.Point(3, 9);
			this.Lbl_Precision.Name = "Lbl_Precision";
			this.Lbl_Precision.Size = new System.Drawing.Size(172, 13);
			this.Lbl_Precision.TabIndex = 1;
			this.Lbl_Precision.Text = "Количество цифр после запятой";
			// 
			// RBtn_DigitGroupSeparator
			// 
			this.RBtn_DigitGroupSeparator.AutoSize = true;
			this.RBtn_DigitGroupSeparator.Checked = true;
			this.RBtn_DigitGroupSeparator.CheckState = System.Windows.Forms.CheckState.Checked;
			this.RBtn_DigitGroupSeparator.Location = new System.Drawing.Point(6, 33);
			this.RBtn_DigitGroupSeparator.Name = "RBtn_DigitGroupSeparator";
			this.RBtn_DigitGroupSeparator.Size = new System.Drawing.Size(174, 17);
			this.RBtn_DigitGroupSeparator.TabIndex = 2;
			this.RBtn_DigitGroupSeparator.Text = "Разделитель групп разрядов";
			this.RBtn_DigitGroupSeparator.UseVisualStyleBackColor = true;
			// 
			// NUD_Precision
			// 
			this.NUD_Precision.Location = new System.Drawing.Point(181, 7);
			this.NUD_Precision.Name = "NUD_Precision";
			this.NUD_Precision.Size = new System.Drawing.Size(54, 20);
			this.NUD_Precision.TabIndex = 3;
			// 
			// NumberFormatUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.NUD_Precision);
			this.Controls.Add(this.RBtn_DigitGroupSeparator);
			this.Controls.Add(this.Lbl_Precision);
			this.Name = "NumberFormatUserControl";
			this.Size = new System.Drawing.Size(267, 73);
			((System.ComponentModel.ISupportInitialize)(this.NUD_Precision)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label Lbl_Precision;
		public CheckBox RBtn_DigitGroupSeparator;
		public NumericUpDown NUD_Precision;
	}
}
