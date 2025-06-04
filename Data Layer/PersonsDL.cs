
using System.Data;
using System;
using System.Data.SqlClient;
using DataLayer;

namespace DataLayer
{
    public class clsPeronsDL
    {




        public static bool FindPeronsByIDDB(int ID, ref string Name, ref DateTime DOB, ref string Gender, ref string PhoneNumber, ref string Email, ref string Address)
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = "select * from Persons where PersonID=@ID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ID", ID);

            bool isfound = false;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Name = (string)reader["Name"];
                    DOB = (DateTime)reader["DateOfBirth"];
                    Gender = (string)reader["Gender"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    isfound = true;
                }
                reader.Close();

            } catch (Exception ex) {

                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return isfound;
        }


        public static int AddPersonDL(string Name, DateTime DOB, string Gender, string PhoneNumber, string Email, string Address)
        {

            SqlConnection con = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = @"
    INSERT INTO Persons (Name, DateOfBirth, Gender, PhoneNumber, Email, Address)
    VALUES (@Name, @DOB, @Gender, @PhoneNumber, @Email, @Address);
    SELECT SCOPE_IDENTITY();";


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Address", Address);

            int insertedId = 0;
            try
            {
                con.Open();

                object result = cmd.ExecuteScalar();

                if (result!=null && int.TryParse(result.ToString(),out int InsertedID ))
                {
                    insertedId = InsertedID;
                }




            } catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }
            finally
            {
                con.Close();
            }

          return insertedId;
        }



        

    }

    public class progam
    {
        static void Main(string[] args)
        {

        }
    }
}
