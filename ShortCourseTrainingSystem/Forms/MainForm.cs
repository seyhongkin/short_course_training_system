using ShortCourseTrainingSystem.Forms;
using ShortCourseTrainingSystem.Forms.Display;
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
        public static Dictionary<string, string> user;
        private Color dBackColor = Color.FromArgb(50,50,50);
        private Color cBackColor = Color.FromArgb(89, 89, 89);
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(Dictionary<string,string> u)
        {
            InitializeComponent();
            user = u;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTabName.Text = "Dashboard";           
            miDashboard_Click(sender, e);
            lbUserName.Text = user["username"].ToUpper();
            lbPosition.Text = user["position"];
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
            lbTabName.Text = "Dashboard";

            this.pnLoadForm.Controls.Clear();
            DashboardForm dashboard = new DashboardForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnLoadForm.Controls.Add(dashboard);
            dashboard.Show();
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

            this.pnLoadForm.Controls.Clear();
            CourseForm coursefrm = new CourseForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            coursefrm.FormBorderStyle = FormBorderStyle.None;
            this.pnLoadForm.Controls.Add(coursefrm);
            coursefrm.Show();
        }


        private void miTeacher_Click(object sender, EventArgs e)
        {
            miTeacher.BackColor = cBackColor;
            pnMenuHighLight.Top = miTeacher.Top;
            pnMenuHighLight.Left = miTeacher.Left;
            pnMenuHighLight.Height = miTeacher.Height;
            lbTabName.Text = "Teachers";

            this.pnLoadForm.Controls.Clear();
            TeacherForm teacherfrm = new TeacherForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            teacherfrm.FormBorderStyle = FormBorderStyle.None;
            this.pnLoadForm.Controls.Add(teacherfrm);
            teacherfrm.Show();
        }

        private void miStudent_Click(object sender, EventArgs e)
        {
            miStudent.BackColor = cBackColor;
            pnMenuHighLight.Top = miStudent.Top;
            pnMenuHighLight.Left = miStudent.Left;
            pnMenuHighLight.Height = miStudent.Height;
            lbTabName.Text = "Students";

            this.pnLoadForm.Controls.Clear();
            StudentForm studentfrm = new StudentForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            studentfrm.FormBorderStyle = FormBorderStyle.None;
            this.pnLoadForm.Controls.Add(studentfrm);
            studentfrm.Show();
        }

        private void miInvoice_Click(object sender, EventArgs e)
        {
            miPayment.BackColor = cBackColor;
            pnMenuHighLight.Top = miPayment.Top;
            pnMenuHighLight.Left = miPayment.Left;
            pnMenuHighLight.Height = miPayment.Height;
            lbTabName.Text = "Payment";

            this.pnLoadForm.Controls.Clear();
            PaymentForm payment = new PaymentForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            payment.FormBorderStyle = FormBorderStyle.None;
            this.pnLoadForm.Controls.Add(payment);
            payment.Show();
        }

        private void miRoom_Click(object sender, EventArgs e)
        {
            miRoom.BackColor = cBackColor;
            pnMenuHighLight.Top = miRoom.Top;
            pnMenuHighLight.Left = miRoom.Left;
            pnMenuHighLight.Height = miRoom.Height;
            lbTabName.Text = "Rooms";

            this.pnLoadForm.Controls.Clear();
            RoomForm roomfrm = new RoomForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            roomfrm.FormBorderStyle = FormBorderStyle.None;
            this.pnLoadForm.Controls.Add(roomfrm);
            roomfrm.Show();
        }

        private void miProfile_Click(object sender, EventArgs e)
        {
            miProfile.BackColor = cBackColor;
            pnMenuHighLight.Top = miProfile.Top;
            pnMenuHighLight.Left = miProfile.Left;
            pnMenuHighLight.Height = miProfile.Height;
            lbTabName.Text = "Classes";

            this.pnLoadForm.Controls.Clear();
            ClassForm profilefrm = new ClassForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            profilefrm.FormBorderStyle = FormBorderStyle.None;
            this.pnLoadForm.Controls.Add(profilefrm);
            profilefrm.Show();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            miProfile_Leave(null, null);
            miAbout.BackColor = cBackColor;
            pnMenuHighLight.Top = miAbout.Top;
            pnMenuHighLight.Left = miAbout.Left;
            pnMenuHighLight.Height = miAbout.Height;
            lbTabName.Text = "About";

            this.pnLoadForm.Controls.Clear();
            AboutForm aboutfrm = new AboutForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            aboutfrm.FormBorderStyle = FormBorderStyle.None;
            this.pnLoadForm.Controls.Add(aboutfrm);
            aboutfrm.Show();
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
            miPayment.BackColor = dBackColor;
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

    }
}
