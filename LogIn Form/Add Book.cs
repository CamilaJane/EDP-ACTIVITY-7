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
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(newTitle.Text) ||
                string.IsNullOrWhiteSpace(newAuthor.Text) ||
                string.IsNullOrWhiteSpace(newGenre.Text) ||
                string.IsNullOrWhiteSpace(newLanguage.Text) ||
                string.IsNullOrWhiteSpace(newPublisher.Text) ||
                string.IsNullOrWhiteSpace(newYear.Text) ||
                string.IsNullOrWhiteSpace(newQuantity.Text) ||
                string.IsNullOrWhiteSpace(newStat.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error");
                return;
            }


            string connectionString = "server=127.0.0.1;uid=root;" +
                "pwd=camilajane_16;database=LibrarySystem";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Create new book details
                string newtitle = newTitle.Text;
                string newauthor = newAuthor.Text;
                string newgenre = newGenre.Text;
                string newlanguage = newLanguage.Text;
                string newpublisher = newPublisher.Text;
                string newyear = newYear.Text;
                string newquantity = newQuantity.Text;
                string newstat = newStat.Text;

                // Check if the title already exists
                if (TitleExists(newtitle, connection, "SELECT COUNT(*) FROM books WHERE title = @title"))
                {
                    MessageBox.Show("Book with the same title already exists.", "Error");
                }
                else
                {
                    // Insert the new book details into the database
                    InsertBookDetails(connection, newtitle, newauthor, newgenre, newlanguage, newpublisher, newyear, newquantity, newstat);

                    MessageBox.Show("Book added successfully.", "Success");

                    ClearForm();
                }
            }
        }

        private static void InsertBookDetails(MySqlConnection connection, string title, string author, string genre, string language, string publisher, string year, string quantity, string stat)
        {
            string query = "INSERT INTO books (title, author, genre_id, language, publisher, publication_year, quantity, book_stat)" +
                           "VALUES (@title, @author, @genre_id, @language, @publisher, @publication_year, @quantity, @book_stat)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@genre_id", genre);
                cmd.Parameters.AddWithValue("@language", language);
                cmd.Parameters.AddWithValue("@publisher", publisher);
                cmd.Parameters.AddWithValue("@publication_year", year);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@book_stat", stat);

                cmd.ExecuteNonQuery();
            }
        }

        private void ClearForm()
        {
            newTitle.Text = "";
            newAuthor.Text = "";
            newGenre.Text = "";
            newLanguage.Text = "";
            newPublisher.Text = "";
            newYear.Text = "";
            newQuantity.Text = "";
            newStat.Text = "";
        }

        static bool TitleExists(string title, MySqlConnection connection, string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@title", title);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }



        private void Add_Book_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            var Books = new Books();
            this.Hide();
            Books.Show();
        }
    }
}
