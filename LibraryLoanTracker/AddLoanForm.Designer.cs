namespace LibraryLoanTracker
{
    partial class AddLoanForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnOK = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtLoanId = new TextBox();
            label2 = new Label();
            txtBookTitle = new TextBox();
            label3 = new Label();
            txtBorrowerName = new TextBox();
            label4 = new Label();
            cmbBorrowerType = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dtpLoanDate = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOK);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 466);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 104);
            panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(56, 34);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(190, 49);
            btnOK.TabIndex = 0;
            btnOK.Text = "Issue Loan";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(334, 34);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 49);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 53);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 1;
            label1.Text = "Loan ID";
            // 
            // txtLoanId
            // 
            txtLoanId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLoanId.Location = new Point(211, 46);
            txtLoanId.Name = "txtLoanId";
            txtLoanId.Size = new Size(249, 30);
            txtLoanId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 108);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 1;
            label2.Text = "Book Title";
            label2.Click += label2_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookTitle.Location = new Point(211, 108);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(249, 30);
            txtBookTitle.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 172);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 1;
            label3.Text = "Borrower Name";
            label3.Click += label2_Click;
            // 
            // txtBorrowerName
            // 
            txtBorrowerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBorrowerName.Location = new Point(211, 172);
            txtBorrowerName.Name = "txtBorrowerName";
            txtBorrowerName.Size = new Size(249, 30);
            txtBorrowerName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 253);
            label4.Name = "label4";
            label4.Size = new Size(128, 23);
            label4.TabIndex = 1;
            label4.Text = "Borrower Type";
            label4.Click += label2_Click;
            // 
            // cmbBorrowerType
            // 
            cmbBorrowerType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbBorrowerType.FormattingEnabled = true;
            cmbBorrowerType.Items.AddRange(new object[] { "Student,", "Staf" });
            cmbBorrowerType.Location = new Point(211, 253);
            cmbBorrowerType.Name = "cmbBorrowerType";
            cmbBorrowerType.Size = new Size(249, 31);
            cmbBorrowerType.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 253);
            label5.Name = "label5";
            label5.Size = new Size(128, 23);
            label5.TabIndex = 1;
            label5.Text = "Borrower Type";
            label5.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 337);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 1;
            label6.Text = "Loan Date";
            label6.Click += label2_Click;
            // 
            // dtpLoanDate
            // 
            dtpLoanDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpLoanDate.Location = new Point(211, 330);
            dtpLoanDate.Name = "dtpLoanDate";
            dtpLoanDate.Size = new Size(250, 30);
            dtpLoanDate.TabIndex = 4;
            dtpLoanDate.Value = new DateTime(2026, 7, 14, 12, 42, 19, 0);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddLoanForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(624, 570);
            Controls.Add(dtpLoanDate);
            Controls.Add(cmbBorrowerType);
            Controls.Add(txtBorrowerName);
            Controls.Add(txtBookTitle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLoanId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddLoanForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Issue New Book Loan";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnOK;
        private Label label1;
        private TextBox txtLoanId;
        private Label label2;
        private TextBox txtBookTitle;
        private Label label3;
        private TextBox txtBorrowerName;
        private Label label4;
        private ComboBox cmbBorrowerType;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpLoanDate;
        private ErrorProvider errorProvider1;
    }
}