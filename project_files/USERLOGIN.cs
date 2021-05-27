using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;



namespace HOME3
{
    public partial class USERLOGIN : Form
    {
        SqlConnection con = new SqlConnection();
        public USERLOGIN()
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
            SqlCommand cmd = new SqlCommand("Select UserName,Password from LOGINUSER where UserName='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                USER USER = new USER();
                USER.Show();


            }
            else
            {
                MessageBox.Show("Invalid Password");
            }


            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMINLOGIN ADMINLOGIN = new ADMINLOGIN();
            ADMINLOGIN.Show();

        }

        private void ADMINLOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
