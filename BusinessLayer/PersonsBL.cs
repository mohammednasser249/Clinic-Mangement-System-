using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;
using Data_Layer;
using DataLayer;

namespace BusinessLayer
{

    public class clsPerson
    {

        public int PersonID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public static clsPerson FindPeronsByID(int id)
        {
            string Name = "", PhoneNumber = "", Email = "", Address = "";
            string Gender = "";
            DateTime DOB = new DateTime();

            if (clsPeronsDL.FindPeronsByIDDB(id, ref Name, ref DOB, ref Gender, ref PhoneNumber, ref Email, ref Address))
            {
                return new clsPerson(id, Name, DOB, Gender, PhoneNumber, Email, Address);
            }
            else
                return null;

        }

        public clsPerson(int id, string name, DateTime DOB, string gender, string phonenumber, string email, string address)
        {

            this.PersonID = id;
            this.Name = name;
            this.Gender = gender;
            this.DateOfBirth = DOB;
            this.PhoneNumber = phonenumber;
            this.Email = email;
           this.Address = address;
        }

        public clsPerson()
        {
            this.PersonID = 0;
            this.Name = "";
            this.Gender = "";
            this.DateOfBirth =new DateTime();
            this.PhoneNumber = "";
            this.Email = "";
            this.Address = "";
        }

    


    }

  

}
