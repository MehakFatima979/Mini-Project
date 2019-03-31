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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=projectA;Integrated Security=True");

        int id = 0;
        private void Student_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo, Lookup.Value from Person join Student on Person.Id = Student.Id join Lookup on Lookup.Id=Person.Gender", conn);
            adapter.Fill(dt);
            dataGridStudentdetail.DataSource = dt;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && txtdob.Text != "")
                {
                    conn.Open();
                    string query = "insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values ('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtcontactno.Text + "','" + txtemail.Text + "','" + Convert.ToDateTime(txtdob.Text).ToString() + "',(select Id from Lookup where Value='" + combogender.Text + "'))";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);
                    cdn.SelectCommand.ExecuteNonQuery();
                    string query1 = "insert into Student(RegistrationNo, Id) values('" + txtregno.Text + "', (Select Id from Person where Contact='" + txtcontactno.Text + "' and LastName='" + txtlastname.Text + "' and Email='" + txtemail.Text + "' and FirstName='" + txtfirstname.Text + "'))";
                    SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
                    cdn1.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Added Successfully");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo, Lookup.Value from Person join Student on Person.Id = Student.Id join Lookup on Lookup.Id=Person.Gender ", conn);
                    adapter.Fill(dt);
                    dataGridStudentdetail.DataSource = dt;
                    txtfirstname.Text = "";
                    txtlastname.Text = "";
                    txtemail.Text = "";
                    txtdob.Text = "";
                    txtregno.Text = "";
                    txtcontactno.Text = "";
                    combogender.Text = "";

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

        private void dataGridStudentdetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridStudentdetail_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridStudentdetail_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridStudentdetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtfirstname.Text =dataGridStudentdetail.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtfirstname.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlastname.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcontactno.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtdob.Text = Convert.ToDateTime(dataGridStudentdetail.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString();
            combogender.Text =dataGridStudentdetail.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtregno.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && txtcontactno.Text != "")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Update Person Set [FirstName]='" + txtfirstname.Text + "', [LastName] ='" + txtlastname.Text + "',Contact = '" + txtcontactno.Text + "',Email='" + txtemail.Text + "', DateOfBirth='" + Convert.ToDateTime(txtdob.Text).ToString() + "',Gender=(select Id from Lookup where Value='" + combogender.Text + "') where id='" + id + "'", conn);

                    command.ExecuteNonQuery();

                    SqlCommand command1 = new SqlCommand("Update Student set [RegistrationNo]='" + txtregno.Text + "' where Id=(select Id from Person where [FirstName]='" + txtfirstname.Text + "' and [LastName] ='" + txtlastname.Text + "' and Contact = '" + txtcontactno.Text + "' and Email='" + txtemail.Text + "' and DateOfBirth='" + Convert.ToDateTime(txtdob.Text).ToString() + "' and Gender=(select Id from Lookup where Value='" + combogender.Text + "'))", conn);

                    command1.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    conn.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo, Lookup.Value from Person join Student on Person.Id = Student.Id join Lookup on Lookup.Id=Person.Gender ", conn);
                    adapter.Fill(dt);
                    dataGridStudentdetail.DataSource = dt;
                    txtlastname.Text = "";
                    txtfirstname.Text = "";
                    txtemail.Text = "";
                    combogender.Text = "";
                    txtcontactno.Text = "";
                    txtregno.Text = "";
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && txtcontactno.Text != "")
                {

                    conn.Open();
                    //string query1 = "delete from GroupStudent where Id='"+id+"'";
                    //SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
                    //cdn1.SelectCommand.ExecuteNonQuery();
                    string query3 = "delete from GroupStudent where StudentId='" + id + "' ";
                    SqlCommand cmd3 = new SqlCommand(query3, conn);


                    cmd3.ExecuteNonQuery();
                    string query = "delete from Student where RegistrationNo='" + txtregno.Text + "' ";
                    SqlCommand cmd2 = new SqlCommand(query, conn);


                    cmd2.ExecuteNonQuery();
                    string query2 = "Delete from Person where FirstName='" + txtfirstname.Text + "'and LastName='" + txtlastname.Text + "' and Email='" + txtemail.Text + "' and Contact='" + txtcontactno.Text + "' and DateOfBirth='" + Convert.ToDateTime(txtdob.Text).ToString() + "' and Email='" + txtemail.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(query2, conn);


                    cmd1.ExecuteNonQuery();



                    conn.Close();
                    MessageBox.Show("Data Delete successfully!!");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo, Lookup.Value from Person join Student on Person.Id = Student.Id join Lookup on Lookup.Id=Person.Gender ", conn);
                    adapter.Fill(dt);
                    dataGridStudentdetail.DataSource = dt;
                    txtlastname.Text = "";
                    txtfirstname.Text = "";
                    txtemail.Text = "";
                    combogender.Text = "";
                    txtcontactno.Text = "";
                    txtregno.Text = "";
                    id = 0;
                }
                else
                {
                    MessageBox.Show("Please Select Data to Delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
       
        private void combogender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conn.Open();
            //query1 = "Select Id from Lookup where Value='"+combogender.Text+"';";
            //conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home c = new Home();
            this.Hide();
            c.Show();
        }
    }
}
