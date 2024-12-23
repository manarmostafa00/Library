namespace Library
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            open_file = new Button();
            clear = new Button();
            search = new Button();
            delete_book = new Button();
            add_book = new Button();
            read_available = new Button();
            read_borrowed = new Button();
            exit = new Button();
            book_id = new TextBox();
            bookName = new TextBox();
            author = new TextBox();
            year = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            close = new Button();
            SuspendLayout();
            // 
            // open_file
            // 
            open_file.BackColor = Color.NavajoWhite;
            open_file.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            open_file.Location = new Point(76, 52);
            open_file.Name = "open_file";
            open_file.Size = new Size(131, 72);
            open_file.TabIndex = 0;
            open_file.Text = "Open File";
            open_file.UseVisualStyleBackColor = false;
            open_file.Click += open_file_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.NavajoWhite;
            clear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            clear.Location = new Point(357, 52);
            clear.Name = "clear";
            clear.Size = new Size(131, 72);
            clear.TabIndex = 1;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // search
            // 
            search.BackColor = Color.NavajoWhite;
            search.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            search.Location = new Point(625, 52);
            search.Name = "search";
            search.Size = new Size(131, 72);
            search.TabIndex = 2;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // delete_book
            // 
            delete_book.BackColor = Color.NavajoWhite;
            delete_book.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            delete_book.Location = new Point(918, 52);
            delete_book.Name = "delete_book";
            delete_book.Size = new Size(131, 72);
            delete_book.TabIndex = 3;
            delete_book.Text = "Delete Book";
            delete_book.UseVisualStyleBackColor = false;
            delete_book.Click += delete_book_Click;
            // 
            // add_book
            // 
            add_book.BackColor = Color.Tan;
            add_book.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            add_book.Location = new Point(749, 286);
            add_book.Name = "add_book";
            add_book.Size = new Size(175, 56);
            add_book.TabIndex = 4;
            add_book.Text = "Add Book";
            add_book.UseVisualStyleBackColor = false;
            add_book.Click += add_book_Click;
            // 
            // read_available
            // 
            read_available.BackColor = Color.NavajoWhite;
            read_available.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            read_available.Location = new Point(76, 538);
            read_available.Name = "read_available";
            read_available.Size = new Size(170, 68);
            read_available.TabIndex = 5;
            read_available.Text = "Read Available Books";
            read_available.UseVisualStyleBackColor = false;
            read_available.Click += read_available_Click;
            // 
            // read_borrowed
            // 
            read_borrowed.BackColor = Color.NavajoWhite;
            read_borrowed.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            read_borrowed.Location = new Point(343, 538);
            read_borrowed.Name = "read_borrowed";
            read_borrowed.Size = new Size(206, 68);
            read_borrowed.TabIndex = 6;
            read_borrowed.Text = "Read Borrowed and deleted Books";
            read_borrowed.UseVisualStyleBackColor = false;
            read_borrowed.Click += read_borrowed_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.NavajoWhite;
            exit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            exit.Location = new Point(918, 538);
            exit.Name = "exit";
            exit.Size = new Size(131, 68);
            exit.TabIndex = 7;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // book_id
            // 
            book_id.Location = new Point(300, 210);
            book_id.Name = "book_id";
            book_id.Size = new Size(352, 27);
            book_id.TabIndex = 8;
            book_id.KeyDown += book_id_KeyDown;
            // 
            // bookName
            // 
            bookName.Location = new Point(300, 286);
            bookName.Name = "bookName";
            bookName.Size = new Size(352, 27);
            bookName.TabIndex = 9;
            bookName.KeyDown += bookName_KeyDown;
            // 
            // author
            // 
            author.Location = new Point(300, 360);
            author.Name = "author";
            author.Size = new Size(352, 27);
            author.TabIndex = 10;
            author.KeyDown += author_KeyDown;
            // 
            // year
            // 
            year.Location = new Point(300, 431);
            year.Name = "year";
            year.Size = new Size(352, 27);
            year.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(97, 210);
            label1.Name = "label1";
            label1.Size = new Size(127, 38);
            label1.TabIndex = 12;
            label1.Text = "Book_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(97, 286);
            label2.Name = "label2";
            label2.Size = new Size(171, 38);
            label2.TabIndex = 13;
            label2.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(97, 360);
            label3.Name = "label3";
            label3.Size = new Size(110, 38);
            label3.TabIndex = 14;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.Location = new Point(97, 431);
            label4.Name = "label4";
            label4.Size = new Size(72, 38);
            label4.TabIndex = 15;
            label4.Text = "Year";
            // 
            // close
            // 
            close.BackColor = Color.NavajoWhite;
            close.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = SystemColors.ControlText;
            close.Location = new Point(660, 538);
            close.Name = "close";
            close.Size = new Size(131, 68);
            close.TabIndex = 16;
            close.Text = "Close File";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_949118068_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1176, 740);
            Controls.Add(close);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(year);
            Controls.Add(author);
            Controls.Add(bookName);
            Controls.Add(book_id);
            Controls.Add(exit);
            Controls.Add(read_borrowed);
            Controls.Add(read_available);
            Controls.Add(add_book);
            Controls.Add(delete_book);
            Controls.Add(search);
            Controls.Add(clear);
            Controls.Add(open_file);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button open_file;
        private Button clear;
        private Button search;
        private Button delete_book;
        private Button add_book;
        private Button read_available;
        private Button read_borrowed;
        private Button exit;
        private TextBox book_id;
        private TextBox bookName;
        private TextBox author;
        private TextBox year;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button close;
    }
}