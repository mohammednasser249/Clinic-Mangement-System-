using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayerWindeowsForm.UserControls;
namespace PresentationLayerWindeowsForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            UC_DashBoard uc = new UC_DashBoard();
            _AddUserControl(uc);
        }

        private void _AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainPanelContainer.Controls.Clear();
            MainPanelContainer.Controls.Add(userControl);
            userControl.BringToFront();


        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Cursor = Cursors.Hand;
            UC_DashBoard uc = new UC_DashBoard();
            _AddUserControl(uc);
        }
        private void guna2Button2_Click1(object sender, EventArgs e)
        {
         
        }
        

        private void pbCloseMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Button3.Cursor = Cursors.Hand;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Button4.Cursor = Cursors.Hand;

        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.FromArgb(30,170,231);
        }

        private void guna2Button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.Transparent;

        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            guna2Button2.Cursor = Cursors.Hand;
            UC_Paitents uc = new UC_Paitents();
            _AddUserControl(uc);
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            UC_Doctors uc = new UC_Doctors();
            _AddUserControl(uc);
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            UC_Appointments uc = new UC_Appointments();
            _AddUserControl(uc);
        }
    }
}
