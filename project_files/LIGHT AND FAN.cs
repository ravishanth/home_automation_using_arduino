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
using System.Data.Common;

namespace HOME3
{
    public partial class LIGHT_AND_FAN : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True");
        SqlCommand cmd;
        public LIGHT_AND_FAN()
        {
            InitializeComponent();

          //  serialPort1.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           serialPort1.Open();
            serialPort1.Write("A");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("SELECT * FROM STATUSLIGHT ", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adp.Fill(dt, "tbl");
            dataGridView1.DataSource = dt.Tables["tbl"].DefaultView;
            serialPort1.Close();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("B");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("SELECT * FROM STATUSLIGHTOFF ", con);
            SqlDataAdapter adp  = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adp.Fill(dt, "tbl");
            dataGridView1.DataSource = dt.Tables["tbl"].DefaultView;
            serialPort1.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            USER USER = new USER();
            USER.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("a");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("SELECT * FROM STATUSFAN_ON ", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adp.Fill(dt, "tbl");
            dataGridView1.DataSource = dt.Tables["tbl"].DefaultView;
            serialPort1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("b");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("SELECT * FROM STATUSFAN_OFF ", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adp.Fill(dt, "tbl");
            dataGridView1.DataSource = dt.Tables["tbl"].DefaultView;
            serialPort1.Close();
        }
    }
}
