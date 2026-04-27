namespace Inter_Data
{
    partial class StudentPortal
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
            panel1 = new Panel();
            panel2 = new Panel();
            lblRegister = new Label();
            label1 = new Label();
            btnLog = new RoundedButton();
            txtPass = new TextBox();
            txtUser = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLog);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUser);
            panel1.Location = new Point(164, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 532);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(lblRegister);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 532);
            panel2.TabIndex = 4;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Location = new Point(152, 347);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(163, 20);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Don't have an account?";
            lblRegister.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(614, 129);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 3;
            label1.Text = "Welcome Student!";
            // 
            // btnLog
            // 
            btnLog.Location = new Point(565, 323);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(265, 44);
            btnLog.TabIndex = 2;
            btnLog.Text = "Log In";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(565, 267);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(265, 32);
            txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(565, 215);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username";
            txtUser.Size = new Size(265, 32);
            txtUser.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(134, 566);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // StudentPortal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1280, 839);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentPortal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentPortal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RoundedButton btnLog;
        private TextBox txtPass;
        private TextBox txtUser;
        private Panel panel2;
        private Label lblRegister;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}