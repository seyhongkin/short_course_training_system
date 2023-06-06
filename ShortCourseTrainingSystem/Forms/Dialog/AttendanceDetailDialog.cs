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

        public AttendanceDetailDialog()
        {
            InitializeComponent();
        }
        public AttendanceDetailDialog(string cId, string stId)
        {
            InitializeComponent();
            this.cId = cId;
            this.sId = stId;
        }

        private List<Dictionary<string, string>> getAttendance(string cid, string sid)
        {
            List<Dictionary<string, string>> listAtt = new List<Dictionary<string, string>>();
            foreach (Dictionary<string, string> a in DataStore.attendance)
            {
                if (cId == a["classId"] && sId == a["stId"])
                {
                    listAtt.Add(a);
                }
            }
            return listAtt;
        }


        private void AttendanceDetailDialog_Load(object sender, EventArgs e)
        {
            if(sId == null || cId == null)
            {
                long tAttId = 0;
                foreach(Dictionary<string,string> tAtt in DataStore.teacherAttendance)
                {
                    dgvAttDetail.Rows.Add(++tAttId, tAtt["date"], tAtt["hasPermission"] == "t" ? false : true, tAtt["hasPermission"] == "t" ? true : false);
                }
                return;
            }   
            int id = 0;
            foreach (Dictionary<string, string> a in DataStore.attendance)
            {
                if (cId == a["classId"] && sId == a["stId"])
                {
                    dgvAttDetail.Rows.Add(++id, a["date"], a["hasPermission"] == "t" ? false : true, a["hasPermission"] == "t" ? true : false);
                }
            }
            
        }
    }
}
