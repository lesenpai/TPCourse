namespace TPCourse.Table.Column
{
	partial class AddTableColumnDialog
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
			this.Btn_OK = new System.Windows.Forms.Button();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.TBox_ColumnName = new System.Windows.Forms.TextBox();
			this.Lbl_ColumnName = new System.Windows.Forms.Label();
			this.Lbl_ColumnDataType = new System.Windows.Forms.Label();
			this.CmBox_ColumnDataType = new System.Windows.Forms.ComboBox();
			this.TabCtrl_DataTypeConfiguration = new System.Windows.Forms.TabControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// Btn_OK
			// 
			this.Btn_OK.Location = new System.Drawing.Point(12, 439);
			this.Btn_OK.Name = "Btn_OK";
			this.Btn_OK.Size = new System.Drawing.Size(75, 23);
			this.Btn_OK.TabIndex = 0;
			this.Btn_OK.Text = "OK";
			this.Btn_OK.UseVisualStyleBackColor = true;
			this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Location = new System.Drawing.Point(93, 439);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.Btn_Cancel.TabIndex = 1;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// TBox_ColumnName
			// 
			this.TBox_ColumnName.Location = new System.Drawing.Point(119, 17);
			this.TBox_ColumnName.Name = "TBox_ColumnName";
			this.TBox_ColumnName.Size = new System.Drawing.Size(100, 20);
			this.TBox_ColumnName.TabIndex = 2;
			// 
			// Lbl_ColumnName
			// 
			this.Lbl_ColumnName.AutoSize = true;
			this.Lbl_ColumnName.Location = new System.Drawing.Point(12, 20);
			this.Lbl_ColumnName.Name = "Lbl_ColumnName";
			this.Lbl_ColumnName.Size = new System.Drawing.Size(101, 13);
			this.Lbl_ColumnName.TabIndex = 4;
			this.Lbl_ColumnName.Text = "Название столбца";
			// 
			// Lbl_ColumnDataType
			// 
			this.Lbl_ColumnDataType.AutoSize = true;
			this.Lbl_ColumnDataType.Location = new System.Drawing.Point(12, 46);
			this.Lbl_ColumnDataType.Name = "Lbl_ColumnDataType";
			this.Lbl_ColumnDataType.Size = new System.Drawing.Size(66, 13);
			this.Lbl_ColumnDataType.TabIndex = 5;
			this.Lbl_ColumnDataType.Text = "Тип данных";
			// 
			// CmBox_ColumnDataType
			// 
			this.CmBox_ColumnDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmBox_ColumnDataType.FormattingEnabled = true;
			this.CmBox_ColumnDataType.Location = new System.Drawing.Point(84, 43);
			this.CmBox_ColumnDataType.Name = "CmBox_ColumnDataType";
			this.CmBox_ColumnDataType.Size = new System.Drawing.Size(135, 21);
			this.CmBox_ColumnDataType.TabIndex = 6;
			// 
			// TabCtrl_DataTypeConfiguration
			// 
			this.TabCtrl_DataTypeConfiguration.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.TabCtrl_DataTypeConfiguration.Location = new System.Drawing.Point(16, 77);
			this.TabCtrl_DataTypeConfiguration.Multiline = true;
			this.TabCtrl_DataTypeConfiguration.Name = "TabCtrl_DataTypeConfiguration";
			this.TabCtrl_DataTypeConfiguration.SelectedIndex = 0;
			this.TabCtrl_DataTypeConfiguration.Size = new System.Drawing.Size(152, 265);
			this.TabCtrl_DataTypeConfiguration.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.TabCtrl_DataTypeConfiguration.TabIndex = 8;
			this.TabCtrl_DataTypeConfiguration.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabCtrl_DataTypeConfiguration_DrawItem);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(175, 77);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(408, 265);
			this.panel1.TabIndex = 9;
			// 
			// AddTableColumnDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 474);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.TabCtrl_DataTypeConfiguration);
			this.Controls.Add(this.CmBox_ColumnDataType);
			this.Controls.Add(this.Lbl_ColumnDataType);
			this.Controls.Add(this.Lbl_ColumnName);
			this.Controls.Add(this.TBox_ColumnName);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.Btn_OK);
			this.Name = "AddTableColumnDialog";
			this.Text = "AddTableColumnDialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btn_OK;
		private System.Windows.Forms.Button Btn_Cancel;
		private System.Windows.Forms.TextBox TBox_ColumnName;
		private System.Windows.Forms.Label Lbl_ColumnName;
		private System.Windows.Forms.Label Lbl_ColumnDataType;
		private System.Windows.Forms.ComboBox CmBox_ColumnDataType;
		private System.Windows.Forms.TabControl TabCtrl_DataTypeConfiguration;
		private System.Windows.Forms.Panel panel1;
	}
}