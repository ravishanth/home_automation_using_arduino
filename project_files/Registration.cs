using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HOME3
{
    public partial class Registration : Form
    {
        string connectionString = "Data Source=LAPTOP-VQ1CFQ3M\\SQLEXPRESS;Initial Catalog=home automation;Integrated Security=True";

        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
                MessageBox.Show("Please fill mandatory fields");
            else if (textBox3.Text != textBox4.Text)
                MessageBox.Show("Password donot match");
            else
            {




                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    var sql = "INSERT INTO LOGINUSER(USERNAME,PASSWORD) VALUES(@UserName, @Password)";
                    using (var cmd = new SqlCommand(sql, sqlCon))
                    {
                        //SqlCommand sqlcmd = new SqlCommand("sp_insert_Registration", sqlCon);
                        //sqlcmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", textBox1.Text.Trim());
                       // cmd.Parameters.AddWithValue("@Name", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", textBox3.Text.Trim());
                      //  cmd.Parameters.AddWithValue("@ConfirmPwd", textBox4.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration is successfull");
                        Clear();
                    }

                }
            }

            }

            void Clear()
            {
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";

            }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            USERLOGIN USERLOGIN = new USERLOGIN();
            USERLOGIN.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            USERLOGIN USERLOGIN = new USERLOGIN();
            USERLOGIN.Show();
        }
    }
    }
