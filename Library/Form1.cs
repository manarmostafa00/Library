namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //Librarian form link with main form
        {
            Form2 f = new Form2();
            f.ShowDialog();

             
        }

        private void Form1_Load(object sender, EventArgs e)   
        {
            this.Text = "Library Management Form";
        }

        private void button2_Click(object sender, EventArgs e) //customer form link with main form
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
