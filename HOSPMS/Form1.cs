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
namespace HOSPMS
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DocNameTb.Text==""||PassTb.Text=="")
            {
                MessageBox.Show("Enter UserName and Password");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DoctorTbl where DocName='"+DocNameTb.Text+"' and DocPass='"+PassTb.Text+"'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Name or Password");

                }
                con.Close();
            }
        }

        private void HMS_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DocNameTb.Text = "";
            PassTb.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
