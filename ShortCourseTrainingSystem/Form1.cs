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
        private Color dBackColor = Color.FromArgb(50,50,50);
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
        
        }

        private void miCourse_Leave(object sender, EventArgs e)
        {
            miCourse.BackColor = dBackColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.lbDate.Text = now.ToLongDateString();
            this.lbTime.Text = now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            miDashboard_Click(sender, e);
        }
    }
}
