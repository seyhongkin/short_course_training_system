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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            dgvStudent.Rows.Clear();
            foreach (Dictionary<string, string> student in DataStore.students)
            {
                dgvStudent.Rows.Add(student["id"], student["name"], student["dob"], student["gender"], student["tel"], student["email"], student["createAt"], student["updateAt"]);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentDialog sDialog = new StudentDialog();
            sDialog.cbGender.SelectedIndex = 0;
            DialogResult result = sDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                long id = -1;
                foreach (Dictionary<string, string> s in DataStore.students)
                {
                    long sId = long.Parse(s["id"]);
                    if (sId > id)
                    {
                        id = sId;
                    }
                }

                Dictionary<string, string> student = new Dictionary<string, string>()
                {
                    {"id",(++id).ToString() },
                    {"name",sDialog.txtName.Text.Trim() },
                    {"dob",sDialog.dtpDob.Value.ToShortDateString() },
                    {"gender",sDialog.cbGender.Text },
                    {"tel", sDialog.txtTel.Text.Trim()},
                    {"email", sDialog.txtEmail.Text.Trim()},
                    {"createAt", DateTime.Now.ToString()},
                    {"updateAt","" }
                };
                //update list students
                DataStore.students.Add(student);

                //update ui
                StudentForm_Load(null, null);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Row Selected!");
                return;
            }
            DataGridViewRow row = dgvStudent.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            StudentDialog sDialog = new StudentDialog();
            sDialog.txtName.Text = row.Cells[1].Value.ToString();
            sDialog.dtpDob.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            sDialog.cbGender.SelectedItem = row.Cells[3].Value.ToString();
            sDialog.txtTel.Text = row.Cells[4].Value.ToString();
            sDialog.txtEmail.Text = row.Cells[5].Value.ToString();
            sDialog.Text = "Update";
            sDialog.btnCreate.Text = "Update";
            DialogResult result = sDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (Dictionary<string, string> s in DataStore.students)
                {
                    if (id == s["id"])
                    {
                        s["name"] = sDialog.txtName.Text.Trim();
                        s["dob"] = sDialog.dtpDob.Value.ToShortDateString();
                        s["gender"] = sDialog.cbGender.Text;
                        s["tel"] = sDialog.txtTel.Text.Trim();
                        s["email"] = sDialog.txtEmail.Text.Trim();
                        s["updateAt"] = DateTime.Now.ToString();

                        //update ui
                        StudentForm_Load(null, null);
                        break;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Row Selected!");
                return;
            }

            DataGridViewRow row = dgvStudent.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete student name '{row.Cells[1].Value.ToString()}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            foreach (Dictionary<string, string> s in DataStore.students)
            {
                if (s["id"] == id)
                {
                    DataStore.students.Remove(s);

                    //update ui
                    StudentForm_Load(null, null);
                    break;
                }
            }
        }

        private string getClassId(string cId, string time, string tId)
        {
            foreach (Dictionary<string, string> c in DataStore.classes)
            {
                if (c["courseId"] == cId && c["time"] == time && c["teacherId"] == tId)
                {
                    return c["id"];
                }
            }
            return "";
        }

        private string getStudentId(string sName)
        {
            foreach (Dictionary<string, string> s in DataStore.students)
            {
                if (s["name"] == sName)
                {
                    return s["id"];
                }
            }
            return "";
        }

        private string getTeacherId(string tName)
        {
            foreach (Dictionary<string, string> t in DataStore.teachers)
            {
                if (t["name"] == tName)
                {
                    return t["id"];
                }
            }
            return "";
        }

        private string getCourseId(string cName)
        {
            foreach (Dictionary<string, string> c in DataStore.courses)
            {
                if (c["name"] == cName)
                {
                    return c["id"];
                }
            }
            return "";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataGridViewRow row = dgvStudent.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            PaymentDialog pDialog = new PaymentDialog();
            pDialog.txtStudent.Text = row.Cells[1].Value.ToString();
            pDialog.txtStudent.Enabled = false;

            DialogResult result = pDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string studentId = getStudentId(pDialog.txtStudent.Text);
                string courseId = getCourseId(pDialog.cbCourse.Text);
                string time = pDialog.cbTime.Text;
                string teacherId = getTeacherId(pDialog.cbTeacher.Text);
                string classId = getClassId(courseId, time, teacherId);
                long pId = -1;
                foreach(Dictionary<string,string> p in DataStore.payments)
                {
                    long payId = long.Parse(p["id"]);
                    if (pId < payId)
                    {
                        pId = payId;
                    }
                }

                Dictionary<string, string> payment = new Dictionary<string, string>()
                {
                    {"id", (++pId).ToString() },
                    {"stId",studentId },
                    {"classId",classId },
                    {"price",pDialog.txtPrice.Text },
                    {"discount",pDialog.cbDiscount.Text },
                    {"paidAt", DateTime.Now.ToString() },
                    {"rep","" }
                };

                DataStore.payments.Add(payment);

            }
        }
    }
}
