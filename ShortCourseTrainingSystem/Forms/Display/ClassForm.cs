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
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
        }


        private void ClassForm_Load(object sender, EventArgs e)
        {
            dgvClass.Rows.Clear();
            foreach (Dictionary<string, string> c in DataStore.classes)
            {
                string courseName = "";
                string roomName = "";
                string teacherName = "";
                foreach (Dictionary<string, string> course in DataStore.courses)
                {
                    if (course["id"] == c["courseId"])
                    {
                        courseName = course["name"];
                        break;
                    }
                }

                foreach (Dictionary<string, string> room in DataStore.rooms)
                {
                    if (room["id"] == c["roomId"])
                    {
                        roomName = room["name"];
                        break;
                    }
                }
                foreach (Dictionary<string, string> teacher in DataStore.teachers)
                {
                    if (teacher["id"] == c["teacherId"])
                    {
                        teacherName = teacher["name"];
                        break;
                    }
                }
                dgvClass.Rows.Add(c["id"], courseName, roomName, teacherName, c["time"], c["createAt"], c["updateAt"]);
            }
        }

        private long getCourseId(string courseName)
        {
            foreach (Dictionary<string, string> course in DataStore.courses)
            {
                if (course["name"] == courseName)
                {
                    return long.Parse(course["id"]);
                }
            }
            return 0;
        }

        private long getTeacherId(string teacherName)
        {
            foreach (Dictionary<string, string> teacher in DataStore.teachers)
            {
                if (teacher["name"] == teacherName)
                {
                    return long.Parse(teacher["id"]);
                }
            }
            return 0;
        }

        private long getRoomId(string roomName)
        {
            foreach (Dictionary<string, string> room in DataStore.rooms)
            {
                if (room["name"] == roomName)
                {
                    return long.Parse(room["id"]);
                }
            }
            return 0;
        }

        private long sequenceId()
        {
            long id = -1;
            foreach (Dictionary<string, string> c in DataStore.classes)
            {
                long cId = long.Parse(c["id"]);
                if (cId > id)
                {
                    id = cId;
                }
            }

            return (id + 1);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            ClassDialog cDialog = new ClassDialog();
            DialogResult result = cDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                long cId = getCourseId(cDialog.cbCourse.Text);
                long rId = getRoomId(cDialog.cbRoom.Text);
                long tId = getTeacherId(cDialog.cbTeacher.Text);
                string time = cDialog.txtTime.Text.Trim();
                string createAt = DateTime.Now.ToString();

                Dictionary<string, string> c = new Dictionary<string, string>()
                {
                    {"id",sequenceId().ToString() },
                    {"courseId", cId.ToString()},
                    {"roomId",rId.ToString() },
                    {"teacherId",tId.ToString() },
                    {"time", time },
                    {"createAt",createAt },
                    {"updateAt","" }
                };
                //update classes list
                DataStore.classes.Add(c);

                //update ui
                ClassForm_Load(null, null);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataGridViewRow row = dgvClass.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();

            ClassDialog cDialog = new ClassDialog();
            cDialog.Text = "Update";
            cDialog.btnCreate.Text = "Update";
            cDialog.txtTime.Text = row.Cells[4].Value.ToString();
            cDialog.cbCourse.SelectedItem = row.Cells[1].Value.ToString();
            cDialog.cbRoom.SelectedItem = row.Cells[2].Value.ToString();
            cDialog.cbTeacher.SelectedItem = row.Cells[3].Value.ToString();
            DialogResult result = cDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (Dictionary<string, string> c in DataStore.classes)
                {
                    if (c["id"] == id)
                    {
                        c["courseId"] = getCourseId(cDialog.cbCourse.Text).ToString();
                        c["roomId"] = getRoomId(cDialog.cbRoom.Text).ToString();
                        c["teacherId"] = getTeacherId(cDialog.cbTeacher.Text).ToString();
                        c["time"] = cDialog.txtTime.Text.Trim();
                        c["updateAt"] = DateTime.Now.ToString();

                        //update ui
                        ClassForm_Load(null, null);
                        break;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataGridViewRow row = dgvClass.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete this class?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            foreach (Dictionary<string, string> c in DataStore.classes)
            {
                if (c["id"] == id)
                {
                    DataStore.classes.Remove(c);

                    //update ui
                    ClassForm_Load(null, null);
                    break;
                }
            }
        }

        public static Dictionary<string, string> getStudent(string stId)
        {
            foreach (Dictionary<string, string> s in DataStore.students)
            {
                if (stId == s["id"])
                {
                    return s;
                }
            }
            return null;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            if (MainForm.user["position"] != "admin")
            {
                MessageBox.Show("No Authorized","Authorize",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                return;
            }
            if (dgvClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataGridViewRow row = dgvClass.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();

            AttendaceDialog attendace = new AttendaceDialog(id);
            attendace.Show();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            if (MainForm.user["position"] != "admin")
            {
                MessageBox.Show("No Authorized", "Authorize", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            if (dgvClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected");
                return;
            }

            DataGridViewRow row = dgvClass.SelectedRows[0];
            string cId = row.Cells[0].Value.ToString();
            ExamDialog examDialog = new ExamDialog(cId);
            examDialog.Show();

        }
    }
}
