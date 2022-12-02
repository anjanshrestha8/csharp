using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day2
{
    public partial class employeeform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;
                                               Initial catalog=STUDENT; 
                                               user id=sa;password=kist@123;");

        public employeeform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            con.Open();
            using (SqlCommand command = con.CreateCommand())
            {
                string data1 = fname.Text;
                string data2 = mname.Text;
                string data3 = lname.Text;
                string data4 = ss.Text;
                string cono = cno.Text;
                string query = "INSERT INTO DATA([First Name],[Middle Name], [Last Name],[DOB],[Contact]) " +
                               "Values('" + data1 + "','" + data2 + "','" + data3 + "','" + data4+ "','" + cono + "' )";
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Transition Updatet Sucessfully");
        }
        additional object_name = new additional();



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
