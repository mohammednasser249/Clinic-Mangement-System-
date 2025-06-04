using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerWindeowsForm.UserControls
{
    public partial class UC_Doctors : UserControl
    {

       
        public UC_Doctors()
        {
            InitializeComponent();
        }

        private void _RefreshAllDoctors()
        {
            dataGridView4.DataSource = clsDoctrosBL.GetAllDoctors();
            // 1. Set AutoSizeColumnsMode to None so you can control widths manually
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 2. Calculate the width for each column to fill the DataGridView width equally
            int totalWidth = dataGridView4.ClientSize.Width; // width of DataGridView inside borders
            int colCount = dataGridView4.Columns.Count;

            if (colCount > 0)
            {
                int colWidth = totalWidth / colCount;

                foreach (DataGridViewColumn col in dataGridView4.Columns)
                {
                    col.Width = colWidth;
                }
            }

            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 92, 153);
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView4.EnableHeadersVisualStyles = false;
            lbTotalDoctors.Text = "Total:" + dataGridView4.RowCount.ToString();

        }


        private void _RefreshMaleDoctors()
        {
            dataGridView4.DataSource = clsDoctrosBL.GetAllMaleDoctorsBL();
            // 1. Set AutoSizeColumnsMode to None so you can control widths manually
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 2. Calculate the width for each column to fill the DataGridView width equally
            int totalWidth = dataGridView4.ClientSize.Width; // width of DataGridView inside borders
            int colCount = dataGridView4.Columns.Count;

            if (colCount > 0)
            {
                int colWidth = totalWidth / colCount;

                foreach (DataGridViewColumn col in dataGridView4.Columns)
                {
                    col.Width = colWidth;
                }
            }

            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 92, 153);
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView4.EnableHeadersVisualStyles = false;

            lbTotalDoctors.Text = "Total:" + dataGridView4.RowCount.ToString();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Doctors_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.Items.Add("All Gender");
            guna2ComboBox1.Items.Add("Male");
            guna2ComboBox1.Items.Add("Female");

            guna2ComboBox1.SelectedIndex = 0;


        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (guna2ComboBox1.SelectedIndex == 0)
            {
                _RefreshAllDoctors();

            }
            else if (guna2ComboBox1.SelectedIndex == 1)

            {
                _RefreshMaleDoctors();  
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewDoctor(-1);
            frm.ShowDialog();
            _RefreshAllDoctors();
        }
    }
}
