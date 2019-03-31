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
namespace FYP1
{
    public partial class Manage_Evaluation : Form
    {
        public Manage_Evaluation()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home c = new Home();
            this.Hide();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Delete GroupEvaluation where EvaluationId='" + id + "';", conn);

                cmd1.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("Delete Evaluation where id='" + id + "';", conn);
               
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Delete successfully!!");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
                adapter.Fill(dt);
                dataGridevalauation.DataSource = dt;
                txtname.Text = "";
                txttotalmarks.Text = "";
                txtweightage.Text = "";
                id = 0;
            }
            else
            {
                MessageBox.Show("Please Select Data to Delete");
            }
        }

        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=projectA;Integrated Security=True");

        int id = 0;

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != "" && txttotalmarks.Text != "" && txtweightage.Text != "")
                {
                    conn.Open();
                    string query = "insert into Evaluation(Name,TotalMarks,TotalWeightage) values ('" + txtname.Text + "','" + txttotalmarks.Text + "','" + txtweightage.Text + "')";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);

                    cdn.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Added Successfully");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
                    adapter.Fill(dt);
                    dataGridevalauation.DataSource = dt;
                    txtname.Text = "";
                    txttotalmarks.Text = "";
                    txtweightage.Text = "";
                    id = 0;
                }
                else
                {
                    MessageBox.Show("Add all the details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Manage_Evaluation_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
            adapter.Fill(dt);
            dataGridevalauation.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != "" && txttotalmarks.Text != "" && txtweightage.Text != "")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Update Evaluation set Name='" + txtname.Text + "',TotalMarks='" + txttotalmarks.Text + "', TotalWeightage='" + txtweightage.Text + "' where id='" + id + "';", conn);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    conn.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
                    adapter.Fill(dt);
                    dataGridevalauation.DataSource = dt;
                    txtname.Text = "";
                    txttotalmarks.Text = "";
                    txtweightage.Text = "";
                    id = 0;
                }
                else
                {
                    MessageBox.Show("Please provide all Information!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridevalauation_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtname.Text = dataGridevalauation.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtname.Text = dataGridevalauation.Rows[e.RowIndex].Cells[1].Value.ToString();
            txttotalmarks.Text = Convert.ToInt32(dataGridevalauation.Rows[e.RowIndex].Cells[2].Value.ToString()).ToString();
            txtweightage.Text = Convert.ToInt32(dataGridevalauation.Rows[e.RowIndex].Cells[3].Value.ToString()).ToString();
        }

        private void dataGridevalauation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
