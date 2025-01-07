using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;


namespace Academy
{
    public partial class MainForm : Form
    {
        string connectionsString;
        SqlConnection connection;
        public MainForm()
        {
            InitializeComponent();
            connectionsString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            MessageBox.Show(this.connectionsString, "Connection string", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection=new SqlConnection(connectionsString);

            LoadStudents();
        }
        void LoadStudents()
        {
            string cmd = "SELECT * FROM Students";
            SqlCommand command=new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader=command.ExecuteReader();

            if (reader.HasRows)
            { 
                DataTable table = new DataTable();
                for (int i=0; i<reader.FieldCount;i++)
                    table.Columns.Add(reader.GetName(i));
                while (reader.Read()) 
                {
                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i];
                    }
                    table.Rows.Add(row);
                }
                dataGridViewStudents.DataSource = table;
            }
            
            reader.Close();
            connection.Close();

        }
    }
}
