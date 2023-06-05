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
    public partial class PaymentDialog : Form
    {
        public PaymentDialog()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (cbPrint.Checked)
            {
                MessageBox.Show("Printing...");
            }
        }

        private string getCoursePrice(string cName)
        {
            foreach (Dictionary<string, string> c in DataStore.courses)
            {
                if (cName == c["name"])
                {
                    return c["price"];
                }
            }
            return "";
        }

        private void addTime()
        {
            cbTime.Items.Clear();
            foreach (Dictionary<string, string> c in DataStore.classes)
            {
                if (getClassName(c["courseId"]) == cbCourse.Text)
                {
                    cbTime.Items.Add(c["time"]);
                }
            }
            if (cbTime.Items.Count > 0)
            {
                cbTime.SelectedIndex = 0;

            }
        }
        private void addTeacher()
        {
            cbTeacher.Items.Clear();
            foreach (Dictionary<string, string> c in DataStore.classes)
            {
                if (getClassName(c["courseId"]) == cbCourse.Text)
                {
                    cbTeacher.Items.Add(getTeacherName(c["teacherId"]));
                }
            }
            if (cbTeacher.Items.Count > 0)
            {
                cbTeacher.SelectedIndex = 0;
            }
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string price = getCoursePrice(cbCourse.Text);
            txtPrice.Text = price;

            addTime();
            addTeacher();
        }
        private string getClassName(string cId)
        {
            foreach (Dictionary<string, string> c in DataStore.courses)
            {
                if (c["id"] == cId)
                {
                    return c["name"];
                }
            }

            return "";
        }

        private string getTeacherName(string tId)
        {
            foreach (Dictionary<string, string> t in DataStore.teachers)
            {
                if (t["id"] == tId)
                {
                    return t["name"];
                }
            }

            return "";
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            string note = txtNote.Text.Trim();
            string returnN = txtPrice.Text.Trim();
            string dis = txtTotal.Text.Trim();
            double outMoneyNote = 0;
            bool isMoney = double.TryParse(note, out outMoneyNote);
            double returnNote = double.Parse(returnN);
            double disPrice = returnNote - double.Parse(dis);

            if (isMoney)
            {
                txtReturn.Text = (outMoneyNote - disPrice).ToString();
            }
        }

        private void PaymentDialog_Load(object sender, EventArgs e)
        {
            foreach (Dictionary<string, string> c in DataStore.courses)
            {
                cbCourse.Items.Add(c["name"]);
            }
            cbCourse.SelectedIndex = 0;

            addTime();

            addTeacher();



            cbDiscount.SelectedIndex = 0;
        }

        private void cbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dis = cbDiscount.Text;
            double disPercent = double.Parse(dis.Remove(dis.Length - 1))/100;
            double price = double.Parse(txtPrice.Text);
            double disPrice = disPercent * price;
            txtTotal.Text = disPrice.ToString();
        }
    }
}
