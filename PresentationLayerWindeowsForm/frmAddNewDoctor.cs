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

namespace PresentationLayerWindeowsForm
{
    public partial class frmAddNewDoctor : Form
    {

        enum enMode
        {
            AddNew,
            Update
        }

        enMode _Mode;

        clsDoctrosBL Doctor;

        int DID = 0;
        public frmAddNewDoctor(int DoctorID)
        {
            InitializeComponent();
            DID = DoctorID;
            if (DID == -1)
            {
                _Mode = enMode.AddNew;
            }else
                _Mode = enMode.Update;
        }

        private void FillComboBox()
        {
            guna2ComboBox1.Items.Add("M");
            guna2ComboBox1.Items.Add("F");
            guna2ComboBox1.SelectedIndex = 0;

        }
        private void frmAddNewDoctor_Load(object sender, EventArgs e)
        {
            FillComboBox();
            _LoadData();

        }

        private void _LoadData()
        {

            if(_Mode==enMode.AddNew)
            {
              Doctor= new clsDoctrosBL();
              return;
            }

            Doctor = clsDoctrosBL.Find(DID);

            if (Doctor == null)
            {
                MessageBox.Show("This form will be closed because No Doctor with this ID");
                this.Close();
                return;
            }

            txtName.Text = Doctor.Name;
            txtAddress.Text = Doctor.Address;
            guna2ComboBox1.SelectedItem = Doctor.Gender;
            DPDateOfBirth.Value = Doctor.DateOfBirth;
            txtPhoneNumber.Text = Doctor.PhoneNumber;
            txtSpecilization.Text = Doctor.Specilization;
            txtEmail.Text = Doctor.Email;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Doctor.Name = txtName.Text;
            Doctor.Address = txtAddress.Text;
            Doctor.Gender =guna2ComboBox1.SelectedItem.ToString();
            Doctor.DateOfBirth = DPDateOfBirth.Value;
            Doctor.PhoneNumber = txtPhoneNumber.Text;
            Doctor.Specilization = txtSpecilization.Text;
            Doctor.Email = txtEmail.Text;

            if(Doctor.Save())
            {
                MessageBox.Show("New Doctor has been saved succssfully");
                
            }
            else
            {
                MessageBox.Show("Doctor has failed to be saved :-(");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
