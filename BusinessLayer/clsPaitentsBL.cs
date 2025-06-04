using System;
using System.Data;
using DataLayer;
using Data_Layer;

namespace BusinessLayer
{
    public class clsPaitentsBL : clsPerson
    {


        enum enMode
        {
            AddNew,
            Update
        }

        enMode Mode;

        public int PaintentID {  get; set; }


        protected clsPaitentsBL(int PaitentID , int id, string name, DateTime DOB, string gender, string phonenumber, string email, string address)
            :base(id,  name,  DOB,  gender,  phonenumber,  email,  address)
        {

            this.PaintentID = PaitentID;
            Mode = enMode.Update;
           
        }

        public static clsPaitentsBL FindPaitentByID(int PaitentID)
        {
            int PersonID = 0;
            string Name = "";
            DateTime DOB = DateTime.Now;
            string Email = "";
            string Gender = "";
            string Address = "";
            string PhoneNumber = "";

            if (clsPaitentDL.FindPaitentByID(PaitentID, ref PersonID, ref Name, ref DOB, ref Gender, ref PhoneNumber, ref Email, ref Address))
            {
                return new clsPaitentsBL(PaitentID, PersonID, Name, DOB, Gender, PhoneNumber, Email, Address);
            }
            else
             return null;
        
        }


        // Get paitent Id to insert an appointment to it later 
        public static int GetPaitentIDByName(string Name)
        {
            if(clsPaitentDL.GetPaitentIDByName(Name)!=0)
            {
                return clsPaitentDL.GetPaitentIDByName(Name);
            }else
                return 0;
        }



        public static DataTable GetAllPaitents()
        {

            return clsPaitentDL.GetAllPaitentsDL();
        }

        public static DataTable GetAllMalePatients()
        {
            return clsPaitentDL.GetAllMalePatientsDL();
        }

        public static DataTable GetAllFemalePatients()
        {
            return clsPaitentDL.GetAllFemalePatientsDL();
        }
        public clsPaitentsBL()
        {
            this.PaintentID = -1;
            this.Mode = enMode.AddNew;
        }

        private bool AddPaitentBL()
        {
            Mode = enMode.AddNew;
            int PersonId = clsPeronsDL.AddPersonDL(Name, DateOfBirth, Gender, PhoneNumber, Email, Address);

            if(PersonId>0)
                {
                // add to pateint table
                clsPaitentDL.AddPaitentDL(PersonId);

                // return true 
                return true;
            }
            return false;
        }


        private bool UpdatePaitentBL()
        {
            if (clsPaitentDL.UpdatePaitentDL(this.PaintentID, this.Name, this.DateOfBirth, this.Gender, this.PhoneNumber,this.Email, this.Address))
            {
                return true;
            }
            return false;
        }
        public bool Save()
        {

            switch(Mode)
            {
                case enMode.AddNew:
                    return AddPaitentBL();

                case enMode.Update:
                    return UpdatePaitentBL();

            }

            return false;
        }

        public static bool Delete(int ID)
        {
            return clsPaitentDL.DeletePaitentDB(ID);
        }

    }
}
