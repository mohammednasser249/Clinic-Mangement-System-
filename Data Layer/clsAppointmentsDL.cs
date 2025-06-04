using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.SqlClient;
using System.Data;


namespace Data_Layer
{
    public class clsAppointmentsDL
    {


        public static bool Find(int AppId, ref DateTime AppointmentDate, ref string AppointemtnStatus, ref int PaitentID, ref int DoctorID)
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"select *
                    from Appointments
                    where AppointementID=@AppId";

            SqlCommand cmd = new SqlCommand(qurey, conn);

            cmd.Parameters.AddWithValue("@AppId", AppId);
            bool isfound = false;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    AppointmentDate = (DateTime)reader["AppointementDateTime"];
                    AppointemtnStatus = (string)reader["AppointmentStatus"];
                    PaitentID = (int)reader["PaitentID"];
                    DoctorID = (int)reader["DoctorID"];
      
                    isfound = true;

                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                conn.Close();
            }
            return isfound;

        }


        public static DataTable GetALLAppointmentsDL()
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = @"SELECT 
                 PP.Name AS PatientName,
                 PD.Name AS DoctorName,
                 A.AppointementDateTime,
                 A.AppointmentStatus,
                 A.AppointementID
                 FROM 
                 Appointments A
                 JOIN Patients Pa ON A.PaitentID = Pa.PaitentID
                 JOIN Persons PP ON Pa.PersonID = PP.PersonID
                 JOIN Doctors D ON A.DoctorID = D.DoctorID
                 JOIN Persons PD ON D.PersonID = PD.PersonID";
            ;



            SqlCommand cmd = new SqlCommand(query, conn);

            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    dt.Load(reader);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                conn.Close();
            }
            return dt;
        }
        
        public static DataTable GetALLPendingAppointmentsDL()
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = @"SELECT 
                 PP.Name AS PatientName,
                 PD.Name AS DoctorName,
                 A.AppointementDateTime,
                 A.AppointmentStatus,
                 A.AppointementID
                 FROM 
                 Appointments A
                 JOIN Patients Pa ON A.PaitentID = Pa.PaitentID
                 JOIN Persons PP ON Pa.PersonID = PP.PersonID
                 JOIN Doctors D ON A.DoctorID = D.DoctorID
                 JOIN Persons PD ON D.PersonID = PD.PersonID
                  Where AppointmentStatus='Pending'  ";
            ;



            SqlCommand cmd = new SqlCommand(query, conn);

            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    dt.Load(reader);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                conn.Close();
            }
            return dt;
        }

        public static DataTable GetALLCompletedAppointmentsDL()
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = @"SELECT 
                 PP.Name AS PatientName,
                 PD.Name AS DoctorName,
                 A.AppointementDateTime,
                 A.AppointmentStatus,
                 A.AppointementID
                 FROM 
                 Appointments A
                 JOIN Patients Pa ON A.PaitentID = Pa.PaitentID
                 JOIN Persons PP ON Pa.PersonID = PP.PersonID
                 JOIN Doctors D ON A.DoctorID = D.DoctorID
                 JOIN Persons PD ON D.PersonID = PD.PersonID
                  Where AppointmentStatus='Completed'  ";
            ;



            SqlCommand cmd = new SqlCommand(query, conn);

            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    dt.Load(reader);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                conn.Close();
            }
            return dt;
        }


       
        public static bool AddNewAppointemtnDL(DateTime AppointmentDateTime, string AppointmentStatus, int PatientID, int DoctorID)
        {

            bool isadded = false;

            SqlConnection con = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"INSERT INTO Appointments 
                         ( PaitentID, DoctorID,AppointementDateTime, AppointmentStatus) 
                         VALUES ( @PatientID, @DoctorID,@AppointmentDateTime, @AppointmentStatus)";

            SqlCommand cmd = new SqlCommand(qurey, con);

            cmd.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
            cmd.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);

            try
            {
                con.Open();
                int affectedrows = cmd.ExecuteNonQuery();

                if (affectedrows > 0)
                {
                    isadded = true;
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();


            }
            return isadded;




        }



        public static bool UpdateAppoitmentDL(int AppID,DateTime AppointmentDateTime, string AppointmentStatus, int PatientID, int DoctorID)
        {
                SqlConnection con = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"update Appointments
                        set AppointementDateTime =@AppointmentDateTime,
                            AppointmentStatus =@AppointmentStatus,
                            PaitentID = @PatientID,
                            DoctorID=@DoctorID
                            where AppointementID=@AppID;";

            SqlCommand cmd = new SqlCommand(qurey, con);

            cmd.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
            cmd.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);    
            cmd.Parameters.AddWithValue("@PatientID", PatientID);                    
            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);                      
            cmd.Parameters.AddWithValue("@AppID", AppID);

            bool isupdated = false;

            try
            {
                con.Open();
                int affectedrows = cmd.ExecuteNonQuery();
                if (affectedrows > 0)
                {
                    isupdated = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isupdated;
        }

        public static int GetTotalAppointments()
        {
            SqlConnection con = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"select count(*)
                            from Appointments";

            int C = -1;

            SqlCommand cmd = new SqlCommand(@qurey, con);

            try
            {
                object result = cmd.ExecuteScalar();

                if(result!=null && int.TryParse(result.ToString(), out int count))
                {
                    C = count;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(@qurey, ex.Message);
            }
            finally
            {
                con.Close();
            }

            return C;

        }
    }



}
