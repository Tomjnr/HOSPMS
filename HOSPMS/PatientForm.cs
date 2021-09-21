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
    public partial class PatientForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");

        public PatientForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatAddress.Text == "" || PatPhone.Text == "" || PatAge.Text == ""||MajorTb.Text=="")
            {

                MessageBox.Show("No Empty Fill Accepted");
            }

            else
            {
                con.Open();
                string query = "insert into patientTbl values('" + PatId.Text.ToString() + "','" + PatName.Text + "','" + PatAddress.Text + "'," + PatPhone.Text + ","+PatAge.Text+",'"+PatGender.SelectedItem.ToString()+"','"+PatBlood.SelectedItem.ToString()+"','"+MajorTb.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                con.Close();
                populate();

            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update  PatientTbl set PatName='" + PatName.Text + "',PatAddress='" + PatAddress.Text + "' ,Patphone='" + PatPhone.Text + "',PatAge="+PatAge.Text+",PatGender='"+PatGender.SelectedItem.ToString()+"',PatBlood='"+PatBlood.SelectedItem.ToString()+"',PatDisease='"+MajorTb.Text+"' where PatId='" + PatId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("patient Successfully updated");
            con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
                MessageBox.Show("Enter the Docot ID ");
            else
            {
                con.Open();
                string query = "delete from PatientTbl where PatId='" + PatId.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                con.Close();
                populate();
            }
        }

        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientDGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAddress.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientDGV.SelectedRows[0].Cells[4].Value.ToString();
            PatGender.Text = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            PatBlood.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            MajorTb.Text = PatientDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
