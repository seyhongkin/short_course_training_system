using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCourseTrainingSystem.Forms.Dialog
{
    public partial class ClassDialog : Form
    {
        public ClassDialog()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void ClassDialog_Load(object sender, EventArgs e)
        {
            foreach (Dictionary<string, string> course in DataStore.courses)
            {
                cbCourse.Items.Add(course["name"]);
            }
            foreach (Dictionary<string, string> room in DataStore.rooms)
            {
                cbRoom.Items.Add(room["name"]);
            }
            foreach (Dictionary<string, string> teacher in DataStore.teachers)
            {
                cbTeacher.Items.Add(teacher["name"]);
            }
            cbCourse.SelectedIndex = 0;
            cbRoom.SelectedIndex = 0;
            cbTeacher.SelectedIndex = 0;
        }
    }
}
