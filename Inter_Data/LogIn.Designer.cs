namespace Inter_Data
{
    partial class LogIn
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
            label1 = new Label();
            roundedButton1 = new RoundedButton();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            roundedButton2 = new RoundedButton();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            roundedButton3 = new RoundedButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(64, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 514);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 406);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 2;
            label1.Text = "TEACHER";
            // 
            // roundedButton1
            // 
            roundedButton1.Location = new Point(60, 452);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(243, 41);
            roundedButton1.TabIndex = 1;
            roundedButton1.Text = "ACCESS ACCOUNT";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 369);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(roundedButton2);
            panel2.Location = new Point(450, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 514);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 406);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "STUDENT";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(16, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(337, 369);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // roundedButton2
            // 
            roundedButton2.Location = new Point(67, 452);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(243, 41);
            roundedButton2.TabIndex = 3;
            roundedButton2.Text = "LEARN NOW";
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(roundedButton3);
            panel3.Location = new Point(836, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(367, 514);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 406);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 6;
            label3.Text = "ADMIN";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(16, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(337, 369);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // roundedButton3
            // 
            roundedButton3.Location = new Point(74, 452);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(243, 41);
            roundedButton3.TabIndex = 5;
            roundedButton3.Text = "MANAGE ";
            roundedButton3.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1280, 839);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += LogIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private RoundedButton roundedButton1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private RoundedButton roundedButton2;
        private Label label3;
        private PictureBox pictureBox3;
        private RoundedButton roundedButton3;
    }
}