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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LogIn_Form
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string user, pass;
            user = txtUser.Text;
            pass = txtPass.Text;
            if (user == "camila" && pass == "hello")
            {
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }*/

            string username = this.username.Text;
            string password = this.password.Text;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=camilajane_16;database=LibrarySystem";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string selectSql = "SELECT COUNT(*) from users where username = @username AND password = @password";
                MySqlCommand selectCmd = new MySqlCommand(selectSql, conn);
                selectCmd.Parameters.AddWithValue("@username", username);
                selectCmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(selectCmd.ExecuteScalar());

                if (count > 0)
                {
                    // Update active_status to indicate that the user is logged in
                    string updateSql = "UPDATE users SET status = 'Active' WHERE username = @username";
                    MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@username", username);
                    updateCmd.ExecuteNonQuery();

                    string loggedInUsername = username;


                    // MessageBox.Show("You are now logged in");
                    Dashboard dashboard = new Dashboard(loggedInUsername);
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username/password");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Create = new Create();
            this.Hide();
            Create.Show();
        }

        private void Forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Recovery = new Recover();
            this.Hide();
            Recovery.Show();
        }
    }
}
