using ShortCourseTrainingSystem.Forms.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCourseTrainingSystem.Forms.Display
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private List<Dictionary<String, String>> courses = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                {"id","1" },
                {"name","Microsoft Office" },
                {"period","4month" },
                {"price","38" },
                {"monthlyPrice", "10"},
                {"createAt","5/28/2023 10:19:34 PM" }
            },
            new Dictionary<string, string>()
            {
                {"id","2" },
                {"name","Chinese Level 1A" },
                {"period","3month" },
                {"price","35" },
                {"monthlyPrice", "15"},
                {"createAt","5/19/2023 10:19:34 PM" }
            },
            new Dictionary<string, string>()
            {
                {"id","3" },
                {"name","English Beginner" },
                {"period","4month" },
                {"price","38" },
                {"monthlyPrice", "10"},
                {"createAt","5/21/2023 10:19:34 PM" }
            },
        };
        private void CourseForm_Load(object sender, EventArgs e)
        {
            foreach (Dictionary<String, String> course in courses)
            {
                dgvCourse.Rows.Add(course["id"], course["name"], course["period"], course["price"], course["monthlyPrice"], course["createAt"]);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            CreateDialog createDialog = new CreateDialog();
            DialogResult result = createDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                long id = -1;
                foreach (Dictionary<String, String> c in courses)
                {
                    long maxId = long.Parse(c["id"]);
                    if (id < maxId)
                    {
                        id = maxId;
                    }
                }
                id++;
                String createAt = DateTime.Now.ToString();
                Dictionary<String, String> course = new Dictionary<string, string>()
                {
                    {"id",id+"" },
                    {"name", createDialog.txtName.Text },
                    {"period",createDialog.txtPeriod.Text },
                    {"price",createDialog.txtPrice.Text },
                    {"monthlyPrice", createDialog.txtMonthlyPrice.Text},
                    {"createAt",createAt }
                };
                courses.Add(course);
                dgvCourse.Rows.Add(course["id"], course["name"], course["period"], course["price"], course["monthlyPrice"], course["createAt"]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCourse.Rows.Count == 0)
            {
                MessageBox.Show("No Row selected");
                return;
            }
            DataGridViewRow row = dgvCourse.SelectedRows[0];
            CreateDialog dialog = new CreateDialog();

            dialog.Text = "Update";
            dialog.txtName.Text = row.Cells[1].Value.ToString();
            dialog.txtPeriod.Text = row.Cells[2].Value.ToString();
            dialog.txtPrice.Text = row.Cells[3].Value.ToString();
            dialog.txtMonthlyPrice.Text = row.Cells[4].Value.ToString();

            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                //update ui

                //update list dictionaries
            }
        }
    }
}
