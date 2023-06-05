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
    public partial class AttendanceDetailDialog : Form
    {
        string cId;
        string sId;
        public AttendanceDetailDialog(string cId, string stId)
        {
            InitializeComponent();
            this.cId = cId;
            this.sId = stId;
        }

        private Dictionary<string, string> getAttendance(string cid, string sid)
        {
            foreach (Dictionary<string, string> a in DataStore.attendance)
            {
                if (cId == a["classId"] && sId == a["stId"])
                {
                    return a;
                }
            }
            return null;
        }


        private void AttendanceDetailDialog_Load(object sender, EventArgs e)
        {
            int id = 0;
            foreach (Dictionary<string, string> a in DataStore.attendance)
            {
                if (cId == a["classId"] && sId == a["stId"])
                {
                    Dictionary<string, string> att = getAttendance(cId, sId);
                    dgvAttDetail.Rows.Add(++id, att["date"], att["hasPermission"] == "t" ? false : true, att["hasPermission"] == "t" ? true : false);
                }
            }
        }
    }
}
