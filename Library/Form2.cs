using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Librarian Form";
        }
        FileStream myFile;
        StreamReader sr;
        StreamWriter sw;
        string fileName;
        private void open_file_Click(object sender, EventArgs e)
        {
            Form f;
            f = Form1.ActiveForm;
            f.Activate();

            OpenFileDialog fd = new OpenFileDialog();   //to allow the user to select a file
            DialogResult res = fd.ShowDialog();     // Show the dialog to the user and store the result

            // If the user cancels the dialog, exit the method
            if (res == DialogResult.Cancel)
                return;

            fileName = fd.FileName;  //store file name into variable

            myFile = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);   //open the selected file ...
            sw = new StreamWriter(myFile);
            sr = new StreamReader(myFile);

            MessageBox.Show("File is Opened");

            search.Enabled = true;
            read_available.Enabled = true;
            clear.Enabled = true;
            read_borrowed.Enabled = true;
            exit.Enabled = true;
            add_book.Enabled = true;
            delete_book.Enabled = true;
            close.Enabled = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            book_id.Text = bookName.Text = author.Text = year.Text = null;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            try
            {
                sr.Close();
                sw.Close();
                myFile.Close();
                search.Enabled = false;
                read_available.Enabled = false;
                clear.Enabled = false;
                read_borrowed.Enabled = false;
                exit.Enabled = false;
                add_book.Enabled = false;
                delete_book.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("File Closed");
            }
        }

        private void add_book_Click(object sender, EventArgs e)
        {
            myFile.Seek(0, SeekOrigin.End);     // Move to the end of the file
            string record =  book_id.Text + "," + bookName.Text + "," + author.Text + "," + year.Text;
            sw.WriteLine(record);        // Write the record to the file
            sw.Flush();                  // Ensure the data is written immediately
            MessageBox.Show("Book is added");
        }

        private int currentLineIndex = 0; // Tracks the current index of the line being read
        private List<string> records = new List<string>(); // Stores all valid records for navigation

        private void read_available_Click(object sender, EventArgs e)
        {

            try
            {
                // Check if a file has been opened before proceeding
                if (myFile == null || sr == null)
                {
                    MessageBox.Show("Please open a file first.", "Error");
                    return;
                }

                // The first click: load all valid records into memory
                if (currentLineIndex == 0 && records.Count == 0)
                {
                    myFile.Seek(0, SeekOrigin.Begin);  // Reset the file pointer to the start
                    sr.DiscardBufferedData();  // Clear any remaining buffered data

                    string record;
                    while ((record = sr.ReadLine()) != null)
                    {
                        if (!record.StartsWith("*"))  // Skip deleted records
                        {
                            records.Add(record);  // Store the valid records
                        }
                    }

                    // If there are no valid records, notify the user
                    if (records.Count == 0)
                    {
                        MessageBox.Show("No available records found.", "Information");
                        return;
                    }
                }

                // Display the next record if available
                if (currentLineIndex < records.Count)
                {
                    string[] fields = records[currentLineIndex].Split(',');

                    // Populate the UI fields with data from the current record
                    if (fields.Length >= 4)
                    {
                        book_id.Text = fields[0];
                        bookName.Text = fields[1];
                        author.Text = fields[2];
                        year.Text = fields[3];
                    }

                    // Move to the next record after displaying the current one
                    currentLineIndex++;
                }
                else
                {
                    // If all records have been shown, display a message and reset the index
                    MessageBox.Show("No more available records.", "Information");
                    currentLineIndex = 0; // Reset index to start from the first record
                }
            }
            catch (Exception ex)
            {
                // Handle errors gracefully
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }


        }

        private void book_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bookName.Focus();
            }
        }

        private void bookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                author.Focus();
            }
        }

        private void author_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                year.Focus();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string accnom = book_id.Text;    // Retrieve the account number entered by the user in the first text box.
            myFile.Seek(0, SeekOrigin.Begin); // Move the file pointer to the beginning of the file to start searching.
            sr.DiscardBufferedData();    // Reset the reader's buffer to synchronize with the file pointer's position.
            string line;
            string[] field;
            while ((line = sr.ReadLine()) != null)     // Read each line of the file until the end.
            {

                field = line.Split(',');        // Split the line into individual fields using the comma as a separator.
                if (field[0] == accnom)          // Check if the account number in the record matches the user-provided account number.
                {
                    bookName.Text = field[1];
                    author.Text = field[2]; year.Text = field[3];      // Populate the text boxes with the corresponding fields of the matching record.

                    MessageBox.Show("Found");            // Notify the user that the record was found.
                    return;
                    // Exit the function since the desired record has been found.        
                }

            }
            MessageBox.Show("Not Found");      // If the loop finishes without finding a match, notify the user that the record was not found.


        }

        private void delete_book_Click(object sender, EventArgs e)
        {
            // Reset the file pointer to the beginning of the file
            myFile.Seek(0, SeekOrigin.Begin);
            // Ensure any buffered data is written to the file and flush the streams
            myFile.Flush();
            sw.Flush();
            string line;          // Variable to hold each line read from the file
            string[] field;       // Array to store fields after splitting the line
            int count = 0;        // Variable to track the position in the file
            bool recordDeleted = false; // Flag to check if the record was found and deleted
                                        // Loop through each line in the file
            while ((line = sr.ReadLine()) != null)
            {       // Split the line into fields based on the comma delimiter
                field = line.Split(',');
                // Check if the first field (record ID) matches the text in textBox1
                if (field[0] == book_id.Text)
                {             // Move the file pointer to the position of the current record
                    myFile.Seek(count, SeekOrigin.Begin);
                    // Write "" to mark the record as deleted
                    sw.Write("*");
                    // Flush the stream to ensure changes are saved
                    sw.Flush();
                    myFile.Flush();
                    // Set the flag to true since the record was found and deleted
                    recordDeleted = true;
                    // Exit the loop since the record has been processed
                    break;
                }
                // Update the position counter to account for the length of the current line         
                count += line.Length + 2;              // Adding 2 accounts for the newline characters (\r\n or \n)
            }
            // Check if the record was deleted
            if (recordDeleted)
            {
                // Show a success message if the record was deleted
                MessageBox.Show("The record has been successfully deleted.", "Record Deleted");
            }
            else
            {         // Show an error message if the record was not found
                MessageBox.Show("Record not found.", "Error");
            }

        }
        private int current = 0; // Tracks the current index of the line being read
        private List<string> recordd = new List<string>(); // Stores all valid records for navigation
        private void read_borrowed_Click(object sender, EventArgs e)
        {

            try
            {
                // Check if a file has been opened before proceeding
                if (myFile == null || sr == null)
                {
                    MessageBox.Show("Please open a file first.", "Error");
                    return;
                }

                // The first click: load all valid records into memory
                if (current == 0 && recordd.Count == 0)
                {
                    myFile.Seek(0, SeekOrigin.Begin);  // Reset the file pointer to the start
                    sr.DiscardBufferedData();  // Clear any remaining buffered data

                    string record;
                    while ((record = sr.ReadLine()) != null)
                    {
                        if (record.StartsWith("*"))  
                        {
                            recordd.Add(record);  // Store the valid records
                        }
                    }

                    // If there are no valid records, notify the user
                    if (recordd.Count == 0)
                    {
                        MessageBox.Show("No borrowed or deleted records found.", "Information");
                        return;
                    }
                }

                // Display the next record if available
                if (current < recordd.Count)
                {
                    string[] fields = recordd[current].Split(',');

                    // Populate the UI fields with data from the current record
                    if (fields.Length >= 4)
                    {
                        book_id.Text = fields[0];
                        bookName.Text = fields[1];
                        author.Text = fields[2];
                        year.Text = fields[3];
                    }

                    // Move to the next record after displaying the current one
                    current++;
                }
                else
                {
                    // If all records have been shown, display a message and reset the index
                    MessageBox.Show("No more Delete or borrowed books.", "Information");
                    current = 0; // Reset index to start from the first record
                }
            }
            catch (Exception ex)
            {
                // Handle errors gracefully
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }
    }
}
