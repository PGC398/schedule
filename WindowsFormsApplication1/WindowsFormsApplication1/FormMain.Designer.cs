namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.是ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.cboIsFinished = new System.Windows.Forms.RadioButton();
            this.rbNoneFinished = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvitems = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitems)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.是ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 是ToolStripMenuItem
            // 
            this.是ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建项目ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.是ToolStripMenuItem.Name = "是ToolStripMenuItem";
            resources.ApplyResources(this.是ToolStripMenuItem, "是ToolStripMenuItem");
            // 
            // 新建项目ToolStripMenuItem
            // 
            this.新建项目ToolStripMenuItem.Name = "新建项目ToolStripMenuItem";
            resources.ApplyResources(this.新建项目ToolStripMenuItem, "新建项目ToolStripMenuItem");
            this.新建项目ToolStripMenuItem.Click += new System.EventHandler(this.新建项目ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.Name = "txtTitle";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            resources.ApplyResources(this.cboType, "cboType");
            this.cboType.Name = "cboType";
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbAll
            // 
            resources.ApplyResources(this.rbAll, "rbAll");
            this.rbAll.Checked = true;
            this.rbAll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rbAll.Name = "rbAll";
            this.rbAll.TabStop = true;
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // cboIsFinished
            // 
            resources.ApplyResources(this.cboIsFinished, "cboIsFinished");
            this.cboIsFinished.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboIsFinished.Name = "cboIsFinished";
            this.cboIsFinished.UseVisualStyleBackColor = true;
            // 
            // rbNoneFinished
            // 
            resources.ApplyResources(this.rbNoneFinished, "rbNoneFinished");
            this.rbNoneFinished.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rbNoneFinished.Name = "rbNoneFinished";
            this.rbNoneFinished.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvitems
            // 
            this.dgvitems.AllowUserToAddRows = false;
            this.dgvitems.AllowUserToDeleteRows = false;
            this.dgvitems.AllowUserToResizeColumns = false;
            this.dgvitems.AllowUserToResizeRows = false;
            this.dgvitems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitems.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.dgvitems, "dgvitems");
            this.dgvitems.MultiSelect = false;
            this.dgvitems.Name = "dgvitems";
            this.dgvitems.RowTemplate.Height = 27;
            this.dgvitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            resources.ApplyResources(this.修改ToolStripMenuItem, "修改ToolStripMenuItem");
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            resources.ApplyResources(this.删除ToolStripMenuItem, "删除ToolStripMenuItem");
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dgvitems);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbNoneFinished);
            this.Controls.Add(this.cboIsFinished);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitems)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 是ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton cboIsFinished;
        private System.Windows.Forms.RadioButton rbNoneFinished;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvitems;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

