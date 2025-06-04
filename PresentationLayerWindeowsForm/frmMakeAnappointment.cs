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
    public partial class frmMakeAnappointment : Form
    {

        enum enMode
        {
            Addnew,
            Update
        }

        clsAppointments _Appointemnt;

        enMode Mode;

        public frmMakeAnappointment(int ID)
        {
            InitializeComponent();

            if(ID==-1)
                Mode = enMode.Addnew;
            else
                Mode = enMode.Update;
        }

       
        
        private void _FillComboBox()
        {
            guna2ComboBox1.Items.Add("Pending");
            guna2ComboBox1.Items.Add("Completed");

            guna2ComboBox1.SelectedIndex = 0;
            if (Mode == enMode.Addnew) {
                guna2ComboBox1.Enabled = false;

            }

          
        }
        private void frmMakeAnappointment_Load(object sender, EventArgs e)
        {
            _FillComboBox();
            _LoadData();
        }


        private void _LoadData()
        {

            if (Mode == enMode.Addnew)
            {

                _Appointemnt = new clsAppointments();
                return;

            }

            // For update implement it 
            _Appointemnt = clsAppointments.Find();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            int PaitentID = clsPaitentsBL.GetPaitentIDByName(txtPaitentName.Text);
            int DoctorID = clsDoctrosBL.GetDoctorIDByName(txtDoctorsName.Text);

            if(PaitentID ==0 )
            {
                MessageBox.Show("You do not have a pateint with this name ");
                return;
            }

            if(DoctorID == 0)
            {
                MessageBox.Show("You do not have a doctor with this name ");
                return;
            }

            _Appointemnt.PaitentID= PaitentID;
            _Appointemnt.DoctorID= DoctorID;
            _Appointemnt.AppointmentDateTime = DPDateOfBirth.Value;
            _Appointemnt.AppointmentStatus=guna2ComboBox1.SelectedItem.ToString();

            if(_Appointemnt.Save())
            {
                MessageBox.Show("New appointemtn has been made succssfully");
            }else
            {
                MessageBox.Show("Failed to make the New appointemtn");


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

