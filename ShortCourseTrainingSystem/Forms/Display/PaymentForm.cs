using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCourseTrainingSystem.Forms
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
        }

        private string getStudentName(string stId)
        {
            foreach(Dictionary<string,string> s in DataStore.students)
            {
                if(stId == s["id"])
                {
                    return s["name"];
                }
            }
            return "";
        }

        private string getCourseName(string cId)
        {
            foreach(Dictionary<string,string> c in DataStore.courses)
            {
                if(cId == c["id"])
                {
                    return c["name"];
                }
            }
            return "";
        }

        private string getRoomName(string rId)
        {
            foreach (Dictionary<string, string> r in DataStore.rooms)
            {
                if (rId == r["id"])
                {
                    return r["name"];
                }
            }
            return "";
        }

        private string getClassName(string cId)
        {
            foreach (Dictionary<string, string> c in DataStore.classes)
            {
                if (cId == c["id"])
                {
                    return getCourseName(c["courseId"]) + " " + getRoomName(c["roomId"]) + " " + c["time"];
                }
            }
            return "";
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            dgvPayment.Rows.Clear();
            foreach(Dictionary<string,string> p in DataStore.payments)
            {
                dgvPayment.Rows.Add(p["id"], getStudentName(p["stId"]), getClassName(p["classId"]), p["price"], p["discount"], p["paidAt"], p["rep"]);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printed");
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPayment.Rows.Clear();
            
            if (cbFilter.SelectedIndex == 0)
            {
                //all
                PaymentForm_Load(null, null);
                return;
            }
            if (cbFilter.SelectedIndex == 1)
            {
                //This year
                foreach(Dictionary<string,string> p in DataStore.payments)
                {
                    int paidAt = DateTime.Parse(p["paidAt"]).Year;
                    if(paidAt == DateTime.Now.Year)
                    {
                        dgvPayment.Rows.Add(p["id"], getStudentName(p["stId"]), getClassName(p["classId"]), p["price"], p["discount"], p["paidAt"], p["rep"]);
                    }
                }
                return;
            }
            if (cbFilter.SelectedIndex == 2)
            {
                //this month
                foreach (Dictionary<string, string> p in DataStore.payments)
                {
                    int paidAt = DateTime.Parse(p["paidAt"]).Month;
                    if (paidAt == DateTime.Now.Month)
                    {
                        dgvPayment.Rows.Add(p["id"], getStudentName(p["stId"]), getClassName(p["classId"]), p["price"], p["discount"], p["paidAt"], p["rep"]);
                    }
                }
                return;
            }
            //today
            foreach (Dictionary<string, string> p in DataStore.payments)
            {
                DateTime paidAt = DateTime.Parse(p["paidAt"]);
                if (paidAt.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    dgvPayment.Rows.Add(p["id"], getStudentName(p["stId"]), getClassName(p["classId"]), p["price"], p["discount"], p["paidAt"], p["rep"]);
                }
            }
        }
    }
}
