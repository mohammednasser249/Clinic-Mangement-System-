namespace PresentationLayerWindeowsForm
{
    partial class frmMakeAnappointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMakeAnappointment));
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DPDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPaitentID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoctorsName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPaitentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNum2ber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Status :";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Location = new System.Drawing.Point(183, 496);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(200, 48);
            this.guna2Button1.TabIndex = 68;
            this.guna2Button1.Text = "Save";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DPDateOfBirth
            // 
            this.DPDateOfBirth.BorderColor = System.Drawing.Color.White;
            this.DPDateOfBirth.BorderRadius = 10;
            this.DPDateOfBirth.Checked = true;
            this.DPDateOfBirth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.DPDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DPDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.DPDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DPDateOfBirth.Location = new System.Drawing.Point(170, 410);
            this.DPDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateOfBirth.Name = "DPDateOfBirth";
            this.DPDateOfBirth.Size = new System.Drawing.Size(274, 31);
            this.DPDateOfBirth.TabIndex = 67;
            this.DPDateOfBirth.Value = new System.DateTime(2025, 6, 2, 13, 16, 43, 937);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 66;
            this.label7.Text = "Date Of Birth";
            // 
            // lbPaitentID
            // 
            this.lbPaitentID.AutoSize = true;
            this.lbPaitentID.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaitentID.Location = new System.Drawing.Point(247, 133);
            this.lbPaitentID.Name = "lbPaitentID";
            this.lbPaitentID.Size = new System.Drawing.Size(43, 23);
            this.lbPaitentID.TabIndex = 59;
            this.lbPaitentID.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "Appointment ID :";
            // 
            // txtDoctorsName
            // 
            this.txtDoctorsName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorsName.DefaultText = "";
            this.txtDoctorsName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoctorsName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoctorsName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoctorsName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoctorsName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoctorsName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDoctorsName.ForeColor = System.Drawing.Color.Black;
            this.txtDoctorsName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoctorsName.Location = new System.Drawing.Point(183, 257);
            this.txtDoctorsName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDoctorsName.Name = "txtDoctorsName";
            this.txtDoctorsName.PlaceholderText = "";
            this.txtDoctorsName.SelectedText = "";
            this.txtDoctorsName.Size = new System.Drawing.Size(276, 32);
            this.txtDoctorsName.TabIndex = 57;
            // 
            // txtPaitentName
            // 
            this.txtPaitentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaitentName.DefaultText = "";
            this.txtPaitentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaitentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaitentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaitentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaitentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaitentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaitentName.ForeColor = System.Drawing.Color.Black;
            this.txtPaitentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaitentName.Location = new System.Drawing.Point(183, 190);
            this.txtPaitentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaitentName.Name = "txtPaitentName";
            this.txtPaitentName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPaitentName.PlaceholderText = "";
            this.txtPaitentName.SelectedText = "";
            this.txtPaitentName.Size = new System.Drawing.Size(276, 32);
            this.txtPaitentName.TabIndex = 56;
            // 
            // txtPhoneNum2ber
            // 
            this.txtPhoneNum2ber.AutoSize = true;
            this.txtPhoneNum2ber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum2ber.Location = new System.Drawing.Point(5, 260);
            this.txtPhoneNum2ber.Name = "txtPhoneNum2ber";
            this.txtPhoneNum2ber.Size = new System.Drawing.Size(144, 25);
            this.txtPhoneNum2ber.TabIndex = 55;
            this.txtPhoneNum2ber.Text = "Doctor Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Paitent Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(468, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(206, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(183, 328);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(184, 36);
            this.guna2ComboBox1.TabIndex = 73;
            // 
            // frmMakeAnappointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 582);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DPDateOfBirth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPaitentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoctorsName);
            this.Controls.Add(this.txtPaitentName);
            this.Controls.Add(this.txtPhoneNum2ber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMakeAnappointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMakeAnappointment";
            this.Load += new System.EventHandler(this.frmMakeAnappointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DPDateOfBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPaitentID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDoctorsName;
        private Guna.UI2.WinForms.Guna2TextBox txtPaitentName;
        private System.Windows.Forms.Label txtPhoneNum2ber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}