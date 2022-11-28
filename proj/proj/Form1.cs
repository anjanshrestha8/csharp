using System.Data.SqlClient;

namespace proj
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection
            ("Data Source = .\\SQLEXPRESS;Initial Catalog = STUDENT;user id =sa; password=kist@123;");
    
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
                {
                    con.Open();
                    string query = "Insert into RESTRO values('2','Burger','200')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Sucessful");
                    con.Close();
                }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }

         
        }
       
    }
}