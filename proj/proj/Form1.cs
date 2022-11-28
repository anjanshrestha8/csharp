using System.Data.SqlClient;

namespace proj
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection
            ("Data Source = .\\SQLEXPRESS;Initial Catalog = STUDENT;user id =sa; password=anjan;");
    
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
        }
    }
}