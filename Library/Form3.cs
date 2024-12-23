using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class Form3 : Form
    {

        private const string CustomerFilePath = @"F:\FP_project\customer.txt";
        private const string BookFilePath = @"F:\FP_project\Librarian.txt";

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f;
            f = Form1.ActiveForm;
            f.Activate();


            // Read the values ​​entered in the TextBoxes
            string customerId = customer_id.Text;
            string customerName = customer_Name.Text;
            string address = Address.Text;
            string bookName = book_Name.Text;

            // Check that all TextBoxes are not empty
            if (string.IsNullOrEmpty(customerId) ||
                string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(bookName))
            {
                MessageBox.Show("Please complete all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if one of the Radio Buttons is selected
            string action = "";
            if (radioButton2.Checked)
            {
                action = "Book is Bought";
            }
            else if (radioButton1.Checked)
            {
                action = "Book is Borrowed";
            }
            else
            {
                MessageBox.Show("Please choose whether to buy a book or borrow a book.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Write customer record to customer file
            string customerRecord = $"{customerId},{customerName},{address},{bookName},{action}";
            try
            {
                File.AppendAllText(CustomerFilePath, customerRecord + Environment.NewLine);
                MessageBox.Show("Customer record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Show input summary
                string message = $"Student Details:\n\n" +
                                 $"Customer ID: {customerId}\n" +
                                 $"Customer Name: {customerName}\n" +
                                 $"Address: {address}\n" +
                                 $"Book Name: {bookName}\n" +
                                 $"Action: {action}";
                MessageBox.Show(message, "Application Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to customer file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Clear inputs
            customer_id.Clear();
            customer_Name.Clear();
            Address.Clear();
            book_Name.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Customer Form";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }      
    }
}
