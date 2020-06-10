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
			this.components = new System.ComponentModel.Container();
			this.MS_Menu = new System.Windows.Forms.MenuStrip();
			this.TSMI_Menu__FIle = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu__AddTable = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu__View = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu__View__TableFormsLayout = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu__View__TableFormsLayout__Cascade = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu__View__TableFormsLayout__Horizonal = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_Menu__View__TableFormsLayout__Vertical = new System.Windows.Forms.ToolStripMenuItem();
			this.FLPanel_Tables = new System.Windows.Forms.FlowLayoutPanel();
			this.CtxMS_TableBtnX = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TSMI_TableBtnX__Rename = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_TableBtnX__Delete = new System.Windows.Forms.ToolStripMenuItem();
			this.SFDialog = new System.Windows.Forms.SaveFileDialog();
			this.OFDialog = new System.Windows.Forms.OpenFileDialog();
			this.ToolTip_TableBtnX = new System.Windows.Forms.ToolTip(this.components);
			this.MS_Menu.SuspendLayout();
			this.CtxMS_TableBtnX.SuspendLayout();
			this.SuspendLayout();
			// 
			// MS_Menu
			// 
			this.MS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Menu__FIle,
            this.TSMI_Menu__AddTable,
            this.TSMI_Menu__View});
			this.MS_Menu.Location = new System.Drawing.Point(0, 0);
			this.MS_Menu.Name = "MS_Menu";
			this.MS_Menu.Size = new System.Drawing.Size(656, 24);
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
			this.TSMI_Menu_File_Open.Click += new System.EventHandler(this.TSMI_Menu_File_Open_Click);
			// 
			// TSMI_Menu_File_Save
			// 
			this.TSMI_Menu_File_Save.Name = "TSMI_Menu_File_Save";
			this.TSMI_Menu_File_Save.Size = new System.Drawing.Size(155, 22);
			this.TSMI_Menu_File_Save.Text = "Сохранить";
			this.TSMI_Menu_File_Save.Click += new System.EventHandler(this.TSMI_Menu_File_Save_Click);
			// 
			// TSMI_Menu_File_SaveAs
			// 
			this.TSMI_Menu_File_SaveAs.Name = "TSMI_Menu_File_SaveAs";
			this.TSMI_Menu_File_SaveAs.Size = new System.Drawing.Size(155, 22);
			this.TSMI_Menu_File_SaveAs.Text = "Сохнанить Как";
			this.TSMI_Menu_File_SaveAs.Click += new System.EventHandler(this.TSMI_Menu_File_SaveAs_Click);
			// 
			// TSMI_Menu__AddTable
			// 
			this.TSMI_Menu__AddTable.Name = "TSMI_Menu__AddTable";
			this.TSMI_Menu__AddTable.Size = new System.Drawing.Size(119, 20);
			this.TSMI_Menu__AddTable.Text = "Добавить таблицу";
			this.TSMI_Menu__AddTable.Click += new System.EventHandler(this.TSMI_Menu__AddTable_Click);
			// 
			// TSMI_Menu__View
			// 
			this.TSMI_Menu__View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Menu__View__TableFormsLayout});
			this.TSMI_Menu__View.Name = "TSMI_Menu__View";
			this.TSMI_Menu__View.Size = new System.Drawing.Size(39, 20);
			this.TSMI_Menu__View.Text = "Вид";
			// 
			// TSMI_Menu__View__TableFormsLayout
			// 
			this.TSMI_Menu__View__TableFormsLayout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Menu__View__TableFormsLayout__Cascade,
            this.TSMI_Menu__View__TableFormsLayout__Horizonal,
            this.TSMI_Menu__View__TableFormsLayout__Vertical});
			this.TSMI_Menu__View__TableFormsLayout.Name = "TSMI_Menu__View__TableFormsLayout";
			this.TSMI_Menu__View__TableFormsLayout.Size = new System.Drawing.Size(215, 22);
			this.TSMI_Menu__View__TableFormsLayout.Text = "Компоновка окон таблиц";
			// 
			// TSMI_Menu__View__TableFormsLayout__Cascade
			// 
			this.TSMI_Menu__View__TableFormsLayout__Cascade.Name = "TSMI_Menu__View__TableFormsLayout__Cascade";
			this.TSMI_Menu__View__TableFormsLayout__Cascade.Size = new System.Drawing.Size(158, 22);
			this.TSMI_Menu__View__TableFormsLayout__Cascade.Text = "Каскад";
			this.TSMI_Menu__View__TableFormsLayout__Cascade.Click += new System.EventHandler(this.TSMI_Menu__View__TableFormsLayout__Cascade_Click);
			// 
			// TSMI_Menu__View__TableFormsLayout__Horizonal
			// 
			this.TSMI_Menu__View__TableFormsLayout__Horizonal.Name = "TSMI_Menu__View__TableFormsLayout__Horizonal";
			this.TSMI_Menu__View__TableFormsLayout__Horizonal.Size = new System.Drawing.Size(158, 22);
			this.TSMI_Menu__View__TableFormsLayout__Horizonal.Text = "Горизонтально";
			this.TSMI_Menu__View__TableFormsLayout__Horizonal.Click += new System.EventHandler(this.TSMI_Menu__View__TableFormsLayout__Horizonal_Click);
			// 
			// TSMI_Menu__View__TableFormsLayout__Vertical
			// 
			this.TSMI_Menu__View__TableFormsLayout__Vertical.Name = "TSMI_Menu__View__TableFormsLayout__Vertical";
			this.TSMI_Menu__View__TableFormsLayout__Vertical.Size = new System.Drawing.Size(158, 22);
			this.TSMI_Menu__View__TableFormsLayout__Vertical.Text = "Вертикально";
			this.TSMI_Menu__View__TableFormsLayout__Vertical.Click += new System.EventHandler(this.TSMI_Menu__View__TableFormsLayout__Vertical_Click);
			// 
			// FLPanel_Tables
			// 
			this.FLPanel_Tables.AutoScroll = true;
			this.FLPanel_Tables.Dock = System.Windows.Forms.DockStyle.Left;
			this.FLPanel_Tables.Location = new System.Drawing.Point(0, 24);
			this.FLPanel_Tables.Name = "FLPanel_Tables";
			this.FLPanel_Tables.Size = new System.Drawing.Size(138, 354);
			this.FLPanel_Tables.TabIndex = 6;
			// 
			// CtxMS_TableBtnX
			// 
			this.CtxMS_TableBtnX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_TableBtnX__Rename,
            this.TSMI_TableBtnX__Delete});
			this.CtxMS_TableBtnX.Name = "CtxMS_TableButtonX";
			this.CtxMS_TableBtnX.Size = new System.Drawing.Size(162, 48);
			// 
			// TSMI_TableBtnX__Rename
			// 
			this.TSMI_TableBtnX__Rename.Name = "TSMI_TableBtnX__Rename";
			this.TSMI_TableBtnX__Rename.Size = new System.Drawing.Size(161, 22);
			this.TSMI_TableBtnX__Rename.Text = "Переименовать";
			this.TSMI_TableBtnX__Rename.Click += new System.EventHandler(this.TSMI_TableBtnX__Rename_Click);
			// 
			// TSMI_TableBtnX__Delete
			// 
			this.TSMI_TableBtnX__Delete.Name = "TSMI_TableBtnX__Delete";
			this.TSMI_TableBtnX__Delete.Size = new System.Drawing.Size(161, 22);
			this.TSMI_TableBtnX__Delete.Text = "Удалить";
			this.TSMI_TableBtnX__Delete.Click += new System.EventHandler(this.TSMI_TableBtnX__Delete_Click);
			// 
			// SFDialog
			// 
			this.SFDialog.DefaultExt = "tpcourse";
			this.SFDialog.Filter = "TPCOURSE (*.tpcourse)|*tpcourse";
			// 
			// OFDialog
			// 
			this.OFDialog.DefaultExt = "tpcourse";
			this.OFDialog.Filter = "TPCOURSE (*.tpcourse)|*tpcourse";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 378);
			this.Controls.Add(this.FLPanel_Tables);
			this.Controls.Add(this.MS_Menu);
			this.DoubleBuffered = true;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.MS_Menu;
			this.Name = "MainForm";
			this.Text = "Main Window";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.MS_Menu.ResumeLayout(false);
			this.MS_Menu.PerformLayout();
			this.CtxMS_TableBtnX.ResumeLayout(false);
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
		public System.Windows.Forms.FlowLayoutPanel FLPanel_Tables;
		private System.Windows.Forms.ContextMenuStrip CtxMS_TableBtnX;
		private System.Windows.Forms.ToolStripMenuItem TSMI_TableBtnX__Rename;
		private System.Windows.Forms.ToolStripMenuItem TSMI_TableBtnX__Delete;
		private System.Windows.Forms.SaveFileDialog SFDialog;
		private System.Windows.Forms.OpenFileDialog OFDialog;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Menu__View;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Menu__View__TableFormsLayout;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Menu__View__TableFormsLayout__Cascade;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Menu__View__TableFormsLayout__Horizonal;
		private System.Windows.Forms.ToolStripMenuItem TSMI_Menu__View__TableFormsLayout__Vertical;
		private System.Windows.Forms.ToolTip ToolTip_TableBtnX;
	}
}

