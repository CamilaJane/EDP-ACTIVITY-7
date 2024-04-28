using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Excel = Microsoft.Office.Interop.Excel;

namespace LogIn_Form
{
    public partial class Transaction : Form
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

        public Transaction()
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
            sqlCmd.CommandText = "SELECT t.transaction_id, t.student_id, t.firstname, t.lastname, t.book_id, t.borrow_date, t.due_date, t.return_Date, t.status, t.overduefee, t.payment_status " +
                    "FROM LibrarySystem.transactions t " +
                    "JOIN LibrarySystem.books b ON t.book_id = b.book_id ";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Define the path to your Excel template file
            string templateFilePath = @"C:\Users\Cyrus\Documents\TransactionReceipt.xlsx";

            // Define the base path and filename
            string basePath = @"C:\Downloads";
            string fileName = "LibraryTransactionReceipt";
            string fileExtension = ".xlsx";

            // Check if the file already exists
            int fileIndex = 1;
            string newFilePath = Path.Combine(basePath, $"{fileName}{fileExtension}");
            while (File.Exists(newFilePath))
            {
                // If the file already exists, modify the filename
                fileName = $"LibraryTransactionReceipt ({fileIndex})";
                newFilePath = Path.Combine(basePath, $"{fileName}{fileExtension}");
                fileIndex++;
            }

            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;
            Excel.Range range = null;

            try
            {
                // Create a new Excel application
                excelApp = new Excel.Application();

                // Open the template file
                workbook = excelApp.Workbooks.Open(templateFilePath);

                // Access the first worksheet in the workbook
                worksheet = workbook.Sheets[1]; // Indexing starts from 1

                // Determine the range where data should be placed
                int startRow = 7;
                int startColumn = 4;

                // Load data from DataGridView
                object[,] data = new object[dataGridView1.Columns.Count, 1];
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    // Check if the current cell contains a date value
                    if (dataGridView1.CurrentRow.Cells[j].Value is DateTime dateValue)
                    {
                        // Convert the date to the desired format
                        data[j, 0] = dateValue.ToString("dd MMM yyyy");
                    }
                    else
                    {
                        // Otherwise, use the cell value as it is
                        data[j, 0] = dataGridView1.CurrentRow.Cells[j].Value;
                    }
                }

                // Write data to Excel
                range = worksheet.Range[worksheet.Cells[startRow, startColumn], worksheet.Cells[startRow + dataGridView1.Columns.Count - 1, startColumn]];
                range.Value = data;

                // Add Header "Date" on cell D6
                worksheet.Cells[6, startColumn] = "Date:";

                // Include the current date and time on cell E6
                worksheet.Cells[6, startColumn + 1] = DateTime.Now.ToString("MMM dd yyyy HH:mm:ss");

                // Save the workbook with the new file path
                workbook.SaveAs(newFilePath);

                MessageBox.Show("Excel file created successfully: " + newFilePath);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the workbook and Excel application
                if (workbook != null)
                    workbook.Close();

                if (excelApp != null)
                {
                    // Quit the Excel application
                    excelApp.Quit();
                    ReleaseObject(excelApp); // Release COM object
                }

                // Clean up Excel objects to release resources
                ReleaseObject(range);
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
            }
        }

        // Method to release COM objects
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
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

                    // Escape single quotes in the text search
                    string searchText = textsearch.Text.Replace("'", "''");

                    // Check if searchText can be parsed as a DateTime
                    DateTime searchDateTime;
                    bool isDateTime = DateTime.TryParseExact(searchText, "dd MMM yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out searchDateTime);

                    // Construct the filter expression
                    string filterExpression = string.Empty;

                    if (isDateTime)
                    {
                        // If the searchText is a valid DateTime, construct the filter for date fields
                        string formattedDate = searchDateTime.ToString("yyyy-MM-dd");
                        filterExpression = $"borrow_date = #{formattedDate}# OR " +
                                            $"due_date = #{formattedDate}# OR " +
                                            $"return_date = #{formattedDate}#";
                    }
                    else
                    {
                        // If searchText is not a valid DateTime, attempt to parse it as an integer
                        int overdueFee;
                        bool isInteger = int.TryParse(searchText, out overdueFee);

                        if (isInteger)
                        {
                            // If searchText can be parsed as an integer, construct the filter for integer fields
                            filterExpression = $"transaction_id = {overdueFee} OR " +
                                                $"student_id = {overdueFee} OR " +
                                                $"book_id = {overdueFee} OR " +
                                                $"overduefee = {overdueFee}";
                        }
                        else
                        {
                            // If searchText is neither a valid DateTime nor an integer, include other string comparisons
                            filterExpression = $"firstname LIKE '%{searchText}%' OR " +
                                                $"lastname LIKE '%{searchText}%' OR " +
                                                $"status LIKE '%{searchText}%' OR " +
                                                $"payment_status LIKE '%{searchText}%'";
                        }
                    }

                    // Use the RowFilter property to filter based on multiple columns
                    dv.RowFilter = filterExpression;

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

        private void Transaction_Load(object sender, EventArgs e)
        {
            uploadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Define the path to your Excel template file
            string templateFilePath = @"C:\Users\Cyrus\Documents\TransactionsReport.xlsx";

            // Define the base path and filename
            string basePath = @"C:\Downloads\LibraryTransactionReport";
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
            int startColumn = 1;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Dashboard = new Dashboard();
            this.Hide();
            Dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
