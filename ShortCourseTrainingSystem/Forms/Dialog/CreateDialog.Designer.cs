namespace ShortCourseTrainingSystem.Forms.Dialog
{
    partial class CreateDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDialog));
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.txtMonthlyPrice = new System.Windows.Forms.TextBox();
            this.lbMonthlyPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(16, 19);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(64, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(16, 103);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(318, 30);
            this.txtPeriod.TabIndex = 3;
            // 
            // lbPeriod
            // 
            this.lbPeriod.AutoSize = true;
            this.lbPeriod.Location = new System.Drawing.Point(16, 79);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(68, 25);
            this.lbPeriod.TabIndex = 2;
            this.lbPeriod.Text = "Period";
            // 
            // txtMonthlyPrice
            // 
            this.txtMonthlyPrice.Location = new System.Drawing.Point(16, 225);
            this.txtMonthlyPrice.Name = "txtMonthlyPrice";
            this.txtMonthlyPrice.Size = new System.Drawing.Size(318, 30);
            this.txtMonthlyPrice.TabIndex = 7;
            // 
            // lbMonthlyPrice
            // 
            this.lbMonthlyPrice.AutoSize = true;
            this.lbMonthlyPrice.Location = new System.Drawing.Point(16, 201);
            this.lbMonthlyPrice.Name = "lbMonthlyPrice";
            this.lbMonthlyPrice.Size = new System.Drawing.Size(130, 25);
            this.lbMonthlyPrice.TabIndex = 6;
            this.lbMonthlyPrice.Text = "Monthly Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(16, 165);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(318, 30);
            this.txtPrice.TabIndex = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(16, 141);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(56, 25);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(16, 275);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(318, 46);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CreateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 340);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtMonthlyPrice);
            this.Controls.Add(this.lbMonthlyPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.Label lbMonthlyPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtPeriod;
        public System.Windows.Forms.TextBox txtMonthlyPrice;
        public System.Windows.Forms.TextBox txtPrice;
    }
}