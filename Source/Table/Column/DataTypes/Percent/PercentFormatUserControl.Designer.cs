using System.Windows.Forms;

namespace TPCourse.Source.Table.Column.DataTypes.Percent
{
	partial class PercentFormatUserControl : UserControl
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
			((System.ComponentModel.ISupportInitialize)(this.NUD_Precision)).BeginInit();
			this.SuspendLayout();
			// 
			// NUD_Precision
			// 
			this.NUD_Precision.Location = new System.Drawing.Point(181, 19);
			this.NUD_Precision.Name = "NUD_Precision";
			this.NUD_Precision.Size = new System.Drawing.Size(54, 20);
			this.NUD_Precision.TabIndex = 5;
			// 
			// Lbl_Precision
			// 
			this.Lbl_Precision.AutoSize = true;
			this.Lbl_Precision.Location = new System.Drawing.Point(3, 21);
			this.Lbl_Precision.Name = "Lbl_Precision";
			this.Lbl_Precision.Size = new System.Drawing.Size(172, 13);
			this.Lbl_Precision.TabIndex = 4;
			this.Lbl_Precision.Text = "Количество цифр после запятой";
			// 
			// PercentFormatUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.NUD_Precision);
			this.Controls.Add(this.Lbl_Precision);
			this.Name = "PercentFormatUserControl";
			this.Size = new System.Drawing.Size(279, 62);
			((System.ComponentModel.ISupportInitialize)(this.NUD_Precision)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public NumericUpDown NUD_Precision;
		private Label Lbl_Precision;
	}
}
