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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            dgvTeacher.Rows.Clear();
            foreach (Dictionary<string, string> teacher in DataStore.teachers)
            {
                dgvTeacher.Rows.Add(teacher["id"], teacher["name"], teacher["dob"], teacher["gender"], teacher["maritalStatus"], teacher["hiredAt"], teacher["tel"], teacher["email"], teacher["createAt"], teacher["updateAt"]);
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (MainForm.user["position"] != "admin")
            {
                MessageBox.Show("No Authorized", "Authorize", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            TeacherDialog tDialog = new TeacherDialog();
            tDialog.cbGender.SelectedIndex = 0;
            tDialog.cbMaritalStatus.SelectedIndex = 0;
            DialogResult result = tDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = tDialog.txtName.Text;
                string dob = tDialog.dtpDob.Value.ToShortDateString();
                string maritalStatus = tDialog.cbMaritalStatus.Text;
                string gender = tDialog.cbGender.Text;
                string tel = tDialog.txtTel.Text;
                string email = tDialog.txtEmail.Text;
                string hiredAt = tDialog.dtpHiredAt.Value.ToShortDateString();
                string createAt = DateTime.Now.ToString();

                long id = -1;
                foreach (Dictionary<string, string> t in DataStore.teachers)
                {
                    long tId = long.Parse(t["id"]);
                    if (tId > id)
                    {
                        id = tId;
                    }
                }

                //update teacher list
                Dictionary<string, string> teacher = new Dictionary<string, string>()
                {
                    {"id",(id+1).ToString() },
                    {"name",name },
                    {"dob",dob },
                    {"maritalStatus",maritalStatus },
                    {"gender",gender },
                    {"hiredAt", hiredAt},
                    {"tel", tel},
                    {"email", email},
                    {"createAt",createAt },
                    {"updateAt","" }
                };

                DataStore.teachers.Add(teacher);

                //update ui
                TeacherForm_Load(null, null);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MainForm.user["position"] != "admin")
            {
                MessageBox.Show("No Authorized", "Authorize", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            if (dgvTeacher.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row seleted");
                return;
            }
            DataGridViewRow row = dgvTeacher.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            TeacherDialog tDialog = new TeacherDialog();
            tDialog.cbGender.SelectedIndex = 0;
            tDialog.cbMaritalStatus.SelectedIndex = 0;
            tDialog.Text = "Update";
            tDialog.btnCreate.Text = "Update";
            tDialog.dtpHiredAt.Enabled = false;

            tDialog.txtName.Text = row.Cells[1].Value.ToString();
            tDialog.dtpDob.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            tDialog.cbGender.SelectedItem = row.Cells[3].Value;
            tDialog.cbMaritalStatus.SelectedItem = row.Cells[4].Value;
            tDialog.txtTel.Text = row.Cells[6].Value.ToString();
            tDialog.txtEmail.Text = row.Cells[7].Value.ToString();


            DialogResult result = tDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = tDialog.txtName.Text;
                string dob = tDialog.dtpDob.Value.ToShortDateString();
                string maritalStatus = tDialog.cbMaritalStatus.Text;
                string gender = tDialog.cbGender.Text;
                string tel = tDialog.txtTel.Text;
                string email = tDialog.txtEmail.Text;
                string updateAt = DateTime.Now.ToString();

                //update teacher list
                foreach(Dictionary<string,string> t in DataStore.teachers)
                {
                    if(id == t["id"])
                    {
                        t["name"] = name;
                        t["dob"] = dob;
                        t["maritalStatus"] = maritalStatus;
                        t["gender"] = gender;
                        t["tel"] = tel;
                        t["email"] = email;
                        t["updateAt"] = updateAt;
                    }
                }

                //update ui
                TeacherForm_Load(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MainForm.user["position"] != "admin")
            {
                MessageBox.Show("No Authorized", "Authorize", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            if (dgvTeacher.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row seleted");
                return;
            }

            DataGridViewRow row = dgvTeacher.SelectedRows[0];
            DialogResult result = MessageBox.Show($"Are you sure you want to delete teacher '{row.Cells[1].Value.ToString()}?'", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result != DialogResult.Yes)
            {
                return;
            }

            string id = row.Cells[0].Value.ToString();

            foreach(Dictionary<string,string> t in DataStore.teachers)
            {
                if(id == t["id"])
                {
                    DataStore.teachers.Remove(t);

                    //update ui
                    TeacherForm_Load(null, null);
                    break;
                }

            }

            
        }
    }
}
