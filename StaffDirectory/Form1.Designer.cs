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
            menuStrip1 = new MenuStrip();
            toolStrip1 = new ToolStrip();
            lblStatus = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1 = new Panel();
            txtSearch = new Button();
            btnSearch = new TextBox();
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
            menuStrip1.SuspendLayout();
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
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(984, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
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
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(224, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
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
            clearAllToolStripMenuItem.Size = new Size(224, 26);
            clearAllToolStripMenuItem.Text = "Clear All";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(224, 26);
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
            statusBarToolStripMenuItem.Size = new Size(224, 26);
            statusBarToolStripMenuItem.Text = "Status Bar";
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
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 575);
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
    }
}
