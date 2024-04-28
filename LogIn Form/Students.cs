using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace LogIn_Form
{
    public partial class Students : Form
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

        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            uploadData();
        }

        public void uploadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" +
                    "username=" + username + ";" +
                    "password=" + password + ";" +
                    "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText ="SELECT s.student_id, s.first_name, s.last_name, " +
                                "s.email, s.phone_number, s.address, s.course, " +
                                "s.year_block, s.college, s.borrowedbooks " +
                                "FROM LibrarySystem.student s";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            datagrid.DataSource = sqlDt;
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
                    dv.RowFilter = $"student_id = {search.Text} OR " +
                                   $"first_name LIKE '%{search.Text}%' OR " +
                                   $"last_name LIKE '%{search.Text}%' OR " +
                                   $"email LIKE '%{search.Text}%' OR " +
                                   $"phone_number = '{search.Text}' OR " +
                                   $"address LIKE '%{search.Text}%' OR " +
                                   $"course LIKE '%{search.Text}%' OR " +
                                   $"year_block LIKE '%{search.Text}%' OR " +
                                   $"college LIKE '%{search.Text}%' OR " +
                                   $"borrowedbooks= '{search.Text}'";

                    // Set the filtered DataView as the DataSource for the DataGridView
                    datagrid.DataSource = dv.ToTable();
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
            string templateFilePath = @"C:\Users\Cyrus\Documents\StudentReport.xlsx";

            // Define the base path and filename
            string basePath = @"C:\Downloads\LibraryStudentReport";
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
            object[,] data = new object[datagrid.Rows.Count, datagrid.Columns.Count];
            for (int i = 0; i < datagrid.Rows.Count; i++)
            {
                for (int j = 0; j < datagrid.Columns.Count; j++)
                {
                    // Check if the current cell contains a date value
                    if (datagrid.Rows[i].Cells[j].Value is DateTime dateValue)
                    {
                        // Convert the date to the desired format
                        data[i, j] = dateValue.ToString("dd MMM yyyy");
                    }
                    else
                    {
                        // Otherwise, use the cell value as it is
                        data[i, j] = datagrid.Rows[i].Cells[j].Value;
                    }
                }
            }

            // Write data to Excel
            Excel.Range range = worksheet.Range[worksheet.Cells[startRow, startColumn], worksheet.Cells[startRow + datagrid.Rows.Count - 1, startColumn + datagrid.Columns.Count - 1]];
            range.Value = data;

            // Add Header "Date:" on cell I7
            worksheet.Cells[7, startColumn + datagrid.Columns.Count - 4] = "Date:";

            // Include the current date and time on cell J7
            worksheet.Cells[7, startColumn + datagrid.Columns.Count - 3] = DateTime.Now.ToString("MMM dd yyyy HH:mm:ss");

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
