using System.Windows.Forms;

namespace TPCourse.Source.Table.Column.DataTypes.Duration
{
	partial class DurationFormatUserControl : UserControl
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
			this.CmBox_Precision = new System.Windows.Forms.ComboBox();
			this.CmBox_MillisecondPrecision = new System.Windows.Forms.ComboBox();
			this.Lbl_MillisecondPrecision = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Lbl_Precision
			// 
			this.Lbl_Precision.AutoSize = true;
			this.Lbl_Precision.Location = new System.Drawing.Point(3, 6);
			this.Lbl_Precision.Name = "Lbl_Precision";
			this.Lbl_Precision.Size = new System.Drawing.Size(85, 13);
			this.Lbl_Precision.TabIndex = 0;
			this.Lbl_Precision.Text = "С точностью до";
			// 
			// CmBox_Precision
			// 
			this.CmBox_Precision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmBox_Precision.FormattingEnabled = true;
			this.CmBox_Precision.Location = new System.Drawing.Point(153, 3);
			this.CmBox_Precision.Name = "CmBox_Precision";
			this.CmBox_Precision.Size = new System.Drawing.Size(121, 21);
			this.CmBox_Precision.TabIndex = 1;
			this.CmBox_Precision.SelectedIndexChanged += new System.EventHandler(this.CmBox_Precision_SelectedIndexChanged);
			// 
			// CmBox_MillisecondPrecision
			// 
			this.CmBox_MillisecondPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmBox_MillisecondPrecision.FormattingEnabled = true;
			this.CmBox_MillisecondPrecision.Location = new System.Drawing.Point(153, 34);
			this.CmBox_MillisecondPrecision.Name = "CmBox_MillisecondPrecision";
			this.CmBox_MillisecondPrecision.Size = new System.Drawing.Size(121, 21);
			this.CmBox_MillisecondPrecision.TabIndex = 5;
			// 
			// Lbl_MillisecondPrecision
			// 
			this.Lbl_MillisecondPrecision.AutoSize = true;
			this.Lbl_MillisecondPrecision.Location = new System.Drawing.Point(3, 37);
			this.Lbl_MillisecondPrecision.Name = "Lbl_MillisecondPrecision";
			this.Lbl_MillisecondPrecision.Size = new System.Drawing.Size(144, 13);
			this.Lbl_MillisecondPrecision.TabIndex = 4;
			this.Lbl_MillisecondPrecision.Text = "Точность в миллисекундах";
			// 
			// DurationFormatUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CmBox_MillisecondPrecision);
			this.Controls.Add(this.Lbl_MillisecondPrecision);
			this.Controls.Add(this.CmBox_Precision);
			this.Controls.Add(this.Lbl_Precision);
			this.Name = "DurationFormatUserControl";
			this.Size = new System.Drawing.Size(296, 76);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label Lbl_Precision;
		public ComboBox CmBox_Precision;
		public ComboBox CmBox_MillisecondPrecision;
		private Label Lbl_MillisecondPrecision;
	}
}
