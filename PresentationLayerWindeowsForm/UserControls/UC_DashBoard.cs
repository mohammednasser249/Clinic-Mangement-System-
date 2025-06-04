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
    public partial class UC_DashBoard : UserControl
    {
        public UC_DashBoard()
        {
            InitializeComponent();
        }

        // Function to get Upcoming dats 
        private void _GetUpcomingAppointemens()
        {
            DataTable dt = clsDashBoardBL.GetUppcomingAppointementsBL();
            dataGridView4.DataSource    = dt;
            // Suppose your DataGridView is named dataGridView3

            // 1. Set AutoSizeColumnsMode to None so you can control widths manually
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


        }


        private void UC_DashBoard_Load(object sender, EventArgs e)
        {
            _GetUpcomingAppointemens();
            lbTotalPaitnets.Text = clsDashBoardBL.GetTotalPaitents().ToString();
            lbTodaysAppointments.Text=clsDashBoardBL.GetTodaysAppointementsBL().ToString();
            lbPendingPayemnts.Text = clsDashBoardBL.GetPendingPaymentsBL().ToString();  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbTotalPaitnets_Click(object sender, EventArgs e)
        {

        }

        private void lbTodaysAppointments_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
