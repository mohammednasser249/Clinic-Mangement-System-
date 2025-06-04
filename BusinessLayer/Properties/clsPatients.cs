using Data_Layer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Properties
{
    public class clsPatients : clsPerson
    {
        public int PaitentID { get; set; }


        public clsPatients(int PaitentID, int id, string name, DateTime DOB, string gender, string phonenumber, string email, string address) :
            base(id,  name,  DOB,  gender,  phonenumber,  email,  address)
        {

            this.PaitentID = PaitentID;
            this.PersonID = id;
            this.Name = name;
            this.Gender = gender;
            this.DateOfBirth = DOB;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.Address = address;




        }

        public static clsPatients FindPaitentByID(int Pid)
        {
            int id =0;
            string Name = "", PhoneNumber = "", Email = "", Address = "";
            string Gender = "";
            DateTime DOB = new DateTime();

            if (clsPaitentDL.FindPaitentByID(Pid,ref id, ref Name, ref DOB, ref Gender, ref PhoneNumber, ref Email, ref Address))
            {
                return new clsPatients(Pid,id, Name, DOB, Gender, PhoneNumber, Email, Address);
            }
            else
                return null;

        }



    }
}
