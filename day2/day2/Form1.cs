namespace day2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String data = password.Text;

            if (data == "123")
            {
                MessageBox.Show("you are logged in");

            }
            else
            {
                MessageBox.Show("Password error");
            }
        }

        private void userid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}