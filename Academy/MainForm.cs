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

        Dictionary<string, int> d_directions;
        Dictionary<string, int> d_groups;
        public MainForm()
        {
            InitializeComponent();
            connectionsString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            MessageBox.Show(this.connectionsString, "Connection string", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection=new SqlConnection(connectionsString);

           

            LoadStudents();
            LoadGroups();
            //LoadDirections();
            LoadTeachers();

            d_groups = Connector.LoadPair("group_name", "group_id", "Groups");
            d_directions = Connector.LoadPair("direction_name", "direction_id", "Directions");
            LoadDictionaryToComboBox(d_groups, cbStudentsGroup);
            LoadDictionaryToComboBox(d_directions, cbStudentsDirection);
            LoadDictionaryToComboBox(d_directions, cbGroupsDirection);
            
        }
        void LoadStudents()
        {
            #region Loading
            string cmd = "SELECT * FROM Students";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable table = new DataTable();
                for (int i = 0; i < reader.FieldCount; i++)
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
                dgvStudents.DataSource = table;
            }

            reader.Close();
            connection.Close();
            #endregion

            dgvStudents.DataSource = Connector.LoadData
                (
                    "last_name AS N'Фамилия', " +
                    "first_name AS N'Имя', " +
                    "ISNULL(middle_name, N'') AS N'Отчество'," +
                    "CONVERT(NVARCHAR, birth_date, 103) AS N'Дата рождения', " +
                    "DATEDIFF(DAY, birth_date,GETDATE())/365 AS N'Возраст', " +
                    "group_name AS N'Группа'," +
                    "direction_name AS N'Направление обучения'",

                    "Students,Groups,Directions",

                    "[group] = group_id AND direction = direction_id"
                );
            tslStudentsCount.Text = $"Количество студентов: {dgvStudents.RowCount - 1}";
        }
        void LoadGroups()
        { 
            dgvGroups.DataSource = Connector.LoadData
                (
                    "group_id AS ID," +
                    "group_name AS N'Название группы'," +
                    "direction_name AS N'Направление обучения'," +
                    "COUNT(student_id) AS N'Количество студентов'",

                    "Students, Groups, Directions",
                    "direction = direction_id AND [group] = group_id" +
                    " GROUP BY group_id, group_name, direction_name"
                );
            tslGroupCount.Text = $"Количество групп: {dgvGroups.RowCount - 1}";
        }
        //void LoadDirections()
        //{
        //    //DataTable dt_directions = Connector.LoadData("direction_id, direction_name","Directions");
        //    //cbGroupsDirection.Items.AddRange(dt_directions);
        //    d_groups_directions = Connector.LoadPair("direction_name", "direction_id", "Directions");
        //    cbGroupsDirection.Items.AddRange (d_groups_directions.Keys.ToArray());
        //    cbGroupsDirection.Items.Insert(0, "Все");
        //    cbGroupsDirection.SelectedIndex = 0;
            
        //}

        void LoadDictionaryToComboBox(Dictionary<string,int> tree, ComboBox cb)
        {
            cb.Items.Clear();
            //DataTable dt_directions = Connector.LoadData("direction_id, direction_name","Directions");
            //cbGroupsDirection.Items.AddRange(dt_directions);
            //d_groups_directions = Connector.LoadPair("direction_name", "direction_id", "Directions");
            cb.Items.AddRange(tree.Keys.ToArray());
            //cb.Items.Insert(0, "Все");
            cb.SelectedIndex = 0;

        }

        void LoadTeachers()
        {
           dgvTeachers.DataSource = Connector.LoadData
                (
                    "teacher_id as 'ID'," +
                    "last_name AS N'Фамилия', first_name AS N'Имя', " +
                    "ISNULL(middle_name,N'') AS 'Отчество', " +
                    "CONVERT(NVARCHAR, birth_date, 104) AS 'Дата рождения', " +
                    "DATEDIFF(DAY, works_since,GETDATE())/365 AS N'Стаж', " +
                    " rate AS 'Оклад'",
                    "Teachers"

                );
            tslTeachersCount.Text = $"Количество учителей: {dgvTeachers.RowCount - 1}";

        }

        private void cbStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudentsGroup.SelectedIndex == 0) LoadStudents();
            else dgvStudents.DataSource = Connector.LoadData
                (
                    "last_name AS N'Фамилия', " +
                    "first_name AS N'Имя', " +
                    "ISNULL(middle_name, N'') AS N'Отчество'," +
                    "CONVERT(NVARCHAR, birth_date, 103) AS N'Дата рождения', " +
                    "DATEDIFF(DAY, birth_date,GETDATE())/365 AS N'Возраст', " +
                    "group_name AS N'Группа'," +
                    "direction_name AS N'Направление обучения'",
                    "Students,Groups,Directions",
                    $"[group]=group_id AND direction=direction_id AND group_id = {d_groups[cbStudentsGroup.SelectedItem.ToString()]}"
                );
            tslStudentsCount.Text = $"Количество студентов: {(dgvStudents.RowCount > 0 ? dgvStudents.RowCount - 1 : 0)}";
        }

        private void cbStudentsDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbStudentsGroup.SelectedIndex = 0;
            int filterID = cbStudentsDirection == null ? 0 : d_directions[cbStudentsDirection.SelectedItem.ToString()];
            //d_groups = Connector.LoadPair("group_name", "group_id", "Groups", $"direction={filterID}");
            if (filterID == 0)
            {
                d_groups = Connector.LoadPair("group_name", "group_id", "Groups");
                this.LoadDictionaryToComboBox(d_groups, cbStudentsGroup);
                LoadStudents();
            }
                
            else
            {

                d_groups = Connector.LoadPair("group_name", "group_id", "Groups", $"direction={filterID}");
                this.LoadDictionaryToComboBox(d_groups, cbStudentsGroup);
                dgvStudents.DataSource = Connector.LoadData
                (
                    "last_name AS N'Фамилия', " +
                    "first_name AS N'Имя', " +
                    "ISNULL(middle_name, N'') AS N'Отчество'," +
                    "CONVERT(NVARCHAR, birth_date, 103) AS N'Дата рождения', " +
                    "DATEDIFF(DAY, birth_date,GETDATE())/365 AS N'Возраст', " +
                    "group_name AS N'Группа'," +
                    "direction_name AS N'Направление обучения'",
                    "Students,Groups,Directions",
                    $"[group]=group_id AND direction=direction_id AND direction_id = {d_directions[cbStudentsDirection.SelectedItem.ToString()]}"
                );
            }
            tslStudentsCount.Text = $"Количество студентов: {(dgvStudents.RowCount > 0 ? dgvStudents.RowCount - 1 : 0)}";
        }
    }
}
