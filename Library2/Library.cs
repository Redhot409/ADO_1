﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Library2
{
    internal class Library
    {
        public static string connectionString = "";
        static  SqlConnection connection = null;
        static readonly string delimeter = "\n--------------------------------\n";
        static Library()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
            connection=new SqlConnection(connectionString);
            Console.WriteLine(connectionString);
        }
        public static void Select(string fields, string tables,string condition="",int padding=20)
        {
            string cmd = $"SELECT {fields} FROM {tables}";
            if (condition.Length > 0) cmd += $"WHERE {condition}";
            cmd += ";";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine(delimeter);
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader.GetName(i).PadRight(padding));
                Console.WriteLine();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i].ToString().PadRight(padding));
                        Console.WriteLine();
                    }
                    Console.WriteLine(delimeter);
                }
            }

            reader.Close();
            connection.Close();
            
        }
        public static void Insert(string table, string fields, string values)
        {
            string cmd = $"INSERT {table}({fields}) VALUES ({values});";
            SqlCommand command = new SqlCommand (cmd, connection);
            connection.Open ();
            command.ExecuteNonQuery();
            connection.Close();
            }
    }
}
