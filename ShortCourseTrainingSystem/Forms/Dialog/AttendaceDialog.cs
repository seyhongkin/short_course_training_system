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
                        break;
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
            cbAttType.SelectedIndex = 1;
            foreach(Dictionary<string,string> c in DataStore.payments)
            {
                if (c["classId"] == cId)
                {
                    Dictionary<string, string> s = ClassForm.getStudent(c["stId"]);
                    Dictionary<string,string> att = getAttendance(c["classId"], c["stId"]);
                    dgvStudentList.Rows.Add(s["id"], s["name"], att["att"], att["permission"]);
                }
            }
        }

        private void cbAttType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbAttType.SelectedIndex == 0)
            {
                dgvStudentList.Enabled = false;
                return;
            }
            dgvStudentList.Enabled = true;
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            if(dgvStudentList.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataGridViewRow row = dgvStudentList.SelectedRows[0];
            string sid = row.Cells[0].Value.ToString();
            AttendanceDetailDialog attDetail = new AttendanceDetailDialog(cId,sid);
            attDetail.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            if (dgvStudentList.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataGridViewRow row = dgvStudentList.SelectedRows[0];
            string sid = row.Cells[0].Value.ToString();
            RecordAttendanceDialog record = new RecordAttendanceDialog();
            record.lbName.Text = row.Cells[1].Value.ToString();
            record.ShowDialog();
        }
    }
}
