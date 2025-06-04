using System;
using System.Data;
using Data_Layer;
using DataLayer;

namespace BusinessLayer
{
    public class clsLoginBL
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public static bool LogIn(string UserName , string Password)
        {

            return  clsLoginDL.LogInDB(UserName , Password);

        }



    }
}
