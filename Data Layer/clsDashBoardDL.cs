using System;
using System.Data;
using System.Data.SqlClient;
using DataLayer;

namespace DataLayer
{
    public class clsDashBoardDL
    {


        public static int GetTotalPaitentsDb()
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = "select count(*) from Patients";

            int total = -1;
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int totalpaitnets))
                {

                    total = totalpaitnets;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return total;

        }

        public static DataTable GetUppcomingAppointementsDL()
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = @"SELECT 
                 PP.Name AS PatientName,
                 PD.Name AS DoctorName,
                 A.AppointementDateTime,
                 A.AppointmentStatus
                 FROM 
                 Appointments A
                 JOIN Patients Pa ON A.PaitentID = Pa.PaitentID
                 JOIN Persons PP ON Pa.PersonID = PP.PersonID
                 JOIN Doctors D ON A.DoctorID = D.DoctorID
                 JOIN Persons PD ON D.PersonID = PD.PersonID
                  Where AppointmentStatus='Pending' ";
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


        public static int GetPendingPaymentsDL()
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = @"select count(*)
                            from Payments
                            where PaymentStatus = 'Pending'";

            SqlCommand cmd = new SqlCommand(query, conn);
            int total = 0;
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    total = (int)result;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            return total;

        }


        public static int GetTodaysAppointementsDL()
        {
            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);
            string qurey = @"SELECT COUNT(*)
 FROM Appointments
WHERE CONVERT(DATE, AppointementDateTime) = CONVERT(DATE, GETDATE()) and AppointmentStatus='Pending'    ;";

            SqlCommand cmd = new SqlCommand(qurey, conn);
            int total = 0;

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    total += (int)result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return total;
        }
    }
}
