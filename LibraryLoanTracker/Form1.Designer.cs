namespace LibraryLoanTracker
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
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            loansToolStripMenuItem = new ToolStripMenuItem();
            newLoanToolStripMenuItem = new ToolStripMenuItem();
            markAsReturnedToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            btnToolbarNewLoan = new ToolStripButton();
            btnToolbarReturn = new ToolStripButton();
            btnToolbarSave = new ToolStripButton();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            tabControl = new TabControl();
            tabPageLoans = new TabPage();
            splitLoans = new SplitContainer();
            lstLoans = new ListBox();
            rtbLoanDetail = new RichTextBox();
            tabPageOverdue = new TabPage();
            lstOverdue = new ListBox();
            tabPageSummary = new TabPage();
            rtbSummary = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitLoans).BeginInit();
            splitLoans.Panel1.SuspendLayout();
            splitLoans.Panel2.SuspendLayout();
            splitLoans.SuspendLayout();
            tabPageOverdue.SuspendLayout();
            tabPageSummary.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, loansToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(971, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(125, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(125, 26);
            loadToolStripMenuItem.Text = "Load";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(122, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(125, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // loansToolStripMenuItem
            // 
            loansToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newLoanToolStripMenuItem, markAsReturnedToolStripMenuItem });
            loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            loansToolStripMenuItem.Size = new Size(61, 24);
            loansToolStripMenuItem.Text = "Loans";
            // 
            // newLoanToolStripMenuItem
            // 
            newLoanToolStripMenuItem.Name = "newLoanToolStripMenuItem";
            newLoanToolStripMenuItem.Size = new Size(207, 26);
            newLoanToolStripMenuItem.Text = "New Loan";
            // 
            // markAsReturnedToolStripMenuItem
            // 
            markAsReturnedToolStripMenuItem.Name = "markAsReturnedToolStripMenuItem";
            markAsReturnedToolStripMenuItem.Size = new Size(207, 26);
            markAsReturnedToolStripMenuItem.Text = "Mark as Returned";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statusBarToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckOnClick = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(158, 26);
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
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { btnToolbarNewLoan, btnToolbarReturn, btnToolbarSave });
            toolStrip.Location = new Point(0, 28);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(971, 27);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // btnToolbarNewLoan
            // 
            btnToolbarNewLoan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolbarNewLoan.Image = (Image)resources.GetObject("btnToolbarNewLoan.Image");
            btnToolbarNewLoan.ImageTransparentColor = Color.Magenta;
            btnToolbarNewLoan.Name = "btnToolbarNewLoan";
            btnToolbarNewLoan.Size = new Size(79, 24);
            btnToolbarNewLoan.Text = "New Loan";
            btnToolbarNewLoan.Click += btnToolbarNewLoan_Click;
            // 
            // btnToolbarReturn
            // 
            btnToolbarReturn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolbarReturn.Image = (Image)resources.GetObject("btnToolbarReturn.Image");
            btnToolbarReturn.ImageTransparentColor = Color.Magenta;
            btnToolbarReturn.Name = "btnToolbarReturn";
            btnToolbarReturn.Size = new Size(128, 24);
            btnToolbarReturn.Text = "Mark as Returned";
            btnToolbarReturn.Click += btnToolbarReturn_Click;
            // 
            // btnToolbarSave
            // 
            btnToolbarSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolbarSave.Image = (Image)resources.GetObject("btnToolbarSave.Image");
            btnToolbarSave.ImageTransparentColor = Color.Magenta;
            btnToolbarSave.Name = "btnToolbarSave";
            btnToolbarSave.Size = new Size(89, 24);
            btnToolbarSave.Text = "Save to File";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 610);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(971, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(151, 20);
            lblStatus.Text = "toolStripStatusLabel1";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageLoans);
            tabControl.Controls.Add(tabPageOverdue);
            tabControl.Controls.Add(tabPageSummary);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 55);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(971, 555);
            tabControl.TabIndex = 3;
            // 
            // tabPageLoans
            // 
            tabPageLoans.Controls.Add(splitLoans);
            tabPageLoans.Location = new Point(4, 29);
            tabPageLoans.Name = "tabPageLoans";
            tabPageLoans.Padding = new Padding(3);
            tabPageLoans.Size = new Size(963, 522);
            tabPageLoans.TabIndex = 0;
            tabPageLoans.Text = "ActiveLoans";
            tabPageLoans.UseVisualStyleBackColor = true;
            // 
            // splitLoans
            // 
            splitLoans.Dock = DockStyle.Fill;
            splitLoans.Location = new Point(3, 3);
            splitLoans.Name = "splitLoans";
            // 
            // splitLoans.Panel1
            // 
            splitLoans.Panel1.Controls.Add(lstLoans);
            // 
            // splitLoans.Panel2
            // 
            splitLoans.Panel2.Controls.Add(rtbLoanDetail);
            splitLoans.Size = new Size(957, 516);
            splitLoans.SplitterDistance = 319;
            splitLoans.TabIndex = 0;
            // 
            // lstLoans
            // 
            lstLoans.Dock = DockStyle.Fill;
            lstLoans.FormattingEnabled = true;
            lstLoans.Location = new Point(0, 0);
            lstLoans.Name = "lstLoans";
            lstLoans.Size = new Size(319, 516);
            lstLoans.TabIndex = 0;
            // 
            // rtbLoanDetail
            // 
            rtbLoanDetail.Dock = DockStyle.Fill;
            rtbLoanDetail.Location = new Point(0, 0);
            rtbLoanDetail.Name = "rtbLoanDetail";
            rtbLoanDetail.ReadOnly = true;
            rtbLoanDetail.Size = new Size(634, 516);
            rtbLoanDetail.TabIndex = 0;
            rtbLoanDetail.Text = "";
            // 
            // tabPageOverdue
            // 
            tabPageOverdue.Controls.Add(lstOverdue);
            tabPageOverdue.Location = new Point(4, 29);
            tabPageOverdue.Name = "tabPageOverdue";
            tabPageOverdue.Padding = new Padding(3);
            tabPageOverdue.Size = new Size(963, 522);
            tabPageOverdue.TabIndex = 1;
            tabPageOverdue.Text = "Overdue";
            tabPageOverdue.UseVisualStyleBackColor = true;
            // 
            // lstOverdue
            // 
            lstOverdue.Dock = DockStyle.Fill;
            lstOverdue.FormattingEnabled = true;
            lstOverdue.Location = new Point(3, 3);
            lstOverdue.Name = "lstOverdue";
            lstOverdue.Size = new Size(957, 516);
            lstOverdue.TabIndex = 0;
            // 
            // tabPageSummary
            // 
            tabPageSummary.Controls.Add(rtbSummary);
            tabPageSummary.Location = new Point(4, 29);
            tabPageSummary.Name = "tabPageSummary";
            tabPageSummary.Padding = new Padding(3);
            tabPageSummary.Size = new Size(963, 522);
            tabPageSummary.TabIndex = 2;
            tabPageSummary.Text = "Summary";
            tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // rtbSummary
            // 
            rtbSummary.Dock = DockStyle.Fill;
            rtbSummary.Location = new Point(3, 3);
            rtbSummary.Name = "rtbSummary";
            rtbSummary.ReadOnly = true;
            rtbSummary.Size = new Size(957, 516);
            rtbSummary.TabIndex = 0;
            rtbSummary.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 636);
            Controls.Add(tabControl);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibraryLoanTracker";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageLoans.ResumeLayout(false);
            splitLoans.Panel1.ResumeLayout(false);
            splitLoans.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitLoans).EndInit();
            splitLoans.ResumeLayout(false);
            tabPageOverdue.ResumeLayout(false);
            tabPageSummary.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private TabControl tabControl;
        private TabPage tabPageLoans;
        private TabPage tabPageOverdue;
        private TabPage tabPageSummary;
        private SplitContainer splitLoans;
        private ListBox lstLoans;
        private RichTextBox rtbLoanDetail;
        private ListBox lstOverdue;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem loansToolStripMenuItem;
        private ToolStripMenuItem newLoanToolStripMenuItem;
        private ToolStripMenuItem markAsReturnedToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private RichTextBox rtbSummary;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripButton btnToolbarNewLoan;
        private ToolStripButton btnToolbarReturn;
        private ToolStripButton btnToolbarSave;
    }
}
