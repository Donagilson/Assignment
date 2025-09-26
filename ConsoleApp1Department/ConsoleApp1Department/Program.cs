using ClassLibraryDatabaseConnection;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConsoleAppADODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //first useCase -Direct Conection
            Console.WriteLine("Trying to connecting to sql  server Database...");
            // Step1 :Get Connectionstring from App .Config
            string conString = ConfigurationManager.ConnectionStrings["CsWinSql"].ConnectionString.ToString();
            /*
            //step2 : Establish the connection -sqlConnection
            using (SqlConnection connection = new SqlConnection(conString))
            {
                try
                {
                    //step 3: Open the connection
                    connection.Open();
                    Console.WriteLine("Connection Established Successfully..");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while connecting to database:" + ex.Message);
                }
                finally
                {
                    //step 4: ensure the connection is closed
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Connection Closed Successfully..");
                    }
                }
            }
            */




            //Second USeCase -Use dll
            //step2: Establish the connection - sqlConnection
            using (SqlConnection connection = ConnectionManager.OpenConnection(conString))
            {
                try
                {
                    if (connection != null)
                    {
                        Console.WriteLine("Connection Established Successfully");
                        string query = "Select Id,Name,DateofJoin,Salary From Employee";
                    }

                    //creating sqlcommads objects
                    SqlCommand command = new SqlCommand(Queryable, connection);

                    //Executing the sql query
                    SqlDataReader reader = command.ExecuteReader();

                    //looping through each record
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Id"] + " " + reader["Name"] + " " + reader[DateofJoin] 
                            + " " + reader[Salary]);
                        //We can use index of the datareader object.


                    }

                    else
                    {
                        Console.WriteLine("Failed to establish connection check for the console errors");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occured: " + ex.Message);
                }
                finally
                {
                    //Step 4: Ensure to Close the connection
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }

                    Console.WriteLine("Connection Closed");
                }




                //Second USeCase -Use dll
                Console.WriteLine("press any key to exit....");
                Console.ReadKey();
            }
        }
    }
}