using System.Data.SqlClient;
using System.Data;
namespace emplyee
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-L7GGU9H\SQLEXPRESS;
                                                Initial Catalog=employeetable;
                                                user id= sa;password= kist@123;");
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-L7GGU9H\SQLEXPRESS;
                                                Initial Catalog=employeetable;
                                                user id= sa;password= kist@123;");

            con.Open();

            string Query = "select * from employeetable";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into employeetable values('" + textBox1.Text +"," + textBox2.Text
                + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}