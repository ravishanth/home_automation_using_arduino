using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace HOME3
{
    public partial class ADMINLOGIN : Form
    {
        SqlConnection con = new SqlConnection();
        public ADMINLOGIN()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True";
            con.Open();
            String UserName = textBox1.Text;
            String Password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("Select UserName,Password from ADMIN where UserName='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Admin Admin = new Admin();
                Admin.Show();


            }
            else
            {
                MessageBox.Show("Invalid Password");
            }


            con.Close();



        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'home_automationDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.home_automationDataSet.Login);
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-VQ1CFQ3M\\SQLEXPRESS; Initial Catalog = home automation; Integrated Security = True");
            con.Open();
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            USERLOGIN USERLOGIN = new USERLOGIN();
            USERLOGIN.Show();
            this.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration Registration = new Registration();
            Registration.Show();
        }
    }
}
