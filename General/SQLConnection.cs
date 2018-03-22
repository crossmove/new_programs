using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class SQLConnection
    {
        static void Method()
        {
            //Initial Catalog  = Database Name
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=SSPI";
            string queryString = "Select * from Employee";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "  ");
                    }
                    Console.WriteLine("\r\n");
                }
                reader.Close();
            }
        }
    }
}
