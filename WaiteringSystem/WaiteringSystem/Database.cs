using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  // Provides core ADO.NET classes
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Provides the data provider for SQL Server

namespace WaiteringSystem
{
    public partial class Database : Form
    {
        // 1. Creating a DataSet to hold data in memory
        DataSet dataset = new DataSet();
        // 2. Defining a SqlConnection to connect to the SQL Server database
        //    Update the connection string to match your database's location and credentials
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=C:\Users\naled\Downloads\ClassExampleCollection\ClassExampleCollection\ClassExampleADO\Events.mdf;
              Integrated Security=True");

        // 3. Creating a SqlDataAdapter to bridge the DataSet and the database
        SqlDataAdapter adapter = new SqlDataAdapter();

        private string table = "Events";  // The table to work with

        public Database()
        {
            InitializeComponent();
        }

        public void setUpEmployeeListView()
        {
            ListViewItem DBListView;

            listViewDb.Columns.Clear();

            listViewDb.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            listViewDb.Columns.Insert(1, "Difficulty", 120, HorizontalAlignment.Left);
            listViewDb.Columns.Insert(2, "Event", 120, HorizontalAlignment.Left);
            listViewDb.Columns.Insert(3, "Type", 120, HorizontalAlignment.Left);
            listViewDb.Columns.Insert(4, "Contact", 120, HorizontalAlignment.Left);

            foreach (DataRow row in dataset.Tables[table].Rows)
            {
                DBListView = new ListViewItem();
                DBListView.Text = row["ID"].ToString();
                DBListView.SubItems.Add(row["Difficulty"].ToString());
                DBListView.SubItems.Add(row["Event"].ToString());
                DBListView.SubItems.Add(row["Type"].ToString());
                DBListView.SubItems.Add(row["Contact"].ToString());

                listViewDb.Items.Add(DBListView);
            }
        }

        private void Database_Load(object sender, EventArgs e)
        {
            dataset.Clear();  // Clears any existing data in the DataSet

            setUpEmployeeListView();
            // 4. Creating a SqlCommand for selecting data from the "Events" table
            SqlCommand sqlSelect = new SqlCommand("SELECT * FROM Events", connection);

            // Assigning the SelectCommand of the adapter to the sqlSelect command
            adapter.SelectCommand = sqlSelect;

            connection.Open();          // Opens the database connection
            adapter.Fill(dataset, table);  // Fills the DataSet with data from "Events" table
            connection.Close();         // Closes the database connection
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            connection.Open();  // Opens the database connection
            SqlCommand commIns = new SqlCommand(
                            "INSERT INTO Events(ID, Difficulty, Event, Type, Contact) VALUES (@ID, @Difficulty, @Event, @Type, @Contact)",
                            connection
                        );
            // Adding parameters with pre-defined values for the new record
            commIns.Parameters.Add("@ID", SqlDbType.Int, 1, "ID").Value = 2;
            commIns.Parameters.Add("@Difficulty", SqlDbType.Int, 1, "Difficulty").Value = 1;
            commIns.Parameters.Add("@Event", SqlDbType.VarChar, 50, "Event").Value = "TestEvent";
            commIns.Parameters.Add("@Type", SqlDbType.VarChar, 50, "Type").Value = "TestType";
            commIns.Parameters.Add("@Contact", SqlDbType.VarChar, 50, "Contact").Value = "TestContact";

            commIns.ExecuteNonQuery();  // Executes the INSERT command

            dataset.Clear();                // Clears the current data in the DataSet
            adapter.Fill(dataset, table);  // Refills the DataSet with updated data
            setUpEmployeeListView();        // Updates the ListView with the new data

            connection.Close();             // Closes the database connection
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();  // Opens the database connection
            // 5. Creating a SqlCommand to DELETE a record based on ID
            SqlCommand commDelete = new SqlCommand("DELETE FROM Events WHERE ID=@ID", connection);
            // Adding parameter to prevent SQL injection and specify the ID to delete
            commDelete.Parameters.Add("@ID", SqlDbType.Int, 1, "ID").Value = txtID.Text;
            commDelete.ExecuteNonQuery();  // Executes the DELETE command

            dataset.Clear();                // Clears the current data in the DataSet
            adapter.Fill(dataset, "Events");  // Refills the DataSet with updated data
            setUpEmployeeListView();        // Updates the ListView with the new data

            connection.Close();
        }


        private void btnNewRow_Click(object sender, EventArgs e)
        {
            // 7. Creating a new DataRow with specified values (offline)
            DataRow row = dataset.Tables["Events"].NewRow();
            row["ID"] = 99;
            row["Difficulty"] = 5;
            row["Event"] = "DummEvent";
            row["Type"] = "DummyType";
            row["Contact"] = "DummyContact";

            dataset.Tables["Events"].Rows.Add(row);  // Adds the new row to the DataSet

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            MessageBox.Show("Changes saved successfully!");

            try
            {
                adapter.Update(dataset, table);  // Updates the database with changes from the DataSet
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);  // Displays any errors that occur during the update
            }

            dataset.Clear();
            adapter.Fill(dataset, table);
            setUpEmployeeListView();


        }
    }
}
