namespace TPCourse.Table
{
	partial class TableForm
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
			this.DGView_Table = new System.Windows.Forms.DataGridView();
			this.Btn_AddColumn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DGView_Table)).BeginInit();
			this.SuspendLayout();
			// 
			// DGView_Table
			// 
			this.DGView_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DGView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGView_Table.Location = new System.Drawing.Point(2, 36);
			this.DGView_Table.Margin = new System.Windows.Forms.Padding(0);
			this.DGView_Table.Name = "DGView_Table";
			this.DGView_Table.Size = new System.Drawing.Size(407, 255);
			this.DGView_Table.TabIndex = 0;
			this.DGView_Table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView_Table_CellEndEdit);
			this.DGView_Table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView_Table_CellValueChanged);
			// 
			// Btn_AddColumn
			// 
			this.Btn_AddColumn.Location = new System.Drawing.Point(2, 5);
			this.Btn_AddColumn.Name = "Btn_AddColumn";
			this.Btn_AddColumn.Size = new System.Drawing.Size(129, 28);
			this.Btn_AddColumn.TabIndex = 1;
			this.Btn_AddColumn.Text = "Добавить столбец";
			this.Btn_AddColumn.UseVisualStyleBackColor = true;
			this.Btn_AddColumn.Click += new System.EventHandler(this.Btn_AddColumn_Click);
			// 
			// TableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 293);
			this.Controls.Add(this.Btn_AddColumn);
			this.Controls.Add(this.DGView_Table);
			this.Name = "TableForm";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.Text = "TableForm";
			((System.ComponentModel.ISupportInitialize)(this.DGView_Table)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView DGView_Table;
		public System.Windows.Forms.Button Btn_AddColumn;
	}
}