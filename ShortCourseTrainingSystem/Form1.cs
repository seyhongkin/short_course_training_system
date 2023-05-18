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
    public partial class Form1 : Form
    {
        private Color dBackColor = Color.FromArgb(34,34,34);
        private Color cBackColor = Color.FromArgb(89, 89, 89);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void miDashboard_Click(object sender, EventArgs e)
        {
            miDashboard.BackColor = cBackColor;
        }

        private void miDashboard_Leave(object sender, EventArgs e)
        {
            miDashboard.BackColor = dBackColor;
        }

        private void miCourse_Click(object sender, EventArgs e)
        {
            miCourse.BackColor = cBackColor;
            courses1.Show();
            dashboard1.Hide();
        }

        private void miCourse_Leave(object sender, EventArgs e)
        {
            miCourse.BackColor = dBackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            courses1.Hide();
        }
    }
}
