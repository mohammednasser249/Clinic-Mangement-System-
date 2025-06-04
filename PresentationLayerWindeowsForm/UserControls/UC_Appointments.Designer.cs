namespace PresentationLayerWindeowsForm.UserControls
{
    partial class UC_Appointments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Appointments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbTotaAppintments = new System.Windows.Forms.Label();
            this.DashBoard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(10, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 49);
            this.label2.TabIndex = 17;
            this.label2.Text = "Appointments";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.guna2ComboBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1206, 72);
            this.panel3.TabIndex = 16;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(653, 14);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(206, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Make Appointment";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(355, 19);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(253, 36);
            this.guna2ComboBox1.TabIndex = 0;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2GradientPanel1);
            this.panel1.Controls.Add(this.DashBoard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 50);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.Controls.Add(this.lbTotaAppintments);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(206, 11);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(105, 31);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // lbTotaAppintments
            // 
            this.lbTotaAppintments.AutoSize = true;
            this.lbTotaAppintments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.lbTotaAppintments.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotaAppintments.Location = new System.Drawing.Point(8, 5);
            this.lbTotaAppintments.Name = "lbTotaAppintments";
            this.lbTotaAppintments.Size = new System.Drawing.Size(0, 21);
            this.lbTotaAppintments.TabIndex = 0;
            // 
            // DashBoard
            // 
            this.DashBoard.AutoSize = true;
            this.DashBoard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.DashBoard.Location = new System.Drawing.Point(14, 11);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Size = new System.Drawing.Size(169, 27);
            this.DashBoard.TabIndex = 0;
            this.DashBoard.Text = "Appointments";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 347);
            this.panel2.TabIndex = 18;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.GridColor = System.Drawing.Color.White;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1206, 347);
            this.dataGridView4.TabIndex = 1;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // UC_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_Appointments";
            this.Size = new System.Drawing.Size(1206, 701);
            this.Load += new System.EventHandler(this.UC_Appointments_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lbTotaAppintments;
        private System.Windows.Forms.Label DashBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}
