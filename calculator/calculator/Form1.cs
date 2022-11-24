namespace calculator
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = display.Text + 7;
            }
            else
            {
                string data = display.Text;
                display.Text = data + "7";
            }
            //display.Text = display.Text + 7;
            //display.Text="7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = display.Text + 4;
            }
            else
            {
                string data = display.Text;
                display.Text = data + "4";
            }
            //display.Text = display.Text + 4 ;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal firstnum = result;
            decimal secnum = Convert.ToDecimal(display.Text);
            switch (operate)
            {
                case "+":
                    result = (firstnum +secnum);
                    display.Text = result.ToString();
                    break;
                case "-":
                    result = (firstnum - secnum);
                    display.Text = result.ToString();
                    break;
                case "*":
                    result = (firstnum * secnum);
                    display.Text = result.ToString();
                    break;
                case "/":
                    if (secnum == 0)
                    {
                        MessageBox.Show("ERROR!");
                        break;
                    }
                    else
                    {
                        result = (firstnum / secnum);
                        display.Text = result.ToString();
                        break;
                    }



            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = display.Text + 9;
            }
            else
            {
                string data = display.Text;
                display.Text = data + "9";
            }
            //display.Text = display.Text + 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = display.Text + 1;
            }
            else
            {
                string data = display.Text;
                display.Text = data + "1"
            ;// display.Text = display.Text + 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            display.Text = display.Text + 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
           display.Text=display.Text + ".";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = display.Text + 2;
            }
            else
            {
                string data = display.Text;
                display.Text = data + "2";
            }
            //display.Text = display.Text + 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            GetValue();
            operate = "*";
            display.Text = "*";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            GetValue();
            operate = "/";
            display.Text = "/";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            GetValue();
            operate= "-";
            display.Text = "-";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = display.Text + 5;
            }
            else
            {
                string data = display.Text;
                display.Text = data + "5";
            }
            //display.Text = display.Text + 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = display.Text + 6;
            }
            else
            {
                string data = display.Text;
                display.Text = data + "6";
            }
            //display.Text = display.Text + 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetValue();
            operate= "+";
            display.Text = "+";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = display.Text + 8;
            }
            else
            {
                string data = display.Text;
                display.Text = data + "8";
            }
            //display.Text = display.Text + 8;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            display.Clear();       
        }
        public void GetValue()
        {
            if(display.Text !="" && display.Text !="+" && display.Text !="-" && display.Text !="/" && display.Text != "*" ){
                result = Convert.ToDecimal(display.Text);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            
            if(display.Text =="+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = display.Text + 3;
            }
            else
            {
                string data = display.Text;
                display.Text = data + "3";
            }
            //display.Text = display.Text +3 ;

        }

    }
    
}