using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Inter_Data
{
    public partial class RegisterAccount : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // height of ellipse
              int nHeightEllipse // width of ellipse
           );

        public RegisterAccount()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            this.Load += Registration_Load;

        }

        private void RegisterAccount_Load(object sender, EventArgs e)
        {

        }


        public void Registration_Load(object sender, EventArgs e)
        {
            cbSection.Items.AddRange(new string[] { "ACT-1A", "ACT-1B", "ACT-1C", "ACT-1D", "ACT-1E", "ACT-1F",
            "ACT-2A", "ACT-2B", "ACT-2C", "ACT-2D", "ACT-2E", "ACT-2F", "HM-1A", "HM-1B", "HM-1C", "HM-1D", "HM-1E", "HM-1F",
            "HM-2A", "HM-2B", "HM-2C", "HM-2D", "HM-2E", "HM-2F", "BSOA-1A", "BSOA-1B", "BSOA-1C", "BSOA-1D", "BSOA-1E", "BSOA-1F",
            "BSOA-2A", "BSOA-2B", "BSOA-2C", "BSOA-2D", "BSOA-2E", "BSOA-2F"});
            cbSection.SelectedIndex = -1;

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_MouseClick(object sender, MouseEventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            string email = txtEmail.Text.Trim();
            string section = cbSection.SelectedItem?.ToString();
            int search = int.Parse(txtStudNo.Text.Trim());

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!int.TryParse(txtStudNo.Text.Trim(), out search))
            {
                MessageBox.Show("Please enter a unique number!");
                return;
            }

            int count = 8;
            if(password.Length < count)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }
            else if (password.Length > count)
            {
                MessageBox.Show("Password must be at most 8 characters long.");
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string query = "SELECT StudentNo FROM studentportal WHERE StudentNo = @search";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@search", search);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Student number already exists. Please enter a unique number.");
                            return;
                        }
                    }
                }

                string insertQuery = @"INSERT INTO studentportal (Username, Password, Email, Section, StudentNo) VALUES (@username, @password, @email, @section, @studentNo)";

                using (MySqlCommand cmds = new MySqlCommand(insertQuery, db.Connection))
                {
                    cmds.Parameters.AddWithValue("@username", username);
                    cmds.Parameters.AddWithValue("@password", password);
                    cmds.Parameters.AddWithValue("@email", email);
                    cmds.Parameters.AddWithValue("@section", section);
                    cmds.Parameters.AddWithValue("@studentNo", search);

                    int rowsAffected = cmds.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");
                       
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                db.Close();
            }

            txtUser.Clear();
            txtStudNo.Clear();
            txtPass.Clear();
            txtEmail.Clear();

            StudentPortal port = new StudentPortal();
            port.Show();

            this.Hide();
        }
    }
}
