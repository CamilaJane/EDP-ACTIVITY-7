using MySql.Data.MySqlClient;
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

namespace LogIn_Form
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void newPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            var LogIn = new LogIn();
            this.Hide();
            LogIn.Show();
        }

        private void bttnCreate_Click(object sender, EventArgs e)
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(newUser.Text) ||
                string.IsNullOrWhiteSpace(newEmail.Text) ||
                string.IsNullOrWhiteSpace(newPass.Text) ||
                string.IsNullOrWhiteSpace(newFirstName.Text) ||  
                string.IsNullOrWhiteSpace(newLastName.Text) ||    
                string.IsNullOrWhiteSpace(newBirth.Text) ||
                string.IsNullOrWhiteSpace(newGender.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error");
                return;
            }


            string connectionString = "server=127.0.0.1;uid=root;" +
                "pwd=camilajane_16;database=LibrarySystem";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Create new user details
                string newUsername = newUser.Text;
                string newEmailadd = newEmail.Text;
                string newPassword = newPass.Text;
                string newFname = newFirstName.Text;
                string newLname = newLastName.Text;
                string newBirthdate = newBirth.Text;
                string newgender = newGender.Text;

                // Check if the username or email already exists
                if (UsernameOrEmailExists(newUsername, newEmailadd, connection))
                {
                    MessageBox.Show("Username or email already exists. Please choose a different username or email.", "Error");
                }
                else
                {
                    // Insert the new user details into the database
                    InsertUserDetails(connection, newUsername, newEmailadd, newPassword, newFname, newLname, newBirthdate, newgender);

                    MessageBox.Show("User created successfully.", "Success");

                    Console.WriteLine("New username: " + newUsername);
                    Console.WriteLine("New email: " + newEmailadd);
                    Console.WriteLine("New password: " + newPassword);
                    Console.WriteLine("New first name: " + newFname);
                    Console.WriteLine("New last name: " + newLname);
                    Console.WriteLine("New birthdate: " + newBirthdate);
                    Console.WriteLine("New gender: " + newgender);

                    ClearForm();
                }
            }

        }

        private static void InsertUserDetails(MySqlConnection connection, string username, string email, string password, string firstname, string lastname, string birthdate, string gender)
        {
            string query = "INSERT INTO users (username, email, password, firstname, lastname, birthdate, gender)" +
                           "VALUES (@username, @email, @password, @firstname, @lastname, @birthdate, @gender)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastName", lastname);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@gender", gender);

                cmd.ExecuteNonQuery();
            }
        }

        private void ClearForm()
        {
            newUser.Text = "";
            newEmail.Text = "";
            newPass.Text = "";
            newFirstName.Text = "";
            newLastName.Text = "";
            newBirth.Text = "";
            newGender.Text = "";
        }

        static bool UsernameOrEmailExists(string username, string email, MySqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username OR email = @email";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


        private void bttnClear_Click(object sender, EventArgs e)
        {
            newEmail.Text ="";
            newUser.Text = "";
            newPass.Text = "";
        }

        private void newUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                newPass.UseSystemPasswordChar = false;
            }
            else 
            { 
                newPass.UseSystemPasswordChar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
