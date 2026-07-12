namespace StaffDirectory
{
    partial class AddStaffForm
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
            label1 = new Label();
            txtEmployeeId = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            Email = new Label();
            txtEmail = new TextBox();
            cmbDepartment = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 40);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 0;
            label1.Text = "EmployeeID";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmployeeId.Location = new Point(269, 40);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(263, 34);
            txtEmployeeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 107);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 0;
            label2.Text = "FullName";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(269, 107);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(263, 34);
            txtFullName.TabIndex = 1;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.Location = new Point(75, 181);
            Email.Name = "Email";
            Email.Size = new Size(125, 28);
            Email.TabIndex = 0;
            Email.Text = "EmployeeID";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(269, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 34);
            txtEmail.TabIndex = 1;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { " IT,HR,Finance,Operations,Management" });
            cmbDepartment.Location = new Point(269, 242);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(263, 28);
            cmbDepartment.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 242);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 0;
            label3.Text = "Item";
            // 
            // button1
            // 
            button1.Location = new Point(126, 370);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(126, 370);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 40);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(455, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddStaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(button1);
            Controls.Add(cmbDepartment);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(Email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmployeeId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddStaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStaffForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmployeeId;
        private Label label2;
        private TextBox txtFullName;
        private Label Email;
        private TextBox txtEmail;
        private ComboBox cmbDepartment;
        private Label label3;
        private Button button1;
        private Button btnOK;
        private Button btnCancel;
    }
}