using System.Windows.Forms;

namespace TPCourse.Table.Column.DataTypes.DataTypeFormatUserControls
{
	partial class DefaultFormatUserControl : UserControl
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
			this.Lbl_Capture = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Lbl_Capture
			// 
			this.Lbl_Capture.AutoSize = true;
			this.Lbl_Capture.Location = new System.Drawing.Point(4, 4);
			this.Lbl_Capture.Name = "Lbl_Capture";
			this.Lbl_Capture.Size = new System.Drawing.Size(112, 13);
			this.Lbl_Capture.TabIndex = 0;
			this.Lbl_Capture.Text = "Строка без формата";
			// 
			// DefaultFormatUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Lbl_Capture);
			this.Name = "DefaultFormatUserControl";
			this.Size = new System.Drawing.Size(185, 41);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label Lbl_Capture;
	}
}
