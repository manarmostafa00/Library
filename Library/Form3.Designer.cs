namespace Library
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            submit = new Button();
            customer_id = new TextBox();
            customer_Name = new TextBox();
            Address = new TextBox();
            book_Name = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Tan;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            radioButton1.Location = new Point(912, 378);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(172, 35);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Borrow Book";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Tan;
            radioButton2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            radioButton2.Location = new Point(685, 378);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(134, 35);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Buy Book";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(81, 118);
            label1.Name = "label1";
            label1.Size = new Size(151, 31);
            label1.TabIndex = 2;
            label1.Text = "Customer_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(81, 260);
            label2.Name = "label2";
            label2.Size = new Size(186, 31);
            label2.TabIndex = 3;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(81, 417);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(680, 162);
            label4.Name = "label4";
            label4.Size = new Size(139, 31);
            label4.TabIndex = 5;
            label4.Text = "Book Name";
            // 
            // submit
            // 
            submit.BackColor = Color.NavajoWhite;
            submit.Location = new Point(514, 530);
            submit.Name = "submit";
            submit.Size = new Size(137, 65);
            submit.TabIndex = 6;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += button1_Click;
            // 
            // customer_id
            // 
            customer_id.Location = new Point(293, 118);
            customer_id.Name = "customer_id";
            customer_id.Size = new Size(263, 27);
            customer_id.TabIndex = 7;
            // 
            // customer_Name
            // 
            customer_Name.Location = new Point(293, 260);
            customer_Name.Name = "customer_Name";
            customer_Name.Size = new Size(263, 27);
            customer_Name.TabIndex = 8;
            // 
            // Address
            // 
            Address.Location = new Point(293, 386);
            Address.Multiline = true;
            Address.Name = "Address";
            Address.Size = new Size(263, 87);
            Address.TabIndex = 9;
            // 
            // book_Name
            // 
            book_Name.Location = new Point(878, 162);
            book_Name.Name = "book_Name";
            book_Name.Size = new Size(229, 27);
            book_Name.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(786, 298);
            label5.Name = "label5";
            label5.Size = new Size(156, 31);
            label5.TabIndex = 11;
            label5.Text = "Do you want ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1154, 697);
            Controls.Add(label5);
            Controls.Add(book_Name);
            Controls.Add(Address);
            Controls.Add(customer_Name);
            Controls.Add(customer_id);
            Controls.Add(submit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button submit;
        private TextBox customer_id;
        private TextBox customer_Name;
        private TextBox Address;
        private TextBox book_Name;
        private Label label5;
    }
}