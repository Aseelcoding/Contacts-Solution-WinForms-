using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.XPath;



namespace DataAccess
{
    public static class clsDataAccess
    {
        public static bool Find
    (
    int ID, ref string FirstName, ref string LastName, 
    ref string Email, ref string Phone, ref string Address
    ,ref DateTime DateOfBirth, ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);
            string query = @"select * from Contacts where ContactID= @ContactID;";

            SqlCommand cmd= new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ContactID", ID);


            try 
            {
                connection.Open();

                SqlDataReader reader =cmd.ExecuteReader();

                if (reader.Read()) 
                {
                    IsFound = true;

                    FirstName=(string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CountryID = (int)reader["CountryID"];
                    ImagePath = reader["ImagePath"] is DBNull ? null : ImagePath = reader["ImagePath"].ToString();

                }
                else
                {
                    IsFound=false;
                }
                reader.Close();

            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                IsFound=false;
            }
            finally
            {
                connection.Close();
            }

       return IsFound;

        }
        public static int AddContact(
      string FirstName,  string LastName,  string Email,  string Phone,  string Address
    ,  DateTime DateOfBirth,  int CountryID,  string ImagePath) 
        {
       

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"INSERT INTO [dbo].[Contacts]([FirstName],[LastName],[Email],[Phone],[Address] " +
                ",[DateOfBirth],[CountryID] ,[ImagePath]) VALUES(@FirstName,@LastName" +
                ",@Email,@Phone,@Address ,@DateOfBirth,@CountryID,@ImagePath);  select  scope_Identity()";

            int ID = -1;

            SqlCommand cmd= new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);

            if (ImagePath != null)
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
                
            
         
            try 
            {
               
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null ) 
                int.TryParse(result.ToString() , out ID);

               
               
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateContact(int ID,  string FirstName,  string LastName,
     string Email,  string Phone,  string Address
    ,  DateTime DateOfBirth,  int CountryID,  string ImagePath)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"UPDATE [dbo].[Contacts]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Email] = @Email
      ,[Phone] = @Phone
      ,[Address] = @Address
      ,[DateOfBirth] = @DateOfBirth
      ,[CountryID] = @CountryID
      ,[ImagePath] = @ImagePath
 WHERE ContactID=@ID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);
            if (ImagePath != null)
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }


            try 
            {
                connection.Open();

                int RowAffected=cmd.ExecuteNonQuery();

                if (RowAffected > 0) 
                {
                IsUpdated = true;
                }
                else {  IsUpdated = false; }
            
            }


            catch(Exception ex) {  Console.WriteLine(ex.Message);  } finally { connection.Close(); }

            return IsUpdated;
        }
        public static bool DeleteContact(int ID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"DELETE FROM [dbo].[Contacts]
                             WHERE ContactID=@ID";

            SqlCommand cmd =new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);

            int RowAffected=0;
            try 
            {
                connection.Open() ;
                 RowAffected = cmd.ExecuteNonQuery();

            }

            catch (Exception ex) { Console.WriteLine(ex.Message); } finally { connection.Close(); }

            return (RowAffected > 0);
        }
        public static DataTable ListContacts() 
        {
         DataTable dt= new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);
            string query = @"SELECT * FROM Contacts;";

            SqlCommand cmd=new SqlCommand(query, connection);


            try 
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
            finally {  connection.Close(); }

            return dt;
        }

        public static bool IsContactExist(int ID)
        {
            bool IsFound=false;


            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);
            string query = @"select Found=1 from Contacts where ContactId=@ContactId;";
            SqlCommand cmd=new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ContactId", ID);

            try
            {
                connection.Open();
                object result= cmd.ExecuteScalar();
                if (result != null) { IsFound = true; }

            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return IsFound;
        }
       
        public static int AddCountry(string CountryName,string Code,string PhoneCode) 
        {
            int ID = -1;

            SqlConnection connection =new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"INSERT INTO [dbo].[Countries]
                            ([CountryName]
                         ,[Code]
                            ,[PhoneCode])
                            VALUES
                                @CountryName,
                                @Code,
                                @PhoneCode
 Select SCOPE_IDENTITY()
; ";

            SqlCommand cmd =new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.Parameters.AddWithValue("@PhoneCode", PhoneCode);

            try
            {
                connection.Open();

                object result= cmd.ExecuteScalar();
               if (result != null) 
                { 

                   
                    int.TryParse((string)result, out ID);

                }



            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return ID;
        }
        public static bool UpdateCountry(int ID,string CountryName, string Code, string PhoneCode)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"UPDATE [dbo].[Countries]
                               SET [CountryName] = @CountryName,
                               [Code] = @Code,
                                [PhoneCode] = @PhoneCode,
                            WHERE CountryID=@ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.Parameters.AddWithValue("@PhoneCode", PhoneCode);
            try
            {
                connection.Open();
                int RowAffected=cmd.ExecuteNonQuery(); if (RowAffected > 0) { IsUpdated = true; }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsUpdated;
        }
        public static bool DeleteCountryByID(int ID)
        {
            bool IsDeleted=false;
            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"
DELETE FROM [dbo].[Countries]
      WHERE CountryID=@ID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                int RowAffected = cmd.ExecuteNonQuery(); if (RowAffected > 0) { IsDeleted = true; }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsDeleted;
        }
        public static bool FindCountryByName( ref int  ID,ref string CountryName) 
        {
            bool IsFound = false;
            SqlConnection connection =new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"select * from Countries
                            where CountryName=@CountryName";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["CountryID"];
                    CountryName = (string)reader["CountryName"];

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { connection.Close(); }

            return IsFound;
        }
        public static bool IsCountryExistByName(string CountryName) {
        
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"select Found=1 from Countries
                            where CountryName=@CountryName";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();

              object reader = cmd.ExecuteScalar();
                if (reader != null) { 
                
                    IsFound=true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { connection.Close(); }

            return IsFound;

        }
        public static bool IsCountryExistByID(int ID) 
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);

            string query = @"select Found=1 from Countries
                            where CountryID=@CountryID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CountryID", ID);
            try
            {
                connection.Open();

                object reader = cmd.ExecuteScalar();
                if (reader != null)
                {

                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { connection.Close(); }

            return IsFound;
        }
        public static DataTable ListCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSeetings.connectionString);
            string query = @"select * from Countries;";

            SqlCommand cmd=new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
