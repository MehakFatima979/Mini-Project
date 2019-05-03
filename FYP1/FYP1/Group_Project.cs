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
    public partial class Group_Project : Form
    {
        public Group_Project()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DOTOD0U\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");

        int id = 0;

        private void Group_Project_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Project", conn);
            adapter.Fill(dt);
            dataGridProject.DataSource = dt;

            DataTable dt1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter("Select Distinct GroupStudent.GroupId,GroupStudent.AssignmentDate,Student.RegistrationNo,Person.FirstName++Person.LastName as Name from GroupStudent join Student on GroupStudent.StudentID=Student.ID join Person on Person.Id=Student.Id", conn);
            adapter1.Fill(dt1);
            dataGridGroupList.DataSource = dt1;
        }

        private void dataGridGroupList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==0 && e.RowIndex>0)
            {
                if(dataGridGroupList[0,e.RowIndex].Value == dataGridGroupList[0,e.RowIndex-1].Value)
                {
                    e.Value = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtgroupid.Text != "" && txtprojectid.Text != "")
                {
                    conn.Open();
                    string query = "insert into GroupProject(ProjectId,GroupId,AssignmentDate) values ('" + txtprojectid.Text + "','" + txtgroupid.Text + "','" + Convert.ToDateTime(dateTimeassignment.Text).ToString() + "')";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);

                    cdn.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Added Successfully");
                    //DataTable dt = new DataTable();
                    //SqlDataAdapter adapter = new SqlDataAdapter("Select * from Project", conn);
                    //adapter.Fill(dt);
                    //dataGridViewprojects.DataSource = dt;
                    txtgroupid.Text = "";
                    txtprojectid.Text = "";
                    id = 0;
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
