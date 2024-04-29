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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LogIn_Form
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        { 
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelStudentNum_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void labelDash_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            About about = new About();
            this.Hide();
            about.Show();
        }

        private void panelDashhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            this.Hide();
            books.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void LogOut()
        {
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=camilajane_16;database=LibrarySystem";

            try
            {
                // Read the username from wherever you store it
                string username = ReadUsernameFromDatabase();

                // Ensure the username is not empty
                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Error: Username cannot be empty.", "Error");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();

                    // Perform the logout operation by updating the "status" column to 'Inactive'
                    string logoutSql = "UPDATE users SET status = 'Inactive' WHERE username = @username";
                    using (MySqlCommand logoutCmd = new MySqlCommand(logoutSql, conn))
                    {
                        logoutCmd.Parameters.AddWithValue("@username", username);
                        logoutCmd.ExecuteNonQuery();
                    }

                    // Optionally, clear any user-specific data

                    // Optionally, hide or close the current form

                    MessageBox.Show("Logout successful.", "Success");

                    // Show the login form
                    LogIn loginFormInstance = new LogIn(); 
                    loginFormInstance.Show();
                    this.Hide();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }


        private string ReadUsernameFromDatabase()
        {
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=camilajane_16;database=LibrarySystem";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();

                    // Retrieve the username from the database where the status is 'active'
                    string selectUsernameSql = "SELECT username FROM users WHERE status = 'Active' LIMIT 1";
                    using (MySqlCommand selectUsernameCmd = new MySqlCommand(selectUsernameSql, conn))
                    {
                        object result = selectUsernameCmd.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error: No active user found in the database.", "Error");
                            return null;
                        }
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
                return null;
            }
        }



        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Acc_Click(object sender, EventArgs e)
        {
            var Users = new Users();
            this.Hide();
            Users.Show();   
        }

        private void labelTransact_Click(object sender, EventArgs e)
        {
            var transactions = new Transaction();
            this.Hide();
            transactions.Show();
        }

        private void labelStudent_Click(object sender, EventArgs e)
        {
            var Students = new Students();
            this.Hide();
            Students.Show();
        }
    }
}
