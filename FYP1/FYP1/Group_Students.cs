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
    public partial class Group_Students : Form
    {
        public Group_Students()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DOTOD0U\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");

        private void btncopy_Click(object sender, EventArgs e)
        {
            dataGridViewGroup.Rows.Clear();
            foreach(DataGridViewRow item in dataGridViewstudentdetails.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dataGridViewGroup.Rows.Add();
                    dataGridViewGroup.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dataGridViewGroup.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridViewGroup.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    dataGridViewGroup.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                    dataGridViewGroup.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
                    dataGridViewGroup.Rows[n].Cells[5].Value = item.Cells[6].Value.ToString();
                    dataGridViewGroup.Rows[n].Cells[6].Value = item.Cells[7].Value.ToString();
                }

            }
           

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter cdn = new SqlDataAdapter("Select Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.Gender,Person.DateOfBirth,Student.RegistrationNo From Person join Student on Person.Id=Student.Id", conn);
                DataTable dt = new DataTable();
                cdn.Fill(dt);
                dataGridViewstudentdetails.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridViewstudentdetails.Rows.Add();
                    dataGridViewstudentdetails.Rows[n].Cells[0].Value = false;
                    dataGridViewstudentdetails.Rows[n].Cells[1].Value = item["FirstName"].ToString();
                    dataGridViewstudentdetails.Rows[n].Cells[2].Value = item["LastName"].ToString();
                    dataGridViewstudentdetails.Rows[n].Cells[3].Value = item["RegistrationNo"].ToString();
                    dataGridViewstudentdetails.Rows[n].Cells[4].Value = item["Contact"].ToString();
                    dataGridViewstudentdetails.Rows[n].Cells[5].Value = item["Email"].ToString();
                    dataGridViewstudentdetails.Rows[n].Cells[6].Value = item["Gender"].ToString();
                    dataGridViewstudentdetails.Rows[n].Cells[7].Value = item["DateOfBirth"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewstudentdetails_MouseClick(object sender, MouseEventArgs e)
        {
            if((bool)dataGridViewstudentdetails.SelectedRows[0].Cells[0].Value==false)
            {
                dataGridViewstudentdetails.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridViewstudentdetails.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                string query = "insert into [Group](Created_On) values ('" + Convert.ToDateTime(dateTimeCreated.Text).ToString() + "') ";
                SqlDataAdapter cdn = new SqlDataAdapter(query, conn);
                cdn.SelectCommand.ExecuteNonQuery();
                for (int i = 0; i < dataGridViewGroup.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into GroupStudent(GroupId,StudentId,Status,AssignmentDate) Values((select max(Id) from [Group] where Created_On='" + Convert.ToDateTime(dateTimeCreated.Text).ToString() + "'),(select Id from Student where RegistrationNo='" + dataGridViewGroup.Rows[i].Cells[2].Value.ToString() + "'),(Select Id from Lookup where Value='" + comboBoxcreated.Text + "'),'" + Convert.ToDateTime(dateTimeassignment.Text).ToString() + "')", conn);

                    cmd.ExecuteNonQuery();

                }
                dataGridViewGroup.Rows.Clear();
                conn.Close();
                MessageBox.Show("Groups are Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewstudentdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewGroup.CurrentCell.RowIndex;
            dataGridViewGroup.Rows.RemoveAt(rowindex);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home c = new Home();
            this.Hide();
            c.Show();
        }

        private void Group_Students_Load(object sender, EventArgs e)
        {

        }
    }
}
