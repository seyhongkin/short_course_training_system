namespace ShortCourseTrainingSystem.Forms.Dialog
{
    partial class RecordAttendanceDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.dtpAtt = new System.Windows.Forms.DateTimePicker();
            this.cbHasPermission = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(73, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "name";
            // 
            // dtpAtt
            // 
            this.dtpAtt.Location = new System.Drawing.Point(13, 52);
            this.dtpAtt.Name = "dtpAtt";
            this.dtpAtt.Size = new System.Drawing.Size(292, 26);
            this.dtpAtt.TabIndex = 2;
            // 
            // cbHasPermission
            // 
            this.cbHasPermission.AutoSize = true;
            this.cbHasPermission.Location = new System.Drawing.Point(13, 89);
            this.cbHasPermission.Name = "cbHasPermission";
            this.cbHasPermission.Size = new System.Drawing.Size(146, 24);
            this.cbHasPermission.TabIndex = 3;
            this.cbHasPermission.Text = "Have Permission";
            this.cbHasPermission.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 120);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(292, 51);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // RecordAttendanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 181);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbHasPermission);
            this.Controls.Add(this.dtpAtt);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RecordAttendanceDialog";
            this.Text = "RecordAttendanceDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.Button btnSubmit;
        public System.Windows.Forms.CheckBox cbHasPermission;
        public System.Windows.Forms.DateTimePicker dtpAtt;
    }
}