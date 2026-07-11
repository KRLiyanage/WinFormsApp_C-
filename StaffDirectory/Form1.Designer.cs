namespace StaffDirectory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            clearAllToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            viweToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnToolbarAdd = new ToolStripButton();
            btnToolbarRemove = new ToolStripButton();
            btnToolbarSave = new ToolStripButton();
            btnToolbarSearch = new ToolStripButton();
            lblStatus = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1 = new Panel();
            txtSearch = new Button();
            btnSearch = new TextBox();
            lstStaff = new ListBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            lblStatus.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viweToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Opne";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(224, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearAllToolStripMenuItem, customizeToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // clearAllToolStripMenuItem
            // 
            clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            clearAllToolStripMenuItem.Size = new Size(161, 26);
            clearAllToolStripMenuItem.Text = "Clear All";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(161, 26);
            customizeToolStripMenuItem.Text = "Customize";
            // 
            // viweToolStripMenuItem
            // 
            viweToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statusBarToolStripMenuItem });
            viweToolStripMenuItem.Name = "viweToolStripMenuItem";
            viweToolStripMenuItem.Size = new Size(55, 24);
            viweToolStripMenuItem.Text = "View";
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckOnClick = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(158, 26);
            statusBarToolStripMenuItem.Text = "Status Bar";
            statusBarToolStripMenuItem.Click += statusBarToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnToolbarAdd, btnToolbarRemove, btnToolbarSave, btnToolbarSearch });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(984, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnToolbarAdd
            // 
            btnToolbarAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolbarAdd.Image = (Image)resources.GetObject("btnToolbarAdd.Image");
            btnToolbarAdd.ImageTransparentColor = Color.Magenta;
            btnToolbarAdd.Name = "btnToolbarAdd";
            btnToolbarAdd.Size = new Size(41, 24);
            btnToolbarAdd.Text = "Add";
            // 
            // btnToolbarRemove
            // 
            btnToolbarRemove.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolbarRemove.Image = (Image)resources.GetObject("btnToolbarRemove.Image");
            btnToolbarRemove.ImageTransparentColor = Color.Magenta;
            btnToolbarRemove.Name = "btnToolbarRemove";
            btnToolbarRemove.Size = new Size(67, 24);
            btnToolbarRemove.Text = "Remove";
            // 
            // btnToolbarSave
            // 
            btnToolbarSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolbarSave.Image = (Image)resources.GetObject("btnToolbarSave.Image");
            btnToolbarSave.ImageTransparentColor = Color.Magenta;
            btnToolbarSave.Name = "btnToolbarSave";
            btnToolbarSave.Size = new Size(44, 24);
            btnToolbarSave.Text = "Save";
            // 
            // btnToolbarSearch
            // 
            btnToolbarSearch.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolbarSearch.Image = (Image)resources.GetObject("btnToolbarSearch.Image");
            btnToolbarSearch.ImageTransparentColor = Color.Magenta;
            btnToolbarSearch.Name = "btnToolbarSearch";
            btnToolbarSearch.Size = new Size(57, 24);
            btnToolbarSearch.Text = "Search";
            // 
            // lblStatus
            // 
            lblStatus.ImageScalingSize = new Size(20, 20);
            lblStatus.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            lblStatus.Location = new Point(0, 549);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(984, 26);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Ready";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(50, 20);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(0, 507);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 39);
            panel1.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(827, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(94, 29);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Search";
            txtSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(26, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(559, 27);
            btnSearch.TabIndex = 0;
            // 
            // lstStaff
            // 
            lstStaff.FormattingEnabled = true;
            lstStaff.Location = new Point(0, 55);
            lstStaff.Name = "lstStaff";
            lstStaff.Size = new Size(984, 444);
            lstStaff.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 575);
            Controls.Add(lstStaff);
            Controls.Add(panel1);
            Controls.Add(lblStatus);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDirectory";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            lblStatus.ResumeLayout(false);
            lblStatus.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private StatusStrip lblStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panel1;
        private Button txtSearch;
        private TextBox btnSearch;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem viweToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripButton btnToolbarAdd;
        private ToolStripButton btnToolbarRemove;
        private ToolStripButton btnToolbarSave;
        private ToolStripButton btnToolbarSearch;
        private ListBox lstStaff;
    }
}
