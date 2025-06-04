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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayerWindeowsForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "LoginFrom";
            this.AcceptButton= btnLogin;
            txtUserNametxtUserName.Focus();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private bool _Login(string username ,string password)
        {

            if (clsLoginBL.LogIn(username, password))
            {
                return true;
            }else
            {
                return false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (_Login(txtUserNametxtUserName.Text.Trim(), txtPassword.Text.Trim()))
            {
               Form frm = new frmMain();
                frm.ShowDialog();
                this.Close();


            }
            else
                MessageBox.Show("Wrong Username and Password ","Wrong inforamtion ",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
           

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUserNametxtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '*';
        }

        private void txtUserNametxtUserName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
