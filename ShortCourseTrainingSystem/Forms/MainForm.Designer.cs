namespace ShortCourseTrainingSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMenuHighLight = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTabName = new System.Windows.Forms.Label();
            this.pnUser = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.miLogout = new System.Windows.Forms.Button();
            this.miAbout = new System.Windows.Forms.Button();
            this.miProfile = new System.Windows.Forms.Button();
            this.miRoom = new System.Windows.Forms.Button();
            this.miInvoice = new System.Windows.Forms.Button();
            this.miCourse = new System.Windows.Forms.Button();
            this.miStudent = new System.Windows.Forms.Button();
            this.miTeacher = new System.Windows.Forms.Button();
            this.miDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picUser = new OvalPictureBox();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnMenuHighLight);
            this.panel1.Controls.Add(this.miAbout);
            this.panel1.Controls.Add(this.miProfile);
            this.panel1.Controls.Add(this.miRoom);
            this.panel1.Controls.Add(this.miInvoice);
            this.panel1.Controls.Add(this.miCourse);
            this.panel1.Controls.Add(this.miStudent);
            this.panel1.Controls.Add(this.miTeacher);
            this.panel1.Controls.Add(this.miDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 401);
            this.panel1.TabIndex = 1;
            // 
            // pnMenuHighLight
            // 
            this.pnMenuHighLight.BackColor = System.Drawing.Color.White;
            this.pnMenuHighLight.Location = new System.Drawing.Point(0, 5);
            this.pnMenuHighLight.Name = "pnMenuHighLight";
            this.pnMenuHighLight.Size = new System.Drawing.Size(5, 100);
            this.pnMenuHighLight.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.miLogout);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(206, 538);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbTabName);
            this.panel2.Controls.Add(this.pnUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 54);
            this.panel2.TabIndex = 1;
            // 
            // lbTabName
            // 
            this.lbTabName.AutoSize = true;
            this.lbTabName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabName.Location = new System.Drawing.Point(28, 22);
            this.lbTabName.Name = "lbTabName";
            this.lbTabName.Size = new System.Drawing.Size(131, 29);
            this.lbTabName.TabIndex = 1;
            this.lbTabName.Text = "Dashboard";
            // 
            // pnUser
            // 
            this.pnUser.Controls.Add(this.lbUserName);
            this.pnUser.Controls.Add(this.picUser);
            this.pnUser.Controls.Add(this.lbPosition);
            this.pnUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnUser.Location = new System.Drawing.Point(456, 0);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(215, 54);
            this.pnUser.TabIndex = 0;
            // 
            // lbUserName
            // 
            this.lbUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbUserName.Location = new System.Drawing.Point(0, 7);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(149, 20);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "Phol Somnang";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbUserName.Click += new System.EventHandler(this.lbUserName_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbPosition.Location = new System.Drawing.Point(0, 25);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(149, 16);
            this.lbPosition.TabIndex = 5;
            this.lbPosition.Text = "Cashier";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // miLogout
            // 
            this.miLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.miLogout.FlatAppearance.BorderSize = 0;
            this.miLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.miLogout.Image = global::ShortCourseTrainingSystem.Properties.Resources.Vector__3_;
            this.miLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miLogout.Location = new System.Drawing.Point(0, 492);
            this.miLogout.Margin = new System.Windows.Forms.Padding(2);
            this.miLogout.Name = "miLogout";
            this.miLogout.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.miLogout.Size = new System.Drawing.Size(206, 46);
            this.miLogout.TabIndex = 6;
            this.miLogout.Text = "          Logout";
            this.miLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miLogout.UseVisualStyleBackColor = true;
            this.miLogout.Click += new System.EventHandler(this.miLogout_Click);
            // 
            // miAbout
            // 
            this.miAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.miAbout.FlatAppearance.BorderSize = 0;
            this.miAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.miAbout.Image = global::ShortCourseTrainingSystem.Properties.Resources.mdi_about;
            this.miAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miAbout.Location = new System.Drawing.Point(0, 322);
            this.miAbout.Margin = new System.Windows.Forms.Padding(2);
            this.miAbout.Name = "miAbout";
            this.miAbout.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.miAbout.Size = new System.Drawing.Size(206, 46);
            this.miAbout.TabIndex = 5;
            this.miAbout.Text = "          About";
            this.miAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miAbout.UseVisualStyleBackColor = true;
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            this.miAbout.Leave += new System.EventHandler(this.miAbout_Leave);
            // 
            // miProfile
            // 
            this.miProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.miProfile.FlatAppearance.BorderSize = 0;
            this.miProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.miProfile.Image = global::ShortCourseTrainingSystem.Properties.Resources.ic_round_dashboard__1_;
            this.miProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miProfile.Location = new System.Drawing.Point(0, 276);
            this.miProfile.Margin = new System.Windows.Forms.Padding(2);
            this.miProfile.Name = "miProfile";
            this.miProfile.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.miProfile.Size = new System.Drawing.Size(206, 46);
            this.miProfile.TabIndex = 4;
            this.miProfile.Text = "          Profile";
            this.miProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miProfile.UseVisualStyleBackColor = true;
            this.miProfile.Click += new System.EventHandler(this.miProfile_Click);
            this.miProfile.Leave += new System.EventHandler(this.miProfile_Leave);
            // 
            // miRoom
            // 
            this.miRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.miRoom.FlatAppearance.BorderSize = 0;
            this.miRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.miRoom.Image = global::ShortCourseTrainingSystem.Properties.Resources.material_symbols_meeting_room_rounded__1_;
            this.miRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miRoom.Location = new System.Drawing.Point(0, 230);
            this.miRoom.Margin = new System.Windows.Forms.Padding(2);
            this.miRoom.Name = "miRoom";
            this.miRoom.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.miRoom.Size = new System.Drawing.Size(206, 46);
            this.miRoom.TabIndex = 8;
            this.miRoom.Text = "          Rooms";
            this.miRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miRoom.UseVisualStyleBackColor = true;
            this.miRoom.Click += new System.EventHandler(this.miRoom_Click);
            this.miRoom.Leave += new System.EventHandler(this.miRoom_Leave);
            // 
            // miInvoice
            // 
            this.miInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.miInvoice.FlatAppearance.BorderSize = 0;
            this.miInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.miInvoice.Image = global::ShortCourseTrainingSystem.Properties.Resources.iconamoon_invoice_fill;
            this.miInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miInvoice.Location = new System.Drawing.Point(0, 184);
            this.miInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.miInvoice.Name = "miInvoice";
            this.miInvoice.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.miInvoice.Size = new System.Drawing.Size(206, 46);
            this.miInvoice.TabIndex = 7;
            this.miInvoice.Text = "          Invoices";
            this.miInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miInvoice.UseVisualStyleBackColor = true;
            this.miInvoice.Click += new System.EventHandler(this.miInvoice_Click);
            this.miInvoice.Leave += new System.EventHandler(this.miInvoice_Leave);
            // 
            // miCourse
            // 
            this.miCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.miCourse.FlatAppearance.BorderSize = 0;
            this.miCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.miCourse.Image = global::ShortCourseTrainingSystem.Properties.Resources.ic_round_class;
            this.miCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miCourse.Location = new System.Drawing.Point(0, 138);
            this.miCourse.Margin = new System.Windows.Forms.Padding(2);
            this.miCourse.Name = "miCourse";
            this.miCourse.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.miCourse.Size = new System.Drawing.Size(206, 46);
            this.miCourse.TabIndex = 2;
            this.miCourse.Text = "          Courses";
            this.miCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miCourse.UseVisualStyleBackColor = true;
            this.miCourse.Click += new System.EventHandler(this.miCourse_Click);
            this.miCourse.Leave += new System.EventHandler(this.miCourse_Leave);
            // 
            // miStudent
            // 
            this.miStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.miStudent.FlatAppearance.BorderSize = 0;
            this.miStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.miStudent.Image = global::ShortCourseTrainingSystem.Properties.Resources.mdi_account_student;
            this.miStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miStudent.Location = new System.Drawing.Point(0, 92);
            this.miStudent.Margin = new System.Windows.Forms.Padding(2);
            this.miStudent.Name = "miStudent";
            this.miStudent.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.miStudent.Size = new System.Drawing.Size(206, 46);
            this.miStudent.TabIndex = 5;
            this.miStudent.Text = "          Students";
            this.miStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miStudent.UseVisualStyleBackColor = true;
            this.miStudent.Click += new System.EventHandler(this.miStudent_Click);
            this.miStudent.Leave += new System.EventHandler(this.miStudent_Leave);
            // 
            // miTeacher
            // 
            this.miTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.miTeacher.FlatAppearance.BorderSize = 0;
            this.miTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.miTeacher.Image = global::ShortCourseTrainingSystem.Properties.Resources.mdi_teacher__1_;
            this.miTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miTeacher.Location = new System.Drawing.Point(0, 46);
            this.miTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.miTeacher.Name = "miTeacher";
            this.miTeacher.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.miTeacher.Size = new System.Drawing.Size(206, 46);
            this.miTeacher.TabIndex = 6;
            this.miTeacher.Text = "          Teachers";
            this.miTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miTeacher.UseVisualStyleBackColor = true;
            this.miTeacher.Click += new System.EventHandler(this.miTeacher_Click);
            this.miTeacher.Leave += new System.EventHandler(this.miTeacher_Leave);
            // 
            // miDashboard
            // 
            this.miDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.miDashboard.FlatAppearance.BorderSize = 0;
            this.miDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.miDashboard.Image = global::ShortCourseTrainingSystem.Properties.Resources.ri_dashboard_3_fill__1_;
            this.miDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miDashboard.Location = new System.Drawing.Point(0, 0);
            this.miDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.miDashboard.Name = "miDashboard";
            this.miDashboard.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.miDashboard.Size = new System.Drawing.Size(206, 46);
            this.miDashboard.TabIndex = 1;
            this.miDashboard.Text = "          Dashboard";
            this.miDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miDashboard.UseVisualStyleBackColor = true;
            this.miDashboard.Click += new System.EventHandler(this.miDashboard_Click);
            this.miDashboard.Leave += new System.EventHandler(this.miDashboard_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ShortCourseTrainingSystem.Properties.Resources.JONGREAN;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picUser.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picUser.BorderColor2 = System.Drawing.Color.HotPink;
            this.picUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picUser.BorderSize = 2;
            this.picUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUser.GradientAngle = 50F;
            this.picUser.Image = global::ShortCourseTrainingSystem.Properties.Resources.profile;
            this.picUser.Location = new System.Drawing.Point(152, 6);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(40, 40);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 3;
            this.picUser.TabStop = false;
            this.picUser.Click += new System.EventHandler(this.picUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Short Course Training";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button miCourse;
        private System.Windows.Forms.Button miDashboard;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button miProfile;
        private System.Windows.Forms.Button miLogout;
        private System.Windows.Forms.Button miAbout;
        private System.Windows.Forms.Button miStudent;
        private System.Windows.Forms.Button miTeacher;
        private System.Windows.Forms.Button miRoom;
        private System.Windows.Forms.Button miInvoice;
        private OvalPictureBox picUser;
        private System.Windows.Forms.Label lbTabName;
        private System.Windows.Forms.Panel pnMenuHighLight;
    }
}

