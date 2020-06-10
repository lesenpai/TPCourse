namespace TPCourse.Source.Table
{
	partial class AddTableDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Lbl_TableName = new System.Windows.Forms.Label();
			this.TB_TableName = new System.Windows.Forms.TextBox();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.Btn_OK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Lbl_TableName
			// 
			this.Lbl_TableName.AutoSize = true;
			this.Lbl_TableName.Location = new System.Drawing.Point(12, 23);
			this.Lbl_TableName.Name = "Lbl_TableName";
			this.Lbl_TableName.Size = new System.Drawing.Size(103, 13);
			this.Lbl_TableName.TabIndex = 14;
			this.Lbl_TableName.Text = "Название таблицы";
			// 
			// TB_TableName
			// 
			this.TB_TableName.Location = new System.Drawing.Point(119, 20);
			this.TB_TableName.Name = "TB_TableName";
			this.TB_TableName.Size = new System.Drawing.Size(180, 20);
			this.TB_TableName.TabIndex = 13;
			this.TB_TableName.Text = "Таблица";
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Location = new System.Drawing.Point(106, 83);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.Btn_Cancel.TabIndex = 14;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// Btn_OK
			// 
			this.Btn_OK.Location = new System.Drawing.Point(15, 83);
			this.Btn_OK.Name = "Btn_OK";
			this.Btn_OK.Size = new System.Drawing.Size(75, 23);
			this.Btn_OK.TabIndex = 13;
			this.Btn_OK.Text = "OK";
			this.Btn_OK.UseVisualStyleBackColor = true;
			this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
			// 
			// AddTableDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 123);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.Btn_OK);
			this.Controls.Add(this.Lbl_TableName);
			this.Controls.Add(this.TB_TableName);
			this.Name = "AddTableDialog";
			this.Text = "AddTableDialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Lbl_TableName;
		private System.Windows.Forms.TextBox TB_TableName;
		private System.Windows.Forms.Button Btn_Cancel;
		private System.Windows.Forms.Button Btn_OK;
	}
}