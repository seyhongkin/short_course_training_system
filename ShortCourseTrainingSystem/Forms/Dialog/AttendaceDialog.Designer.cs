namespace ShortCourseTrainingSystem.Forms.Dialog
{
    partial class AttendaceDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.cbAttType = new System.Windows.Forms.ComboBox();
            this.Detail = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStudentList.Location = new System.Drawing.Point(12, 73);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.RowHeadersVisible = false;
            this.dgvStudentList.RowHeadersWidth = 51;
            this.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentList.Size = new System.Drawing.Size(764, 319);
            this.dgvStudentList.TabIndex = 0;
            // 
            // cbAttType
            // 
            this.cbAttType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttType.FormattingEnabled = true;
            this.cbAttType.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.cbAttType.Location = new System.Drawing.Point(12, 13);
            this.cbAttType.Name = "cbAttType";
            this.cbAttType.Size = new System.Drawing.Size(121, 33);
            this.cbAttType.TabIndex = 1;
            this.cbAttType.SelectedIndexChanged += new System.EventHandler(this.cbAttType_SelectedIndexChanged);
            // 
            // Detail
            // 
            this.Detail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Detail.BackColor = System.Drawing.Color.White;
            this.Detail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Detail.FlatAppearance.BorderSize = 0;
            this.Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detail.Location = new System.Drawing.Point(637, 15);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(138, 42);
            this.Detail.TabIndex = 5;
            this.Detail.Text = "Details";
            this.Detail.UseVisualStyleBackColor = false;
            this.Detail.Click += new System.EventHandler(this.Detail_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttendance.BackColor = System.Drawing.Color.White;
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Location = new System.Drawing.Point(486, 15);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(138, 42);
            this.btnAttendance.TabIndex = 6;
            this.btnAttendance.Text = "Record";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Student Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Absence";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Permission";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Absence";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 170;
            // 
            // AttendaceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 404);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.cbAttType);
            this.Controls.Add(this.dgvStudentList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AttendaceDialog";
            this.Text = "Attendace";
            this.Load += new System.EventHandler(this.AttendaceDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.ComboBox cbAttType;
        private System.Windows.Forms.Button Detail;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}