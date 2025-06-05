using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Data_Layer;
using System.Data;

namespace BusinessLayer
{
    public class clsDoctrosBL : clsPerson
    {

        enum enMode
        {
            AddNew,
            Update
        }

        enMode _Mode;

        public int DocID { get; set; }  
        public string Specilization { get; set; }

        private clsDoctrosBL(int DocID , string Specilization, int id, string name, DateTime DOB, string gender, string phonenumber, string email, string address)
            :base( id,  name,  DOB,  gender,  phonenumber,  email,  address)
        {
            this.DocID = DocID;
            this.Specilization = Specilization;
            _Mode = enMode.Update;
        }

       public clsDoctrosBL()
        {
            this.DocID = -1;
            this.Specilization = " ";
            _Mode= enMode.AddNew;
        }

        private bool AddNewDoctor()
        {

            // will get an address of a new person that is a doctor then i will store it in data base after link it 
            int PersonID = clsPeronsDL.AddPersonDL(this.Name,this.DateOfBirth,this.Gender,this.PhoneNumber,this.Email,this.Address);

            if(PersonID>0)
            {
                clsDoctorsDL.AddNewDoctorDL(this.Specilization, PersonID);
                return true;
            }
            return false;

        }


        private bool _UpdateDoctor()
        {
            if (clsDoctorsDL.UpdateDoctorDL(this.DocID,this.Name, this.DateOfBirth, this.Gender, this.PhoneNumber, this.Email, this.Address))
            {

                return true;
            }
            else
                return false;
        }

        public static DataTable GetAllDoctors()
        {

            return clsDoctorsDL.GetAllDoctorsDL();
        }

        public static DataTable GetAllMaleDoctorsBL()
        {
            return clsDoctorsDL.GetMaleDoctorsDL();
        }
        public static DataTable GetAllFemaleDoctorsBL()
        {
            return clsDoctorsDL.GetFemaleDoctorsDL();
        }


        public static int GetTotalDoctorsBL()
        {
            return clsDoctorsDL.GetTotalDoctorsDL();
        }

        public static clsDoctrosBL Find(int DocID)
        {
            int PersonID = 0;
            string Name = "";
            DateTime DOB = DateTime.Now;
            string Email = "";
            string Gender = "";
            string Address = "";
            string PhoneNumber = "";
            string Specilization = "";

            if (clsDoctorsDL.FindDoctorDL(DocID, ref Specilization, ref PersonID, ref Name, ref DOB, ref Gender, ref PhoneNumber, ref Email, ref Address))
            {
                return new clsDoctrosBL(DocID, Specilization, PersonID, Name, DOB, Gender, PhoneNumber, Email, Address);
            }
            else
                return null;

        }

        public bool Save()
        {

            switch(_Mode)
            {
                case enMode.AddNew:
                   if(AddNewDoctor())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    break;
                  case enMode.Update:
                    return _UpdateDoctor();


            }
            return false;
        }



        public static int GetDoctorIDByName(string Name)
        {
            if (clsDoctorsDL.GetDoctorIDByName(Name) != 0)
            {
                return clsDoctorsDL.GetDoctorIDByName(Name);
            }
            else
                return 0;
        }


    }
}
