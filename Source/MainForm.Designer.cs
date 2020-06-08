namespace TPCourse.Source
{
	partial class MainForm
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.MS_Menu = new System.Windows.Forms.MenuStrip();
			this.TSMI_Menu__FIle = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu__AddTable = new System.Windows.Forms.ToolStripMenuItem();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.FLPanel_Tables = new System.Windows.Forms.FlowLayoutPanel();
			this.MS_Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MS_Menu
			// 
			this.MS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Menu__FIle,
            this.TSMI_Menu__AddTable});
			this.MS_Menu.Location = new System.Drawing.Point(0, 0);
			this.MS_Menu.Name = "MS_Menu";
			this.MS_Menu.Size = new System.Drawing.Size(385, 24);
			this.MS_Menu.TabIndex = 1;
			// 
			// TSMI_Menu__FIle
			// 
			this.TSMI_Menu__FIle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Menu_File_Open,
            this.TSMI_Menu_File_Save,
            this.TSMI_Menu_File_SaveAs});
			this.TSMI_Menu__FIle.Name = "TSMI_Menu__FIle";
			this.TSMI_Menu__FIle.Size = new System.Drawing.Size(48, 20);
			this.TSMI_Menu__FIle.Text = "Файл";
			// 
			// TSMI_Menu_File_Open
			// 
			this.TSMI_Menu_File_Open.Name = "TSMI_Menu_File_Open";
			this.TSMI_Menu_File_Open.Size = new System.Drawing.Size(155, 22);
			this.TSMI_Menu_File_Open.Text = "Открыть";
			// 
			// TSMI_Menu_File_Save
			// 
			this.TSMI_Menu_File_Save.Name = "TSMI_Menu_File_Save";
			this.TSMI_Menu_File_Save.Size = new System.Drawing.Size(155, 22);
			this.TSMI_Menu_File_Save.Text = "Сохранить";
			// 
			// TSMI_Menu_File_SaveAs
			// 
			this.TSMI_Menu_File_SaveAs.Name = "TSMI_Menu_File_SaveAs";
			this.TSMI_Menu_File_SaveAs.Size = new System.Drawing.Size(155, 22);
			this.TSMI_Menu_File_SaveAs.Text = "Сохнанить Как";
			// 
			// TSMI_Menu__AddTable
			// 
			this.TSMI_Menu__AddTable.Name = "TSMI_Menu__AddTable";
			this.TSMI_Menu__AddTable.Size = new System.Drawing.Size(119, 20);
			this.TSMI_Menu__AddTable.Text = "Добавить таблицу";
			this.TSMI_Menu__AddTable.Click += new System.EventHandler(this.TSMI_Menu__AddTable_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 485);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(385, 0);
			this.flowLayoutPanel1.TabIndex = 4;
			this.flowLayoutPanel1.WrapContents = false;
			// 
			// FLPanel_Tables
			// 
			this.FLPanel_Tables.AutoScroll = true;
			this.FLPanel_Tables.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.FLPanel_Tables.Location = new System.Drawing.Point(0, 432);
			this.FLPanel_Tables.Name = "FLPanel_Tables";
			this.FLPanel_Tables.Size = new System.Drawing.Size(385, 53);
			this.FLPanel_Tables.TabIndex = 6;
			this.FLPanel_Tables.WrapContents = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 485);
			this.Controls.Add(this.FLPanel_Tables);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.MS_Menu);
			this.DoubleBuffered = true;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.MS_Menu;
			this.Name = "MainForm";
			this.Text = "Main Window";
			this.MS_Menu.ResumeLayout(false);
			this.MS_Menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MS_Menu;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Menu__AddTable;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Menu__FIle;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Menu_File_Open;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Menu_File_Save;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Menu_File_SaveAs;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		public System.Windows.Forms.FlowLayoutPanel FLPanel_Tables;
	}
}

