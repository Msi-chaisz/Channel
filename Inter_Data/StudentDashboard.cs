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
    public partial class StudentDashBoard : Form
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
        public StudentDashBoard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNav_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {





        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {


        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {


        }

        private void btnStudyNow_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnoucement_Click(object sender, EventArgs e)
        {


        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlDash_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
