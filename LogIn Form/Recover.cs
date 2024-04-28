using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LogIn_Form
{
    public partial class Recover : Form
    {
        public Recover()
        {
            InitializeComponent();
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd=camilajane_16;database=LibrarySystem";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT username, password FROM users WHERE username = @username";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Assuming textUser is a TextBox control where the username is entered
                    command.Parameters.AddWithValue("@username", textUser.Text);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming textPass is a TextBox control where the password will be displayed
                            textPass.Text = reader["password"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Username Not Available");
                            textPass.Text = "";
                        }
                    }
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            var LogIn = new LogIn();
            this.Hide();
            LogIn.Show();
        }
    }
}

