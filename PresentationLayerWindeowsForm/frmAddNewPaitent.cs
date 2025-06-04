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

namespace PresentationLayerWindeowsForm
{
    public partial class frmAddNewPaitent : Form
    {

        enum enMode
        {
            AddNew,
            Update
        };

        clsPaitentsBL _Paitent;
        int _PaitentID; 
        enMode _Mode;


        public frmAddNewPaitent(int Pid)
        {
            _PaitentID = Pid;
            InitializeComponent();

            if(Pid==-1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmAddNewPaitent_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _FillComboBox()
        {
            guna2ComboBox1.Items.Add("M");
            guna2ComboBox1.Items.Add("F");
            guna2ComboBox1.SelectedIndex = 0;
        }

        private void _LoadData()
        {
            _FillComboBox();

            if(_Mode==enMode.AddNew)
            {
                _Paitent = new clsPaitentsBL();
                return;
            }

            _Paitent = clsPaitentsBL.FindPaitentByID(_PaitentID);

            if (_Paitent == null)
            {
                MessageBox.Show("This form will be closed because No contact with this ID");
                this.Close();
                return;
            }

            lbPaitentID.Text=_PaitentID.ToString();
            txtName.Text=_Paitent.Name;
            txtPhoneNumber.Text=_Paitent.PhoneNumber.ToString();
            txtEmail.Text=_Paitent.Email;
            txtAddress.Text=_Paitent.Address;
            DPDateOfBirth.Value= _Paitent.DateOfBirth;

            guna2ComboBox1.SelectedIndex = guna2ComboBox1.FindString(clsPaitentsBL.FindPaitentByID(_PaitentID).Gender);
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            _Paitent.Name = txtName.Text;
            _Paitent.Email = txtEmail.Text;
            _Paitent.PhoneNumber = txtPhoneNumber.Text;
            _Paitent.Address = txtAddress.Text;
            _Paitent.DateOfBirth = DPDateOfBirth.Value;
            _Paitent.Gender = guna2ComboBox1.SelectedItem.ToString();

            if(_Paitent.Save())
            {
                MessageBox.Show("Data Save Succssfully");
                
            }else
                MessageBox.Show("Error: Data was not Saved");

            _Mode = enMode.Update;
            lbPaitentID.Text = _Paitent.PaintentID.ToString();
        }
    }
}
