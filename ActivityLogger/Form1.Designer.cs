namespace ActivityLogger
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
            components = new System.ComponentModel.Container();
            btnTest = new Button();
            lblCurrentWindow = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTest.Location = new Point(115, 97);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 46);
            btnTest.TabIndex = 0;
            btnTest.Text = "Click";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // lblCurrentWindow
            // 
            lblCurrentWindow.AutoSize = true;
            lblCurrentWindow.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentWindow.Location = new Point(379, 109);
            lblCurrentWindow.Name = "lblCurrentWindow";
            lblCurrentWindow.Size = new Size(0, 25);
            lblCurrentWindow.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 462);
            Controls.Add(lblCurrentWindow);
            Controls.Add(btnTest);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActivityLogger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTest;
        private Label lblCurrentWindow;
        private System.Windows.Forms.Timer timer1;
    }
}
