namespace ShortCourseTrainingSystem
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.miCourse = new System.Windows.Forms.Button();
            this.miDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard1 = new ShortCourseTrainingSystem.Dashboard();
            this.courses1 = new ShortCourseTrainingSystem.Courses();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(274, 610);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.miCourse);
            this.panel1.Controls.Add(this.miDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 217);
            this.panel1.TabIndex = 1;
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
            this.miCourse.Location = new System.Drawing.Point(0, 56);
            this.miCourse.Name = "miCourse";
            this.miCourse.Padding = new System.Windows.Forms.Padding(20, 8, 0, 8);
            this.miCourse.Size = new System.Drawing.Size(274, 56);
            this.miCourse.TabIndex = 2;
            this.miCourse.Text = "          Courses";
            this.miCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.miCourse.UseVisualStyleBackColor = true;
            this.miCourse.Click += new System.EventHandler(this.miCourse_Click);
            this.miCourse.Leave += new System.EventHandler(this.miCourse_Leave);
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
            this.miDashboard.Name = "miDashboard";
            this.miDashboard.Padding = new System.Windows.Forms.Padding(20, 8, 0, 8);
            this.miDashboard.Size = new System.Drawing.Size(274, 56);
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
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(274, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(759, 610);
            this.dashboard1.TabIndex = 1;
            // 
            // courses1
            // 
            this.courses1.AutoSize = true;
            this.courses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courses1.Location = new System.Drawing.Point(274, 0);
            this.courses1.Name = "courses1";
            this.courses1.Size = new System.Drawing.Size(759, 610);
            this.courses1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 610);
            this.Controls.Add(this.courses1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Short Course Training";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button miDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button miCourse;
        private Dashboard dashboard1;
        private Courses courses1;
    }
}

