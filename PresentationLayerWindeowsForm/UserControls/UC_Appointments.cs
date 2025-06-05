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
    public partial class UC_Appointments : UserControl
    {
        public UC_Appointments()
        {
            InitializeComponent();
        }


        private void _RefreshAllAppointments()
        {
            dataGridView4.DataSource = clsAppointments.GetAllAppointemtnsBL();
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 2. Calculate the width for each column to fill the DataGridView width equally
            int totalWidth = dataGridView4.ClientSize.Width; // width of DataGridView inside borders
            int colCount = dataGridView4.Columns.Count;
            dataGridView4.Dock = DockStyle.Fill;

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

            lbTotaAppintments.Text = "Total :" + dataGridView4.RowCount;
        }

        private void _RefreshPendingAppointments()
        {
            dataGridView4.DataSource = clsAppointments.GetAllPendingAppointemtnsBL();
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 2. Calculate the width for each column to fill the DataGridView width equally
            int totalWidth = dataGridView4.ClientSize.Width; // width of DataGridView inside borders
            int colCount = dataGridView4.Columns.Count;
            dataGridView4.Dock = DockStyle.Fill;

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
            lbTotaAppintments.Text = "Total :" + dataGridView4.RowCount;

        }

        private void _RefreshCompletedAppointments()
        {
            dataGridView4.DataSource = clsAppointments.GetAllCompletedAppointemtnsBL();
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 2. Calculate the width for each column to fill the DataGridView width equally
            int totalWidth = dataGridView4.ClientSize.Width; // width of DataGridView inside borders
            int colCount = dataGridView4.Columns.Count;
            dataGridView4.Dock = DockStyle.Fill;

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
            lbTotaAppintments.Text = "Total :" + dataGridView4.RowCount;

        }


        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        
        }

        private void _FillComboBox()
        {
            guna2ComboBox1.Items.Add("All");
            guna2ComboBox1.Items.Add("Pending");
            guna2ComboBox1.Items.Add("Completed");

            guna2ComboBox1.SelectedIndex= 0;
        }

        private void UC_Appointments_Load(object sender, EventArgs e)
        {
            _FillComboBox();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmMakeAnappointment(-1);
            frm.ShowDialog();
            _RefreshAllAppointments();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                _RefreshAllAppointments();

            }
            else if (guna2ComboBox1.SelectedIndex == 1)
            {
                _RefreshPendingAppointments();
            }else
                _RefreshCompletedAppointments();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmMakeAnappointment((int)dataGridView4.CurrentRow.Cells[4].Value);
            frm.ShowDialog();
            _RefreshAllAppointments();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to delete this appointemtn ?")==DialogResult.OK))
            {

                if (clsAppointments.Delete((int)dataGridView4.CurrentRow.Cells[4].Value))
                {
                    MessageBox.Show("Appointment has been deleted succssfully");
                    _RefreshAllAppointments();
                }
                else
                    MessageBox.Show("Appointment failed to be deleted");

            }

        }
    }
}

