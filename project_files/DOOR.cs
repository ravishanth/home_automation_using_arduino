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
    public partial class DOOR : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True");
        SqlCommand cmd;
        public DOOR()
        {
            InitializeComponent();
            //serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("2");
            serialPort1.Write("a");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("SELECT * FROM STATUSDOOR_CLOSE", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adp.Fill(dt, "tbl");
            dataGridView1.DataSource = dt.Tables["tbl"].DefaultView;
            serialPort1.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("3");
            serialPort1.Write("a");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("SELECT * FROM STATUSDOOR_ON ", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adp.Fill(dt, "tbl");
            dataGridView1.DataSource = dt.Tables["tbl"].DefaultView;
            serialPort1.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            USER USER= new USER();
            USER.Show();
        }
    }
}
