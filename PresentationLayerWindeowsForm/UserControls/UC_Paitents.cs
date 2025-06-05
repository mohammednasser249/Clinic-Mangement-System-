using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayerWindeowsForm.UserControls
{
    public partial class UC_Paitents : UserControl
    {

        private void _RefresehPaitents()
        {

            dataGridView4.DataSource = clsPaitentsBL.GetAllPaitents();
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
            lbTotalPaitents.Text = "Total:" + dataGridView4.RowCount;

        }

        private void _RefreshAllMalePaitents()
        {
            dataGridView4.DataSource = clsPaitentsBL.GetAllMalePatients();
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
            lbTotalPaitents.Text = "Total:" + dataGridView4.RowCount;


        }

        private void _RefreshAllFemalePaitents()
        {
            dataGridView4.DataSource = clsPaitentsBL.GetAllFemalePatients();
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
            lbTotalPaitents.Text = "Total:" + dataGridView4.RowCount;


        }

        private void _FillComboBox()
        {

            guna2ComboBox1.Items.Add("All Gender");
            guna2ComboBox1.Items.Add("Male");
            guna2ComboBox1.Items.Add("Female");
            guna2ComboBox1.SelectedIndex = 0;

        }
        public UC_Paitents()
        {
            InitializeComponent();
            _FillComboBox();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem.ToString() == "All Gender")
            {
                _RefresehPaitents();

            }else if(guna2ComboBox1.SelectedItem.ToString() == "Male")
            {
                _RefreshAllMalePaitents();
            }
            else
            {
                _RefreshAllFemalePaitents();

            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(
        "Are you sure you want to delete contact [ " + dataGridView4.CurrentRow.Cells[5].Value + " ]?",
        "Confirm Deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               if(clsPaitentsBL.Delete((int)dataGridView4.CurrentRow.Cells[5].Value))
                {
                    MessageBox.Show("Paitent has been deleted Succssfully");
                    _RefresehPaitents();
                    lbTotalPaitents.Text = "Total:" + clsDashBoardBL.GetTotalPaitents().ToString();

                }
                else
                {
                    MessageBox.Show("Paitent has not been deleted ");

                }
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewPaitent(-1);
            frm.ShowDialog();
             _RefresehPaitents();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewPaitent((int)dataGridView4.CurrentRow.Cells[5].Value);
            frm.ShowDialog();
            _RefresehPaitents();
        }

        private void dataGridView4_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Paitents_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
