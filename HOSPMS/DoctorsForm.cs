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
    public partial class DoctorsForm : Form
  
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public DoctorsForm()
        {
            InitializeComponent();
           

        }
        void populate()
        {
            con.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
            { 
            
                MessageBox.Show("No Empty Fill Accepted");
            }

            else
            {
                con.Open();
                string query = "insert into DoctorTbl values(" + DocId.Text + ",'" + DocName.Text + "'," + DocExp.Text + ",'" + DocPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                con.Close();
                populate();

            }
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DocPass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "")
                MessageBox.Show("Enter the Docot ID ");
            else
            {
                con.Open();
                string query = "delete from DoctorTbl where DocId=" + DocId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                con.Close();
                populate();
            }
        }

        private void DoctorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocId.Text = DoctorDGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorDGV.SelectedRows[0].Cells[1].Value.ToString();
            DocExp.Text = DoctorDGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DoctorDGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update  DoctorTbl set DocName='" + DocName.Text + "',DocExp="+DocExp.Text+" ,DocPass='"+DocPass.Text+"' where DocId="+DocId.Text+"";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Successfully updated");
            con.Close();
            populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
