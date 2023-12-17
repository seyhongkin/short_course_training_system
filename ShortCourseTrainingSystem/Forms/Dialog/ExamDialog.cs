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
    public partial class ExamDialog : Form
    {
        string stId;
        string cId;
        public ExamDialog()
        {
            InitializeComponent();
        }

        public ExamDialog(string cId, string sId)
        {
            InitializeComponent();
            this.stId = sId;
            this.cId = cId;
        }

        public ExamDialog(string cId)
        {
            InitializeComponent();
            this.cId = cId;
        }

        private Dictionary<string, string> getScore(string studentId)
        {
            foreach (Dictionary<string, string> s in DataStore.score)
            {
                if (s["classId"] == cId && s["stId"] == studentId)
                {
                    return s;
                }
            }
            return null;
        }

        private Dictionary<string, string> getCourse(string courseId)
        {
            foreach (Dictionary<string, string> c in DataStore.courses)
            {
                if (courseId == c["id"])
                {
                    return c;
                }
            }
            return null;
        }
        private char getGrade(double percentage)
        {
            if (percentage > 90)
            {
                return 'A';
            }
            else if (percentage > 70)
            {
                return 'B';
            }
            else if (percentage > 60)
            {
                return 'C';
            }
            return 'F';
        }

        private void ExamDialog_Load(object sender, EventArgs e)
        {
            dgvScore.Rows.Clear();
            foreach (Dictionary<string, string> c in DataStore.payments)
            {
                if (cId == c["classId"])
                {
                    Dictionary<string, string> s = ClassForm.getStudent(c["stId"]);
                    Dictionary<string, string> score = getScore(c["stId"]);
                    double percentage = double.Parse(score["score"]) * 100 / 50;
                    dgvScore.Rows.Add(s["id"], s["name"], score["score"], percentage + "%", getGrade(percentage), percentage > 60 ? "Passed" : "Failed");
                }
            }
        }

        private void dgvScore_SelectionChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Dictionary<string, string> c in DataStore.payments)
            {
                if (cId == c["classId"])
                {
                    Dictionary<string, string> s = ClassForm.getStudent(c["stId"]);
                    if (s["id"] != null)
                    {
                        count++;
                    }
                }
            }
            if (count == 0) return;
            if (dgvScore.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvScore.SelectedRows[0];
                txtScore.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvScore.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = dgvScore.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            double score = double.Parse(txtScore.Text);
            foreach (Dictionary<string, string> sc in DataStore.score)
            {
                if (id == sc["stId"])
                {
                    sc["score"] = score.ToString();
                }
            }

            //update ui
            ExamDialog_Load(null, null);
        }


    }
}
