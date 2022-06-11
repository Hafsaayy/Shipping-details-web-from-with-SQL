using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QUESTION_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            string fname;
            string lname;
            string street;
            string city;
            string state;
            int zip;
            int ccno;
            int exp;
            int ccvv;

            fname = textBox1.Text;
            lname = textBox2.Text;
            city = textBox3.Text;
            street = textBox4.Text;
           state= textBox5.Text;
            
            zip = int.Parse(textBox6.Text);
            ccvv = int.Parse(textBox9.Text);
            ccno = int.Parse(textBox7.Text);
            exp = int.Parse(textBox8.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=HAFSA-LAPTOP\\SQLEXPRESS01;DataBase=project;Integrated Security=SSPI";
            con.Open();

            Console.WriteLine("Connected");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into table2(fname,lname,street,city,state,zip,ccno,exp,ccvv) values('" + fname + "','" + lname + "','" + street + "','" + city+ "','" + state + "','" + zip + "','" + ccno+ "','" + exp + "','" + ccvv + "');";
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Inserted");

            }
            else if (i == 0)
            {
                MessageBox.Show("Not Inserted");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
