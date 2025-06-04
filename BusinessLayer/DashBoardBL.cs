using System;
using System.Data;
using System.Data.SqlClient;
using DataLayer;

namespace BusinessLayer
{
    public class clsDashBoardBL
    {

        public int TotalPatinets {  get; set; }
        public int AppointementsToda {  get; set; }


        clsDashBoardBL() { }    
        public static int GetTotalPaitents ()
        {

            return clsDashBoardDL.GetTotalPaitentsDb ();

        }


        public static DataTable GetUppcomingAppointementsBL()
        {
            return clsDashBoardDL.GetUppcomingAppointementsDL();

        }

        public static int GetPendingPaymentsBL()
        {
            return clsDashBoardDL.GetPendingPaymentsDL();
        }

        public static int GetTodaysAppointementsBL()
        {
            return clsDashBoardDL.GetTodaysAppointementsDL ();
        }

    }
}
