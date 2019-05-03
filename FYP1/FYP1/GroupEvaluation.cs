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
    public partial class GroupEvaluation : Form
    {
        public GroupEvaluation()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DOTOD0U\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");

        int id = 0;
        private void btndone_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtgroup.Text != "" && txtevaluation.Text != "" && txtmarks.Text != "")
                {
                    conn.Open();
                    string query = "insert into GroupEvaluation(GroupId,EvaluationId,ObtainedMarks,EvaluationDate) values ('" + txtgroup.Text + "','" + txtevaluation.Text + "','" + txtmarks.Text + "','" + Convert.ToDateTime(dateTimedate.Text).ToString() + "')";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);

                    cdn.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Added Successfully");
                    //DataTable dt = new DataTable();
                    //SqlDataAdapter adapter = new SqlDataAdapter("Select * from Project", conn);
                    //adapter.Fill(dt);
                    //dataGridViewprojects.DataSource = dt;
                    txtgroup.Text = "";
                    txtevaluation.Text = "";
                    txtmarks.Text = "";
                    id = 0;
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Please Provide complete information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select [Group].*,GroupStudent.AssignmentDate,Student.RegistrationNo from [Group] join GroupStudent on [Group].Id=GroupStudent.GroupId join Student on GroupStudent.StudentId=Student.Id", conn);
                adapter.Fill(dt);
                dataGridGroplist.DataSource = dt;

                DataTable dt1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter("Select * from Evaluation", conn);
                adapter1.Fill(dt1);
                dataGridEvaluation.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home c = new Home();
            this.Hide();
            c.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home c = new Home();
            this.Hide();
            c.Show();
        }
    }
}
