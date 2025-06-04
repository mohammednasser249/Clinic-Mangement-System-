using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsAppointments
    {

        enum enMode
        {
            AddNew,
            Update
        }

        enMode Mode;
        public int AppointmentID { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string AppointmentStatus { get; set; }
        public int PaitentID {  get; set; } 
        public int DoctorID { get; set; }

   

        // Modify it because i have deleted some of the attribures in the database make sure 



        public clsAppointments(int appointmentID, DateTime appointmentDateTime, string appointmentStatus,
                   int paitentID, int doctorID)
        {
            AppointmentID = appointmentID;
            AppointmentDateTime = appointmentDateTime;
            AppointmentStatus = appointmentStatus;
            PaitentID = paitentID;
            DoctorID = doctorID;
       
            Mode = enMode.Update;
        }

        public static clsAppointments Find(int AppointemtnID)
        {
            DateTime AppointmentDateTime = new DateTime();
            string AppointemtnStatus = "";
            int PaitentID = 0;  
            int DoctorID = 0;
        

            if (clsAppointmentsDL.Find(AppointemtnID,ref AppointmentDateTime,ref AppointemtnStatus,ref PaitentID,ref DoctorID))
            {
                return new clsAppointments(AppointemtnID,AppointmentDateTime,AppointemtnStatus,PaitentID,DoctorID);
            }
            else
                return null;

        }


        public static DataTable  GetAllAppointemtnsBL()
        {

            return clsAppointmentsDL.GetALLAppointmentsDL();

        }


        public static DataTable GetAllPendingAppointemtnsBL()
        {

            return clsAppointmentsDL.GetALLPendingAppointmentsDL();

        }

        public static DataTable GetAllCompletedAppointemtnsBL()
        {

            return clsAppointmentsDL.GetALLCompletedAppointmentsDL();

        }



        public clsAppointments()
        {
            this.AppointmentDateTime = new DateTime();
            this.AppointmentStatus = "";
            this.DoctorID = 0;
            this.PaitentID = 0;
            this.Mode = enMode.AddNew;
            
        }

        public bool AddNewAppointment()
        {

            if (clsAppointmentsDL.AddNewAppointemtnDL(this.AppointmentDateTime, this.AppointmentStatus, this.PaitentID, this.DoctorID))
            {

                return true;
            }
            return false;



        }


       public static int GetTotalAppointments()
        {

            return clsAppointments.GetTotalAppointments();
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    return AddNewAppointment();
            }
            return false;
        }



    }
}
