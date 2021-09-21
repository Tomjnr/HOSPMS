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
    public partial class DiagnosisForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        void populatecombo()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("patid",typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatId";
                PatientIdCb.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
        string patname;
        void fetchpatientname()
        {
            con.Open();
            string mysql = "select * from PatientTbl where PatId='"+PatientIdCb.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(mysql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatientNameTb.Text = patname;


            }
            con.Close();
        }
        void populate()
        {
            con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        public DiagnosisForm()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
            if (DiagId.Text == "" || MedicineTb.Text == "" || DiagnosisTb.Text == "" || PatientIdCb.Text == "" ||SymtomsTb.Text=="")
            {

                MessageBox.Show("No Empty Fill Accepted");
            }

            else
            {
                con.Open();
               string query = "insert into DiagnosisTbl values(" + DiagId.Text + ",'" + PatientIdCb.SelectedValue.ToString() + "','" + PatientNameTb.Text + "','" + SymtomsTb.Text + "','" + DiagnosisTb.Text + "','" + MedicineTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Added");
                con.Close();
                populate();

            }
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();

        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpatientname();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
                MessageBox.Show("Enter the Diagnosi ID ");
            else
            {
                con.Open();
                string query = "delete from DiagnosisTbl where DiagId=" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Deleted");
                con.Close();
                populate();
            }
        }

        private void DiagnosisDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisDGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientNameTb.Text = DiagnosisDGV.SelectedRows[0].Cells[2].Value.ToString();
            SymtomsTb.Text = DiagnosisDGV.SelectedRows[0].Cells[3].Value.ToString();
            DiagnosisTb.Text = DiagnosisDGV.SelectedRows[0].Cells[4].Value.ToString();
            MedicineTb.Text = DiagnosisDGV.SelectedRows[0].Cells[5].Value.ToString();
            PatientnameLbl.Text= DiagnosisDGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptomslbl.Text = DiagnosisDGV.SelectedRows[0].Cells[3].Value.ToString();
            Diagnosislbl.Text = DiagnosisDGV.SelectedRows[0].Cells[4].Value.ToString();
            MedicineLbl.Text = DiagnosisDGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update  DiagnosisTbl set PatId='" + PatientIdCb.SelectedValue.ToString() + "' ,PatName='" + PatientNameTb.Text + "',Symptoms='" + SymtomsTb.Text + "',Diagnosis='" + DiagnosisTb.Text + "',Medicines='" + MedicineTb.Text + "' where DiagId='" + DiagId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Successfully updated");
            con.Close();
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label1.Text, new Font("Century Gothic", 25, FontStyle.Regular), Brushes.Red, new Point(230));

            e.Graphics.DrawString(label1.Text+"\n"+PatientnameLbl.Text+ "\n"+Diagnosislbl.Text+ "\n"+Symptomslbl.Text+ "\n"+MedicineLbl.Text, new Font("Century Gothic",12,FontStyle.Regular),Brushes.Black,new Point(130,150));

            e.Graphics.DrawString(label8.Text + "\n\t"+label10.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Red, new Point(230,380));

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
