namespace TPCourse.Table.Column
{
	partial class AddTableColumnDialog
	{
		private TPCourse.Table.Column.FormatConfigurationPanel FC_Pnl_DataTypeFormatConfiguration;
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
			this.Lbl_Sample = new System.Windows.Forms.Label();
			this.Lbl_SampleValue = new System.Windows.Forms.Label();
			this.FC_Pnl_DataTypeFormatConfiguration = new TPCourse.Table.Column.FormatConfigurationPanel();
			this.SuspendLayout();
			// 
			// Btn_OK
			// 
			this.Btn_OK.Location = new System.Drawing.Point(15, 297);
			this.Btn_OK.Name = "Btn_OK";
			this.Btn_OK.Size = new System.Drawing.Size(75, 23);
			this.Btn_OK.TabIndex = 0;
			this.Btn_OK.Text = "OK";
			this.Btn_OK.UseVisualStyleBackColor = true;
			this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Location = new System.Drawing.Point(108, 297);
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
			this.TBox_ColumnName.Size = new System.Drawing.Size(180, 20);
			this.TBox_ColumnName.TabIndex = 2;
			this.TBox_ColumnName.Text = "Столбец";
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
			this.CmBox_ColumnDataType.Location = new System.Drawing.Point(119, 43);
			this.CmBox_ColumnDataType.Name = "CmBox_ColumnDataType";
			this.CmBox_ColumnDataType.Size = new System.Drawing.Size(135, 21);
			this.CmBox_ColumnDataType.TabIndex = 6;
			this.CmBox_ColumnDataType.SelectedIndexChanged += new System.EventHandler(this.CmBox_ColumnDataType_SelectedIndexChanged);
			// 
			// Lbl_Sample
			// 
			this.Lbl_Sample.AutoSize = true;
			this.Lbl_Sample.Location = new System.Drawing.Point(12, 80);
			this.Lbl_Sample.Name = "Lbl_Sample";
			this.Lbl_Sample.Size = new System.Drawing.Size(54, 13);
			this.Lbl_Sample.TabIndex = 10;
			this.Lbl_Sample.Text = "Образец:";
			// 
			// Lbl_SampleValue
			// 
			this.Lbl_SampleValue.AutoSize = true;
			this.Lbl_SampleValue.Location = new System.Drawing.Point(116, 80);
			this.Lbl_SampleValue.Name = "Lbl_SampleValue";
			this.Lbl_SampleValue.Size = new System.Drawing.Size(28, 13);
			this.Lbl_SampleValue.TabIndex = 11;
			this.Lbl_SampleValue.Text = "( ... )";
			// 
			// FC_Pnl_DataTypeFormatConfiguration
			// 
			this.FC_Pnl_DataTypeFormatConfiguration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FC_Pnl_DataTypeFormatConfiguration.Control = null;
			this.FC_Pnl_DataTypeFormatConfiguration.Location = new System.Drawing.Point(15, 106);
			this.FC_Pnl_DataTypeFormatConfiguration.Name = "FC_Pnl_DataTypeFormatConfiguration";
			this.FC_Pnl_DataTypeFormatConfiguration.Size = new System.Drawing.Size(365, 167);
			this.FC_Pnl_DataTypeFormatConfiguration.TabIndex = 12;
			// 
			// AddTableColumnDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 335);
			this.Controls.Add(this.Lbl_SampleValue);
			this.Controls.Add(this.Lbl_Sample);
			this.Controls.Add(this.CmBox_ColumnDataType);
			this.Controls.Add(this.Lbl_ColumnDataType);
			this.Controls.Add(this.Lbl_ColumnName);
			this.Controls.Add(this.TBox_ColumnName);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.Btn_OK);
			this.Controls.Add(this.FC_Pnl_DataTypeFormatConfiguration);
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
		private System.Windows.Forms.Label Lbl_Sample;
		private System.Windows.Forms.Label Lbl_SampleValue;
		//private TPCourse.Table.Column.FormatConfigurationPanel FC_Pnl_DataTypeFormatConfiguration;
		//private System.Windows.Forms.Panel FC_Pnl_DataTypeFormatConfiguration;
	}
}