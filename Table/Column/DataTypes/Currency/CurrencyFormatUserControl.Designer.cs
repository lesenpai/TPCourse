using System.Windows.Forms;

namespace TPCourse.Table.Column.DataTypes.Currency
{
	partial class CurrencyFormatUserControl : UserControl
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
			this.NUD_Precision = new System.Windows.Forms.NumericUpDown();
			this.Lbl_Precision = new System.Windows.Forms.Label();
			this.Lbl_Currency = new System.Windows.Forms.Label();
			this.CmBox_Currency = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.NUD_Precision)).BeginInit();
			this.SuspendLayout();
			// 
			// NUD_Precision
			// 
			this.NUD_Precision.Location = new System.Drawing.Point(181, 0);
			this.NUD_Precision.Name = "NUD_Precision";
			this.NUD_Precision.Size = new System.Drawing.Size(54, 20);
			this.NUD_Precision.TabIndex = 7;
			// 
			// Lbl_Precision
			// 
			this.Lbl_Precision.AutoSize = true;
			this.Lbl_Precision.Location = new System.Drawing.Point(3, 2);
			this.Lbl_Precision.Name = "Lbl_Precision";
			this.Lbl_Precision.Size = new System.Drawing.Size(172, 13);
			this.Lbl_Precision.TabIndex = 6;
			this.Lbl_Precision.Text = "Количество цифр после запятой";
			// 
			// Lbl_Currency
			// 
			this.Lbl_Currency.AutoSize = true;
			this.Lbl_Currency.Location = new System.Drawing.Point(3, 35);
			this.Lbl_Currency.Name = "Lbl_Currency";
			this.Lbl_Currency.Size = new System.Drawing.Size(45, 13);
			this.Lbl_Currency.TabIndex = 8;
			this.Lbl_Currency.Text = "Валюта";
			// 
			// CmBox_Currency
			// 
			this.CmBox_Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmBox_Currency.FormattingEnabled = true;
			this.CmBox_Currency.Location = new System.Drawing.Point(54, 32);
			this.CmBox_Currency.Name = "CmBox_Currency";
			this.CmBox_Currency.Size = new System.Drawing.Size(121, 21);
			this.CmBox_Currency.TabIndex = 9;
			// 
			// CurrencyFormatUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CmBox_Currency);
			this.Controls.Add(this.Lbl_Currency);
			this.Controls.Add(this.NUD_Precision);
			this.Controls.Add(this.Lbl_Precision);
			this.Name = "CurrencyFormatUserControl";
			this.Size = new System.Drawing.Size(275, 86);
			((System.ComponentModel.ISupportInitialize)(this.NUD_Precision)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public NumericUpDown NUD_Precision;
		private Label Lbl_Precision;
		private Label Lbl_Currency;
		public ComboBox CmBox_Currency;
	}
}
