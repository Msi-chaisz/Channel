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
    public partial class StudentPortal : Form
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
        public StudentPortal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please input your credentials!");
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string query = "SELECT COUNT(*) FROM studentportal WHERE Username=@username AND Password=@password";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                if (count == 1)
                {
                    MessageBox.Show("Welcome Student!");
                    StudentDashBoard dashboard = new StudentDashBoard();
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errors In:" + ex);
            }
            finally
            {
                db.Close();
            }

            txtUser.Clear();
            txtPass.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RegisterAccount reg  = new RegisterAccount();
            reg.Show();
            this.Hide();
        }
    }
}
