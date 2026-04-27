namespace Inter_Data
{
    partial class RegisterAccount
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
            label6 = new Label();
            txtStudNo = new TextBox();
            panel2 = new Panel();
            lblRegister = new Label();
            btnRegister = new RoundedButton();
            label5 = new Label();
            cbSection = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtStudNo);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbSection);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(168, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 532);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 385);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 12;
            label6.Text = "Student No.";
            // 
            // txtStudNo
            // 
            txtStudNo.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudNo.Location = new Point(146, 373);
            txtStudNo.Name = "txtStudNo";
            txtStudNo.Size = new Size(249, 32);
            txtStudNo.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(lblRegister);
            panel2.Location = new Point(463, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 532);
            panel2.TabIndex = 10;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Location = new Point(152, 347);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(178, 20);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Already have an account?";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(146, 432);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(249, 35);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += roundedButton1_Click;
            btnRegister.MouseClick += btnRegister_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 326);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 8;
            label5.Text = "Section:";
            // 
            // cbSection
            // 
            cbSection.Font = new Font("Bahnschrift SemiLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(146, 310);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(249, 36);
            cbSection.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 264);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 203);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 147);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(146, 252);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 32);
            txtEmail.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(146, 191);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(249, 32);
            txtPass.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(146, 135);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(249, 32);
            txtUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 73);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "CREATE ACCOUNT";
            // 
            // RegisterAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1280, 839);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterAccount";
            Load += RegisterAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RoundedButton btnRegister;
        private Label label5;
        private ComboBox cbSection;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPass;
        private TextBox txtUser;
        private Panel panel2;
        private Label lblRegister;
        private Label label6;
        private TextBox txtStudNo;
    }
}