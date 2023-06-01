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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            dgvRoom.Rows.Clear();
            foreach(Dictionary<string,string> r in DataStore.rooms)
            {
                dgvRoom.Rows.Add(r["id"], r["name"], r["type"], r["floor"], r["createAt"], r["updateAt"]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dgvRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rows selected!");
                return;
            }
            DataGridViewRow row = dgvRoom.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            RoomDialog rDialog = new RoomDialog();
            rDialog.Text = "Update";
            rDialog.btnCreate.Text = "Update";
            rDialog.txtName.Text = row.Cells[1].Value.ToString();
            rDialog.cbType.SelectedItem = row.Cells[2].Value.ToString();
            rDialog.cbFloor.SelectedItem = row.Cells[3].Value.ToString();

            DialogResult result = rDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                foreach(Dictionary<string,string> r in DataStore.rooms)
                {
                    string rId = r["id"];
                    if(rId == id)
                    {
                        r["name"] = rDialog.txtName.Text.Trim();
                        r["type"] = rDialog.cbType.Text;
                        r["floor"] = rDialog.cbFloor.Text;
                        r["updateAt"] = DateTime.Now.ToString();

                        //update ui
                        RoomForm_Load(null, null);

                        break;
                    }
                }
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            RoomDialog rDialog = new RoomDialog();
            DialogResult result = rDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                long id = -1;
                foreach(Dictionary<string,string> r in DataStore.rooms)
                {
                    long rId = long.Parse(r["id"]);
                    if(id < rId)
                    {
                        id = rId;
                    }
                }
                Dictionary<string, string> room = new Dictionary<string, string>()
                {
                    {"id",(++id).ToString() },
                    {"name",rDialog.txtName.Text.Trim() },
                    {"type",rDialog.cbType.Text },
                    {"floor",rDialog.cbFloor.Text },
                    {"createAt",DateTime.Now.ToString() },
                    {"updateAt","" }
                };

                //update list rooms
                DataStore.rooms.Add(room);

                RoomForm_Load(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataGridViewRow row = dgvRoom.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{row.Cells[1].Value.ToString()}' room?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result != DialogResult.Yes)
            {
                return;
            }
            foreach(Dictionary<string,string> r in DataStore.rooms)
            {
                if(id == r["id"])
                {
                    DataStore.rooms.Remove(r);

                    //update ui
                    RoomForm_Load(null, null);
                    break;
                }
            }
        }
    }
}
