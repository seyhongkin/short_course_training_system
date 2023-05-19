using ShortCourseTrainingSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCourseTrainingSystem
{
    public partial class MainForm : Form
    {
        private Color dBackColor = Color.FromArgb(50,50,50);
        private Color cBackColor = Color.FromArgb(89, 89, 89);
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miDashboard_Click(sender, e);
            lbTabName.Text = "Dashboard";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void miDashboard_Click(object sender, EventArgs e)
        {
            miDashboard.BackColor = cBackColor;
            pnMenuHighLight.Top = miDashboard.Top;
            pnMenuHighLight.Left = miDashboard.Left;
            pnMenuHighLight.Height = miDashboard.Height;
        }

        private void miDashboard_Leave(object sender, EventArgs e)
        {
            miDashboard.BackColor = dBackColor;
        }

        private void miCourse_Click(object sender, EventArgs e)
        {
            miCourse.BackColor = cBackColor;
            pnMenuHighLight.Top = miCourse.Top;
            pnMenuHighLight.Left = miCourse.Left;
            pnMenuHighLight.Height = miCourse.Height;
            lbTabName.Text = "Courses";
        }


        private void miTeacher_Click(object sender, EventArgs e)
        {
            miTeacher.BackColor = cBackColor;
            pnMenuHighLight.Top = miTeacher.Top;
            pnMenuHighLight.Left = miTeacher.Left;
            pnMenuHighLight.Height = miTeacher.Height;
            lbTabName.Text = "Teachers";
        }

        private void miStudent_Click(object sender, EventArgs e)
        {
            miStudent.BackColor = cBackColor;
            pnMenuHighLight.Top = miStudent.Top;
            pnMenuHighLight.Left = miStudent.Left;
            pnMenuHighLight.Height = miStudent.Height;
            lbTabName.Text = "Students";
        }

        private void miInvoice_Click(object sender, EventArgs e)
        {
            miInvoice.BackColor = cBackColor;
            pnMenuHighLight.Top = miInvoice.Top;
            pnMenuHighLight.Left = miInvoice.Left;
            pnMenuHighLight.Height = miInvoice.Height;
            lbTabName.Text = "Invoices";
        }

        private void miRoom_Click(object sender, EventArgs e)
        {
            miRoom.BackColor = cBackColor;
            pnMenuHighLight.Top = miRoom.Top;
            pnMenuHighLight.Left = miRoom.Left;
            pnMenuHighLight.Height = miRoom.Height;
            lbTabName.Text = "Rooms";
        }

        private void miProfile_Click(object sender, EventArgs e)
        {
            miProfile.BackColor = cBackColor;
            pnMenuHighLight.Top = miProfile.Top;
            pnMenuHighLight.Left = miProfile.Left;
            pnMenuHighLight.Height = miProfile.Height;
            lbTabName.Text = "Profile";
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            miAbout.BackColor = cBackColor;
            pnMenuHighLight.Top = miAbout.Top;
            pnMenuHighLight.Left = miAbout.Left;
            pnMenuHighLight.Height = miAbout.Height;
            lbTabName.Text = "About";
        }

        private void miCourse_Leave(object sender, EventArgs e)
        {
            miCourse.BackColor = dBackColor;
        }

        private void miTeacher_Leave(object sender, EventArgs e)
        {
            miTeacher.BackColor = dBackColor;
        }

        private void miStudent_Leave(object sender, EventArgs e)
        {
            miStudent.BackColor = dBackColor;
        }

        private void miInvoice_Leave(object sender, EventArgs e)
        {
            miInvoice.BackColor = dBackColor;
        }

        private void miRoom_Leave(object sender, EventArgs e)
        {
            miRoom.BackColor = dBackColor;
        }

        private void miProfile_Leave(object sender, EventArgs e)
        {
            miProfile.BackColor = dBackColor;
        }

        private void miAbout_Leave(object sender, EventArgs e)
        {
            miAbout.BackColor = dBackColor;
        }

        private void miLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new LoginForm().Show();
        }

        private void picUser_Click(object sender, EventArgs e)
        {
            miProfile_Click(null,null);
        }

        private void lbUserName_Click(object sender, EventArgs e)
        {
            miProfile_Click(null, null);
        }
    }
}
