using System;
using System.Data;
using System.Data.SqlClient;
using Data_Layer;
using DataLayer;

namespace Data_Layer
{
    public class clsLoginDL
    {

        public static bool LogInDB(string username, string password)
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = @"Select Found = 1 from Admin where AdminUserName=@username and AdminPassword=@password";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            bool isFound = false;

            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;

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
            return isFound;


        }
    }
}
