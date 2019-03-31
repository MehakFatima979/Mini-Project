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
    public partial class AssignAdvisor : Form
    {
        public AssignAdvisor()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=projectA;Integrated Security=True");

        int id = 0;

        private void AssignAdvisor_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Project", conn);
            adapter.Fill(dt);
            dataGridProjectList.DataSource = dt;

            DataTable dt1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter("Select Advisor.Id,Advisor.Designation,Person.FirstName,Person.LastName from Advisor join Person on Advisor.Id=Person.Id", conn);
            adapter1.Fill(dt1);
            dataGridadvisorlist.DataSource = dt1;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtadvisorid.Text != "" && txtprojectid.Text != "" && comboadvisorrole.Text != "")
                {
                    conn.Open();
                    string query = "insert into ProjectAdvisor(ProjectId,AdvisorId,AdvisorRole,AssignmentDate) values ('" + txtprojectid.Text + "','" + txtadvisorid.Text + "',(select Id from Lookup where Value='" + comboadvisorrole.Text + "'),'" + Convert.ToDateTime(dateTimedate.Text).ToString() + "')";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);

                    cdn.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Added Successfully");
                    //DataTable dt = new DataTable();
                    //SqlDataAdapter adapter = new SqlDataAdapter("Select * from Project", conn);
                    //adapter.Fill(dt);
                    //dataGridViewprojects.DataSource = dt;
                    txtadvisorid.Text = "";
                    txtprojectid.Text = "";
                    comboadvisorrole.Text = "";
                    id = 0;
                }
                else
                {
                    MessageBox.Show("Please Provide complete information");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridProjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
