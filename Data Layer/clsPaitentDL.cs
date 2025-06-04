using DataLayer;
using System.Data;
using System.Data.SqlClient;
using System;

namespace Data_Layer
{
    public class clsPaitentDL
    {


        

       public static bool FindPaitentByID(int PID,ref int ID, ref string Name, ref DateTime DOB, ref string Gender, ref string PhoneNumber, ref string Email, ref string Address)
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = @"	select Name,DateOfBirth,Gender,PhoneNumber,Email,Address
	from Patients , Persons
	where PaitentID=@PID and Patients.PersonID=Persons.PersonID
";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PID", PID);

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

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return isfound;
        }





        public static DataTable GetAllPaitentsDL()


        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            DataTable dataTable = new DataTable();

            string qurey = @"select P.Name,P.PhoneNumber,P.Email,P.Gender,P.DateOfBirth,Pa.PaitentID
                            from  Patients Pa,Persons P
                            where Pa.PersonID=P.PersonID";
            SqlCommand cmd =new SqlCommand(qurey, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    dataTable.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return dataTable;




        }
        

                    public static DataTable GetAllFemalePatientsDL()
        {
            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            DataTable dataTable = new DataTable();

            string qurey = @"select P.Name,P.PhoneNumber,P.Email,P.Gender,P.DateOfBirth
                                            from  Patients Pa,Persons P
                                       where Pa.PersonID=P.PersonID and Gender='F'";
            SqlCommand cmd = new SqlCommand(qurey, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    dataTable.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return dataTable;



        }


        public static DataTable GetAllMalePatientsDL()
        {
            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            DataTable dataTable = new DataTable();

            string qurey = @"select P.Name,P.PhoneNumber,P.Email,P.Gender,P.DateOfBirth
                                            from  Patients Pa,Persons P
                                       where Pa.PersonID=P.PersonID and Gender='M'";
            SqlCommand cmd = new SqlCommand(qurey, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    dataTable.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return dataTable;



        }


        public static int AddPaitentDL(int ID)
        {
            SqlConnection con = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"insert into Patients
               values (@ID) select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(qurey, con);

            int id = 0;

            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                con.Open();

                object result = cmd.ExecuteScalar();

                if(result!=null && int.TryParse(result.ToString(),out int PAID))
                {
                    id = PAID;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();    
            }

            return id;
        }

        public static bool UpdatePaitentDL(int patientID, string Name, DateTime DOB, string Gender, string PhoneNumber, string Email, string Address)
        {
            using (SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Step 1: Get the PersonID from the Patients table using PatientID
                    int personID;
                    SqlCommand cmdGetPersonID = new SqlCommand(
                        "SELECT PersonID FROM Patients WHERE PaitentID = @PatientID", conn, transaction);
                    cmdGetPersonID.Parameters.AddWithValue("@PatientID", patientID);

                    object result = cmdGetPersonID.ExecuteScalar();
                    if (result == null)
                        throw new Exception("Patient not found");

                    personID = Convert.ToInt32(result);

                    // Step 2: Update the Persons table
                    SqlCommand cmdUpdatePerson = new SqlCommand(
                        @"UPDATE Persons 
                  SET Name = @Name, DateOfBirth = @DOB, Gender = @Gender,
                      PhoneNumber = @PhoneNumber, Email = @Email, Address = @Address
                  WHERE PersonID = @PersonID", conn, transaction);

                    cmdUpdatePerson.Parameters.AddWithValue("@Name", Name);
                    cmdUpdatePerson.Parameters.AddWithValue("@DOB", DOB);
                    cmdUpdatePerson.Parameters.AddWithValue("@Gender", Gender);
                    cmdUpdatePerson.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmdUpdatePerson.Parameters.AddWithValue("@Email", Email);
                    cmdUpdatePerson.Parameters.AddWithValue("@Address", Address);
                    cmdUpdatePerson.Parameters.AddWithValue("@PersonID", personID);

                    cmdUpdatePerson.ExecuteNonQuery();

                    // (Optional) Step 3: Update something in Patients if needed
                    // e.g., update LastVisitDate or status
                    /*
                    SqlCommand cmdUpdatePatient = new SqlCommand(
                        "UPDATE Patients SET LastVisitDate = GETDATE() WHERE PatientID = @PatientID", conn, transaction);
                    cmdUpdatePatient.Parameters.AddWithValue("@PatientID", patientID);
                    cmdUpdatePatient.ExecuteNonQuery();
                    */

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }


        public static bool DeletePaitentDB(int ID)
        {

            SqlConnection conn = new SqlConnection(clsDataBaseSetting.connectionString);

            string query = @"DELETE FROM Persons
WHERE PersonID = (
    SELECT Persons.PersonID
    FROM Persons
    JOIN Patients ON Patients.PersonID = Persons.PersonID
    WHERE Patients.PaitentID = @ID
);";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ID", ID);
            bool isfound = false;
            try
            {
                conn.Open();
                int affectedrows = cmd.ExecuteNonQuery();

                if (affectedrows > 0)
                {
                    isfound = true;
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

            return isfound;
        }


       public static int  GetPaitentIDByName(string name)
        {

            SqlConnection con = new SqlConnection(clsDataBaseSetting.connectionString);

            string qurey = @"select PaitentID 
                            from Persons , Patients
                            where Name =@name and Patients.PersonID=Persons.PersonID";

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

            con.Close(); }
        
        return PID;
        }

    }
}
