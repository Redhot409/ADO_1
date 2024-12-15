using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Console.WriteLine(connectionString);
            Console.WriteLine("\n----------------------------------------------------------------\n");

            SqlConnection connection = new SqlConnection(connectionString);
            string cmd = "SELECT * FROM Authors";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();

            SqlDataReader reader=command.ExecuteReader();
            const int padding = 20;
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i).PadRight(padding));
            
            }


            Console.WriteLine();


            if (!reader.IsClosed)
            {
                while (reader.Read())
                { 
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i].ToString().PadRight(padding));
                    }
                    Console.WriteLine() ;
                }
            }

            reader.Close();
            connection.Close();
            Console.WriteLine("\n------------------------------------------------------------------------\n");

            SqlConnection connection_1 = new SqlConnection(connectionString);
            string cmd_1 = "SELECT * FROM Books";
            SqlCommand command_1 = new SqlCommand(cmd_1, connection_1);
            connection_1.Open();

            SqlDataReader reader_1 = command_1.ExecuteReader();
            const int padding_1 = 28;
            for (int i = 0; i < reader_1.FieldCount; i++)
            {
                Console.Write(reader_1.GetName(i).PadRight(padding_1));
            }
                Console.WriteLine();


            if (!reader_1.IsClosed)
            {
                while (reader_1.Read())
                {
                    for (int i = 0; i < reader_1.FieldCount; i++)
                    {
                        Console.Write(reader_1[i].ToString().PadRight(padding_1));
                    }
                    Console.WriteLine();
                }
            }

            reader_1.Close();
            connection_1.Close();
            Console.WriteLine("\n-----------------------------------------------------------------------\n");

        }
    }
}
