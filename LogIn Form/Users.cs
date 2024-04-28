using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LogIn_Form
{
    public partial class Users : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        string sqlQuery;
        MySqlDataAdapter DTA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        string server = "127.0.0.1";
        string username = "root";
        string password = "camilajane_16";
        string database = "LibrarySystem";
        public Users()
        {
            InitializeComponent();
        }

        public void uploadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";"
                + "username = " + username + ";"
                + "password = " + password + ";"
                + "database = " + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from LibrarySystem.users";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
        }



        private void Acc_Click(object sender, EventArgs e)
        {
            var Users = new Users();
            this.Hide();
            Users.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var About = new About();
            this.Hide();
            About.Show();
        }

        private void labelDash_Click(object sender, EventArgs e)
        {
            var Dashboard = new Dashboard();
            this.Hide();
            Dashboard.Show();
        }

        private void labelBooks_Click(object sender, EventArgs e)
        {
            var Books = new Books();
            this.Hide();
            Books.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;

                iExit = MessageBox.Show("Confirm if you want to exit", "MySql Connector", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel6.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                }
                textSearch.Clear();
                UserId.Clear();
                FirstName.Clear();
                LastName.Clear();
                Email.Clear();
                UserName.Clear();
                textPass.Clear();
                textbirthdate.Clear();
                cmbgender.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.Open();

                sqlQuery = "SELECT * FROM LibrarySystem.users WHERE user_id = @userId";

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlCmd.Parameters.AddWithValue("@userId", textSearch.Text);

                sqlRd = sqlCmd.ExecuteReader();

                if (sqlRd.Read())
                {
                    UserId.Text = sqlRd["user_id"].ToString();
                    Email.Text = sqlRd["email"].ToString();
                    FirstName.Text = sqlRd["firstname"].ToString();
                    LastName.Text = sqlRd["lastname"].ToString();
                    textbirthdate.Text = sqlRd["birthdate"].ToString();
                    cmbgender.Text = sqlRd["gender"].ToString();
                    UserName.Text = sqlRd["username"].ToString();
                    textPass.Text = sqlRd["password"].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Found", "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sqlRd.Close(); // Close the SqlDataReader explicitly

                // No need to close the connection explicitly here; it will be closed when leaving the 'using' block
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                sqlConn.Close(); // Ensure the connection is closed in case of an exception
            }
        }


    private void Users_Load(object sender, EventArgs e)
        {
            uploadData();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(Email.Text) ||
                    string.IsNullOrWhiteSpace(FirstName.Text) ||
                    string.IsNullOrWhiteSpace(LastName.Text) ||
                    string.IsNullOrWhiteSpace(textbirthdate.Text) || // Assuming textbirthdate is a valid date string
                    string.IsNullOrWhiteSpace(cmbgender.Text) ||
                    string.IsNullOrWhiteSpace(UserName.Text) ||
                    string.IsNullOrWhiteSpace(textPass.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error");
                    return; // Stop processing if any field is empty
                }

                sqlConn.ConnectionString = "server=" + server + ";"
                    + "username=" + username + ";"
                    + "password=" + password + ";"
                    + "database=" + database;

                sqlConn.Open();

                // Corrected the SQL query and added parameter placeholders
                sqlQuery = "INSERT INTO LibrarySystem.users (email, firstname, lastname, birthdate, gender, username, password) " +
                            "VALUES (@email, @firstname, @lastname, @birthdate, @gender, @userName, @password)";

                // Use parameters to avoid SQL injection
                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlCmd.Parameters.AddWithValue("@email", Email.Text);
                sqlCmd.Parameters.AddWithValue("@firstname", FirstName.Text);
                sqlCmd.Parameters.AddWithValue("@lastname", LastName.Text);
                sqlCmd.Parameters.AddWithValue("@birthdate", textbirthdate.Text); 
                sqlCmd.Parameters.AddWithValue("@gender", cmbgender.Text);
                sqlCmd.Parameters.AddWithValue("@userName", UserName.Text);
                sqlCmd.Parameters.AddWithValue("@password", textPass.Text);

                // Use ExecuteNonQuery for INSERT queries
                int rowsAffected = sqlCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User added successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to add user.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                sqlConn.Close();

                // Assuming uploadData is a method in the same class; if not, replace it with the correct method call
                uploadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if there are selected rows
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    UserId.Text = dataGridView1.SelectedRows[0].Cells["user_id"].Value.ToString();
                    Email.Text = dataGridView1.SelectedRows[0].Cells["email"].Value.ToString();
                    FirstName.Text = dataGridView1.SelectedRows[0].Cells["firstname"].Value.ToString();
                    LastName.Text = dataGridView1.SelectedRows[0].Cells["lastname"].Value.ToString();
                    textbirthdate.Text = dataGridView1.SelectedRows[0].Cells["birthdate"].Value.ToString();
                    cmbgender.Text = dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();
                    UserName.Text = dataGridView1.SelectedRows[0].Cells["username"].Value.ToString();
                    textPass.Text = dataGridView1.SelectedRows[0].Cells["password"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("No row selected.", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";"
                    + "username=" + username + ";"
                    + "password=" + password + ";"
                    + "database=" + database;

                sqlConn.Open();

                // Assuming you have a user_id column in your DataGridView
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    int userId = Convert.ToInt32(item.Cells["user_id"].Value); // Replace "user_id" with the actual column name

                    // Create a new MySqlCommand and set its command text
                    sqlCmd = new MySqlCommand("DELETE FROM LibrarySystem.users WHERE user_id = @user_id", sqlConn);

                    // Add the parameter to the command
                    sqlCmd.Parameters.AddWithValue("@user_id", userId);

                    // Execute the command
                    int rowsAffected = sqlCmd.ExecuteNonQuery();

                    // Check if the delete operation was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success");

                        // Remove the row from the DataGridView
                        dataGridView1.Rows.RemoveAt(item.Index);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                sqlConn.Close();
            }


        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the DataTable has data before applying the filter
                if (sqlDt != null && sqlDt.Rows.Count > 0)
                {
                    // Create a DataView from the DataTable
                    DataView dv = new DataView(sqlDt);

                    // Use the RowFilter property to filter based on the 'firstname' column
                    dv.RowFilter = $"firstname like '%{textSearch.Text}%'";

                    // Set the filtered DataView as the DataSource for the DataGridView
                    dataGridView1.DataSource = dv.ToTable();
                }
                else
                {
                    MessageBox.Show("No data available for filtering.", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UserId.Clear();
            FirstName.Clear();
            LastName.Clear();
            Email.Clear();
            UserName.Clear();
            textPass.Clear();
            textbirthdate.Clear();
            cmbgender.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(Email.Text) ||
                    string.IsNullOrWhiteSpace(FirstName.Text) ||
                    string.IsNullOrWhiteSpace(LastName.Text) ||
                    string.IsNullOrWhiteSpace(textbirthdate.Text) || 
                    string.IsNullOrWhiteSpace(cmbgender.Text) ||
                    string.IsNullOrWhiteSpace(UserName.Text) ||
                    string.IsNullOrWhiteSpace(textPass.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error");
                    return; // Stop processing if any field is empty
                }

                sqlConn.ConnectionString = "server=" + server + ";"
                    + "username=" + username + ";"
                    + "password=" + password + ";"
                    + "database=" + database;

                sqlConn.Open();

                // Corrected the SQL query for UPDATE
                sqlQuery = "UPDATE LibrarySystem.users SET " +
                            "email = @email, " +
                            "firstname = @firstname, " +
                            "lastname = @lastname, " +
                            "birthdate = @birthdate, " +
                            "gender = @gender, " +
                            "password = @password " +
                            "WHERE username = @userName";

                // Use parameters to avoid SQL injection
                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlCmd.Parameters.AddWithValue("@email", Email.Text);
                sqlCmd.Parameters.AddWithValue("@firstname", FirstName.Text);
                sqlCmd.Parameters.AddWithValue("@lastname", LastName.Text);
                sqlCmd.Parameters.AddWithValue("@birthdate", textbirthdate.Text); 
                sqlCmd.Parameters.AddWithValue("@gender", cmbgender.Text);
                sqlCmd.Parameters.AddWithValue("@userName", UserName.Text);
                sqlCmd.Parameters.AddWithValue("@password", textPass.Text);

                // Use ExecuteNonQuery for UPDATE queries
                int rowsAffected = sqlCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User's profile updated successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to update data.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally
            {
                sqlConn.Close();

                // Assuming uploadData is a method in the same class; if not, replace it with the correct method call
                uploadData();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var Users = new Users();
            this.Hide();
            Users.Show();
        }
    }
}
