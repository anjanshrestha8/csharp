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
                this.Hide();
                employeeform object_name = new employeeform();
                object_name.ShowDialog();

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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                submit.PerformClick();
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}