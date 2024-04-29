using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Excel = Microsoft.Office.Interop.Excel;

namespace LogIn_Form
{
    public partial class Books : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        System.Data.DataTable sqlDt = new System.Data.DataTable();
        string sqlQuery;
        MySqlDataAdapter DTA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        string server = "127.0.0.1";
        string username = "root";
        string password = "camilajane_16";
        string database = "LibrarySystem";


        public Books()
        {
            InitializeComponent();
        }

        public void uploadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" +
                    "username=" + username + ";" +
                    "password=" + password + ";" +
                     "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT b.book_id, b.title, b.author, b.language, g.genre_type, b.publisher, b.publication_year, b.quantity, b.book_stat, b.bookimage " +
                    "FROM LibrarySystem.books b " +
                    "JOIN LibrarySystem.genre g ON b.genre_id = g.genre_id ";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;


        }



        private void buttonBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLoad1(object sender, EventArgs e)
        {
            uploadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Add_Book = new Add_Book();
            this.Hide();
            Add_Book.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the DataTable has data before applying the filter
                if (sqlDt != null && sqlDt.Rows.Count > 0)
                {
                    // Create a DataView from the DataTable
                    DataView dv = new DataView(sqlDt);

                    // Use the RowFilter property to filter based on multiple columns
                    dv.RowFilter = $"book_id = {textsearch.Text} OR " +
                                   $"title LIKE '%{textsearch.Text}%' OR " +
                                   $"author LIKE '%{textsearch.Text}%' OR " +
                                   $"language LIKE '%{textsearch.Text}%' OR " +
                                   $"publisher LIKE '%{textsearch.Text}%' OR " +
                                   $"genre_type LIKE '%{textsearch.Text}%' OR " +
                                   $"publication_year = '{textsearch.Text}' OR " +
                                   $"quantity = '{textsearch.Text}' OR " +
                                   $"book_stat LIKE '%{textsearch.Text}%'";

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Define the path to your Excel template file
            string templateFilePath = @"C:\Users\Cyrus\Documents\LibraryInventory.xlsx";

            // Define the base path and filename
            string basePath = @"C:\Downloads\LibraryBookInventory";
            string fileExtension = ".xlsx";

            // Check if the file already exists
            int fileIndex = 1;
            string newFilePath = Path.Combine(basePath + fileExtension);
            while (File.Exists(newFilePath))
            {
                newFilePath = Path.Combine(basePath + $" ({fileIndex})" + fileExtension);
                fileIndex++;
            }

            // Create a new Excel application
            Excel.Application excelApp = new Excel.Application();

            // Open the template file
            Excel.Workbook workbook = excelApp.Workbooks.Open(templateFilePath);

            // Access the first worksheet in the workbook
            Excel.Worksheet worksheet = workbook.Sheets[1]; // Indexing starts from 1

            // Determine the range where data should be placed
            int startRow = 14;
            int startColumn = 2;

            // Load data from DataGridView
            object[,] data = new object[dataGridView1.Rows.Count, dataGridView1.Columns.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    // Check if the current cell contains a date value
                    if (dataGridView1.Rows[i].Cells[j].Value is DateTime dateValue)
                    {
                        // Convert the date to the desired format
                        data[i, j] = dateValue.ToString("dd MMM yyyy");
                    }
                    else
                    {
                        // Otherwise, use the cell value as it is
                        data[i, j] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
            }

            // Write data to Excel
            Excel.Range range = worksheet.Range[worksheet.Cells[startRow, startColumn], worksheet.Cells[startRow + dataGridView1.Rows.Count - 1, startColumn + dataGridView1.Columns.Count - 1]];
            range.Value = data;

            // Add Header "Date:" on cell I7
            worksheet.Cells[7, startColumn + dataGridView1.Columns.Count - 4] = "Date:";

            // Include the current date and time on cell J7
            worksheet.Cells[7, startColumn + dataGridView1.Columns.Count - 3] = DateTime.Now.ToString("MMM dd yyyy HH:mm:ss");

            // Save the workbook with the new file path
            workbook.SaveAs(newFilePath);

            // Close the workbook and Excel application
            workbook.Close();
            excelApp.Quit();

            // Clean up Excel objects to release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(range);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            MessageBox.Show("Excel file created successfully: " + newFilePath);
        }
    }
}

