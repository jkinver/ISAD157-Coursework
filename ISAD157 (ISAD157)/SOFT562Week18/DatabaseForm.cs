using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SOFT562Week18
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void comboBoxQueryChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQueryChoice.SelectedIndex == 0)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + MySQLConnector.SERVER + ";" +
                    "DATABASE=" + MySQLConnector.DATABASE_NAME + ";" + "UID=" +
                    MySQLConnector.USER_NAME + ";" + "PASSWORD=" +
                    MySQLConnector.PASSWORD + ";" + "SslMode=" +
                    MySQLConnector.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // users table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_jkinver.users";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the connectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable usersDataTable = new DataTable();
                    sqlDA.Fill(usersDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the Facebook users table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewUsers.DataSource = usersDataTable;

                } // End of using (MySqlConnection connection = ...
            }
            else if (comboBoxQueryChoice.SelectedIndex == 1)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + MySQLConnector.SERVER + ";" +
                    "DATABASE=" + MySQLConnector.DATABASE_NAME + ";" + "UID=" +
                    MySQLConnector.USER_NAME + ";" + "PASSWORD=" +
                    MySQLConnector.PASSWORD + ";" + "SslMode=" +
                    MySQLConnector.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // friends table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_jkinver.user_friend_link";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable friendsDataTable = new DataTable();
                    sqlDA.Fill(friendsDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the Facebook friends table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewFriends.DataSource = friendsDataTable;
                }
            } //end of else if
            
            else if (comboBoxQueryChoice.SelectedIndex == 2)
            {
                string connectionString = "SERVER=" + MySQLConnector.SERVER + ";" +
                    "DATABASE=" + MySQLConnector.DATABASE_NAME + ";" + "UID=" +
                    MySQLConnector.USER_NAME + ";" + "PASSWORD=" +
                    MySQLConnector.PASSWORD + ";" + "SslMode=" +
                    MySQLConnector.SslMode + ";";

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    //the SQL query itself that is being used through C#
                    string query = "SELECT * FROM isad157_jkinver.workplaces";
                    connection.Open();
                    
                    //submits the above string to be used by MySQL
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable workplacesDataTable = new DataTable();
                    sqlDA.Fill(workplacesDataTable);

                    //attach the information from the workplaces table
                    dataGridViewWorkplaces.DataSource = workplacesDataTable;
                }
            } //end of else if
            else if (comboBoxQueryChoice.SelectedIndex == 3)
            {
                string connectionString = "SERVER=" + MySQLConnector.SERVER + ";" +
                    "DATABASE=" + MySQLConnector.DATABASE_NAME + ";" + "UID=" +
                    MySQLConnector.USER_NAME + ";" + "PASSWORD=" +
                    MySQLConnector.PASSWORD + ";" + "SslMode=" +
                    MySQLConnector.SslMode + ";";

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    //the SQL query itself that is being used through C#
                    string query = "SELECT * FROM isad157_jkinver.schools";
                    connection.Open();

                    //submits the above string to be used by MySQL
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable schoolOrUniDataTable = new DataTable();
                    sqlDA.Fill(schoolOrUniDataTable);

                    //attach the information from the school/uni table
                    dataGridViewSchoolOrUni.DataSource = schoolOrUniDataTable;
                }
            } //end of else if
            else if (comboBoxQueryChoice.SelectedIndex == 4)
            {
                string connectionString = "SERVER=" + MySQLConnector.SERVER + ";" +
                    "DATABASE=" + MySQLConnector.DATABASE_NAME + ";" + "UID=" +
                    MySQLConnector.USER_NAME + ";" + "PASSWORD=" +
                    MySQLConnector.PASSWORD + ";" + "SslMode=" +
                    MySQLConnector.SslMode + ";";

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    //the SQL query itself that is being used through C#
                    string query = "SELECT * FROM isad157_jkinver.messages";
                    connection.Open();

                    //submits the above string to be used by MySQL
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable messagesDataTable = new DataTable();
                    sqlDA.Fill(messagesDataTable);

                    //attach the information from the messages table
                    dataGridViewMessages.DataSource = messagesDataTable;
                }
            }

        } // End of private void comboBoxQueryChoice_SelectedIndexChanged
    }
}
