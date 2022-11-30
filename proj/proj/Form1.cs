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
                    MessageBox.Show("Insert Sucessful");
                    con.Close();
                }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update RESTRO set MENU_ITEM = 'MOM02' WHERE ID=2";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Sucessful");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.InnerException);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete  from RESTRO WHERE ID =2";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Sucessful.");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.InnerException);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { "1", "Anish" };
            Display.Rows.Add(row);
            row = new string[] { "2", "Anjan" };
            Display.Rows.Add(row);
            row = new string[] { "3", "pUKar" };
           Display.Rows.Add(row);
            row = new string[] { "4", "ram" };
            Display.Rows.Add(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            {
                con.Open();
                string query = "insert into RESTRO values'1','anjan'";
                SqlCommand cmd = new SqlCommand(query,con);
                MessageBox.Show("Data Shown");
                con.Close();
            }
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string data = id.Text;
            string data1 = name.Text;
            Display.Rows.Add(data, data1);
        }
    }
}