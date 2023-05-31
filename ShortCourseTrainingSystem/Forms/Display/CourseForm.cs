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
        private List<Dictionary<string, string>> courses;
        public CourseForm()
        {
            InitializeComponent();
            courses = DataStore.courses;
        }
        
        private void CourseForm_Load(object sender, EventArgs e)
        {
            dgvCourse.Rows.Clear();
            foreach (Dictionary<String, String> course in courses)
            {
                dgvCourse.Rows.Add(course["id"], course["name"], course["period"], course["price"], course["monthlyPrice"], course["createAt"], course["updateAt"]);
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
                    {"createAt",createAt },
                    {"updateAt","" }
                };
                courses.Add(course);
                dgvCourse.Rows.Add(course["id"], course["name"], course["period"], course["price"], course["monthlyPrice"], course["createAt"], "");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count == 0)
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

            string id = row.Cells[0].Value.ToString();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                String createAt = "";
                foreach (Dictionary<String, String> c in courses)
                {
                    if (id == c["id"].ToString())
                    {
                        createAt = c["createAt"].ToString();
                    }
                }
                String updateAt = DateTime.Now.ToString();
                Dictionary<String, String> course = new Dictionary<string, string>()
                {
                    {"name", dialog.txtName.Text },
                    {"period",dialog.txtPeriod.Text },
                    {"price",dialog.txtPrice.Text },
                    {"monthlyPrice", dialog.txtMonthlyPrice.Text},
                    {"createAt",createAt },
                    {"updateAt",updateAt }
                };

                //update list dictionaries
                foreach(Dictionary<String,String> c in courses)
                {
                    if (c["id"].ToString() == id)
                    {
                        c["name"] = dialog.txtName.Text;
                        c["period"] = dialog.txtPeriod.Text;
                        c["price"] = dialog.txtPrice.Text;
                        c["monthlyPrice"] = dialog.txtMonthlyPrice.Text;
                        c["createAt"] = createAt;
                        c["updateAt"] = updateAt;
                    }
                }

                //update ui
                CourseForm_Load(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Row selected");
                return;
            }
            DataGridViewRow row = dgvCourse.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{row.Cells[1].Value}' course?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                //update list dictionaries
                foreach (Dictionary<String, String> c in courses)
                {
                    if (c["id"].ToString() == id)
                    {
                        courses.Remove(c);

                        //update ui
                        CourseForm_Load(null, null);
                        break;
                    }
                }
            }
        }
    }
}
