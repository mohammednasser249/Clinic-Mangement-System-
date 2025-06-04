using System;
using System.Data;
using System.Data.SqlClient;
using DataLayer;

namespace Data_Layer
{
    public class clsDoctorsDL
    {


        public static DataTable GetAllDoctorsDL()
        {

            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"select P.Name,D.Specilization ,P.PhoneNumber,P.Gender,P.Address,P.DateOfBirth,P.Email,D.DoctorID
                        from Persons P , Doctors D
                        where P.PersonID=D.PersonID";

            SqlCommand cmd = new SqlCommand(qurey, conn);

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

        public static DataTable GetMaleDoctorsDL()
        {


            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"select P.Name,D.Specilization ,P.PhoneNumber,P.Gender,P.Address,P.DateOfBirth,P.Email,D.DoctorID
                        from Persons P , Doctors D
                        where P.PersonID=D.PersonID and P.Gender='M'";

            SqlCommand cmd = new SqlCommand(qurey, conn);

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


        public static int GetTotalDoctorsDL()
        {
            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"
                    select count(*)
                    from Doctors";
            SqlCommand cmd = new SqlCommand(qurey, conn);

            int TotalDoctors = -1;

            try
            {
                conn.Open();
                object result = cmd.ExecuteNonQuery();

                if (result != null && int.TryParse(result.ToString(), out int total))
                {
                    TotalDoctors = total;
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
            return TotalDoctors;
        }


        public static bool FindDoctorDL(int DID,ref string Specilization ,ref int ID, ref string Name, ref DateTime DOB, ref string Gender, ref string PhoneNumber, ref string Email, ref string Address)
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"select D.Specilization,P.Name,P.Address,P.DateOfBirth,P.Email,P.Gender,P.PhoneNumber
                    from Doctors D , Persons P
                    where D.PersonID = P.PersonID and D.DoctorID=@DID";

            SqlCommand cmd = new SqlCommand(qurey , conn);
            cmd.Parameters.AddWithValue("@DID", DID);

            bool isfound = false;
            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    Specilization = (string)reader["Specilization"];
                    Name = (string)reader["Name"];
                   // ID= (int)reader["PersonID"];
                    DOB = (DateTime)reader["DateOfBirth"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    Gender = (string)reader["Gender"];



                    isfound = true;
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
            return isfound;



        }



        public static bool AddNewDoctorDL(string Specilization , int PersonID)
        {

            SqlConnection con = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"insert into Doctors (Specilization,PersonID)
                            values (@Specilization,@PersonID)";
            SqlCommand cmd = new SqlCommand(qurey, con);

            cmd.Parameters.AddWithValue("@Specilization", Specilization);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            bool isadded = false;

            try
            {
                con.Open();
                int rowsaffected = cmd.ExecuteNonQuery();

                if (rowsaffected > 0)
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


       public static int GetDoctorIDByName(string name)
        {
            SqlConnection con = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"select DoctorID 
                            from Persons , Doctors
                                where Name =@name and Doctors.PersonID=Persons.PersonID
                                    ";

            int PID = 0;

            SqlCommand cmd = new SqlCommand(qurey, con);

            cmd.Parameters.AddWithValue("@name", name);

            try
            {
                con.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    PID = ID;
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

            return PID;
        }
    

    }
}
