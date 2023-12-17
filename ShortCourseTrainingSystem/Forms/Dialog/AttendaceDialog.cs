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

namespace ShortCourseTrainingSystem.Forms.Dialog
{
    public partial class AttendaceDialog : Form
    {
        string cId;
        public AttendaceDialog(String classId)
        {
            InitializeComponent();
            cId = classId;
        }

        private Dictionary<string, string> getAttendance(string cId, string sId)
        {
            int att = 0;
            int permission = 0;

            foreach (Dictionary<string, string> a in DataStore.attendance)
            {
                if (cId == a["classId"] && sId == a["stId"])
                {
                    if (a["hasPermission"] == "t")
                    {
                        permission++;
                        continue;
                    }
                    att++;
                }
            }
            Dictionary<string, string> result = new Dictionary<string, string>()
            {
                {"att",att.ToString() },
                {"permission",permission.ToString()}
            };
            return result;
        }

        private void AttendaceDialog_Load(object sender, EventArgs e)
        {
            dgvStudentList.Rows.Clear();
            cbAttType.SelectedIndex = 1;
            foreach (Dictionary<string, string> c in DataStore.payments)
            {
                if (c["classId"] == cId)
                {
                    Dictionary<string, string> s = ClassForm.getStudent(c["stId"]);
                    Dictionary<string, string> att = getAttendance(c["classId"], c["stId"]);
                    int absence = int.Parse(att["att"]);
                    int permission = int.Parse(att["permission"]);
                    int totalAbsence = absence + permission;
                    dgvStudentList.Rows.Add(s["id"], s["name"], att["att"], att["permission"], totalAbsence.ToString());
                }
            }
        }

        private void cbAttType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAttType.SelectedIndex == 0)
            {
                dgvStudentList.Enabled = false;
                return;
            }
            dgvStudentList.Enabled = true;
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            if(cbAttType.SelectedIndex == 0)
            {
                AttendanceDetailDialog attendanceDetail = new AttendanceDetailDialog();
                attendanceDetail.ShowDialog();
                return;
            }
            if (dgvStudentList.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataGridViewRow row = dgvStudentList.SelectedRows[0];
            string sid = row.Cells[0].Value.ToString();
            AttendanceDetailDialog attDetail = new AttendanceDetailDialog(cId, sid);
            attDetail.ShowDialog();
        }

        private string getStudentId(string stName)
        {
            foreach (Dictionary<string, string> s in DataStore.students)
            {
                if (stName == s["name"])
                {
                    return s["id"];
                }
            }
            return "";
        }

        private string getTeacherName(string cId)
        {
            string tId = "";
            foreach (Dictionary<string, string> c in DataStore.classes)
            {
                if (cId == c["id"])
                {
                    tId = c["teacherId"];
                }
            }
            foreach (Dictionary<string, string> t in DataStore.teachers)
            {
                if (tId == t["id"])
                {
                    return t["name"];
                }
            }
            return "";
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            if (cbAttType.SelectedIndex == 0)
            {
                RecordAttendanceDialog r = new RecordAttendanceDialog();
                r.lbName.Text = getTeacherName(cId);
                DialogResult dialogResult = r.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    long tId = -1;
                    foreach(Dictionary<string,string> t in DataStore.teacherAttendance)
                    {
                        long tid = long.Parse(t["id"]);
                        if(tId < tid)
                        {
                            tId = tid;
                        }
                    }
                    Dictionary<string, string> teacherAtt = new Dictionary<string, string>()
                        {
                            {"id",tId.ToString()},
                            {"classId",cId },
                            {"hasPermission",r.cbHasPermission.Checked ? "t" : "f" },
                            {"date", r.dtpAtt.Text },
                        };
                    DataStore.teacherAttendance.Add(teacherAtt);
                }
                return;
            }

            if (dgvStudentList.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataGridViewRow row = dgvStudentList.SelectedRows[0];
            string sid = row.Cells[0].Value.ToString();
            RecordAttendanceDialog record = new RecordAttendanceDialog();
            record.lbName.Text = row.Cells[1].Value.ToString();
            DialogResult result = record.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (Dictionary<string, string> a in DataStore.attendance)
                {
                    if (cId == a["classId"])
                    {
                        string stId = getStudentId(record.lbName.Text);
                        string hasPermission = record.cbHasPermission.Checked ? "t" : "f";
                        Dictionary<string, string> attendance = new Dictionary<string, string>()
                        {
                            {"id","1" },
                            {"stId",stId },
                            {"classId",cId },
                            {"hasPermission",hasPermission },
                            {"date",DateTime.Now.ToLongDateString() },
                        };

                        //update attendance lists
                        DataStore.attendance.Add(attendance);

                        //update ui
                        AttendaceDialog_Load(null, null);
                        break;
                    }
                }
            }
        }
    }
}
