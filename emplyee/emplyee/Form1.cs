using System.Data.SqlClient;
using System.Data;
namespace emplyee
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-L7GGU9H\SQLEXPRESS;
                                                Initial Catalog=employee;
                                                user id=sa;password=kist@123;");
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
                                                Initial Catalog=employee;
                                                user id=sa;password=kist@123;");

            con.Open();

            string Query = "select * from studentdetails";
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
            string query = "Insert into studentdetails values('" + textBox2.Text
                + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
        }
    }
}