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
using System.Text.RegularExpressions;
namespace FYP1
{
    public partial class Advisor : Form
    {
        public Advisor()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=projectA;Integrated Security=True");

        int id = 0;

        private void Validate(TextBox textBoxControl)
        {
            Regex rx = new Regex("[^A-Z|^a-z|^ |^\t]");
            if (rx.IsMatch(textBoxControl.Text))
            {
                throw new Exception("First Name and Last Name are only alphabats");
               
            }
        }

        private void ValidateContact(TextBox textBoxControl)
        {
            Regex rx = new Regex(@"^(\+[0-9])$");
            if (rx.IsMatch(textBoxControl.Text))
            {
                throw new Exception("salary must be in digits");

            }
        }
        private void ValidateC(TextBox textBoxControl)
        {
            Regex rx = new Regex(@"^ (\+91[\-\s] ?)\d{ 10}$.");
            if (rx.IsMatch(textBoxControl.Text))
            {
                throw new Exception("Contact No format invalid");

            }
        }

        private void txtEmail_Leave(TextBox txtemail)

        {

            Regex mRegxExpression;

            if (txtemail.Text.Trim() != string.Empty)

            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txtemail.Text.Trim()))

                {

                   throw new Exception("E-mail address format is not correct.");

                 

                }

            }

        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && dateTimedob.Text != "" && txtcontactno.Text != "" && txtsalary.Text != "" && combodesignation.Text != "" && combogender.Text != "")
                {
                    conn.Open();
                    Validate(txtfirstname);
                    Validate(txtlastname);
                    txtEmail_Leave(txtemail);
                    ValidateC(txtcontactno);
                   
                    string query = "insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values ('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtcontactno.Text + "','" + txtemail.Text + "','" + Convert.ToDateTime(dateTimedob.Text).ToString() + "',(select Id from Lookup where Value='" + combogender.Text + "'))";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);
                    cdn.SelectCommand.ExecuteNonQuery();
                    string query1 = "insert into Advisor(Designation,Salary,Id) values((select Id from Lookup where Value='" + combodesignation.Text + "'),'" + txtsalary.Text + "', (Select Id from Person where Contact='" + txtcontactno.Text + "' and LastName='" + txtlastname.Text + "' and Email='" + txtemail.Text + "' and FirstName='" + txtfirstname.Text + "'))";
                    SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
                    cdn1.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Added Successfully");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation , Advisor.Salary from Person join Advisor on Person.Id = Advisor.Id", conn);
                    adapter.Fill(dt);
                    dataGridViewadvisor.DataSource = dt;
                    txtfirstname.Text = "";
                    txtlastname.Text = "";
                    txtemail.Text = "";
                    dateTimedob.Text = "";
                    txtsalary.Text = "";
                    txtcontactno.Text = "";
                    combodesignation.Text = "";
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void Advisor_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Advisor.Designation , Advisor.Salary,Lookup.Value from Person join Advisor on Person.Id = Advisor.Id join Lookup on Lookup.Id=Person.Gender", conn);
            adapter.Fill(dt);
            dataGridViewadvisor.DataSource = dt;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && dateTimedob.Text != "" && txtcontactno.Text != "" && txtsalary.Text != "" /*&& combodesignation.Text != ""*/ && combogender.Text != "")
                {
                    conn.Open();
                    string query = "update Person set FirstName='" + txtfirstname.Text + "',LastName='" + txtlastname.Text + "',Contact='" + txtcontactno.Text + "',Email='" + txtemail.Text + "',DateOfBirth='" + Convert.ToDateTime(dateTimedob.Text).ToString() + "',Gender=(select Id from Lookup Where Value='" + combogender.Text + "') where Id='" + id + "'";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);
                    cdn.SelectCommand.ExecuteNonQuery();
                    string query1 = "update Advisor set Designation=(select Id from Lookup where Value='" + combodesignation.Text + "'),Salary='" + txtsalary.Text + "' where Id='" + id + "'";
                    SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
                    cdn1.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Delete Successfully");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation , Advisor.Salary from Person join Advisor on Person.Id = Advisor.Id", conn);
                    adapter.Fill(dt);
                    dataGridViewadvisor.DataSource = dt;
                    txtfirstname.Text = "";
                    txtlastname.Text = "";
                    txtemail.Text = "";
                    dateTimedob.Text = "";
                    txtsalary.Text = "";
                    txtcontactno.Text = "";
                    combodesignation.Text = "";
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewadvisor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtfirstname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtfirstname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlastname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcontactno.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimedob.Text = Convert.ToDateTime(dataGridViewadvisor.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString();
            combogender.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[8].Value.ToString();
           
            combodesignation.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[6].Value.ToString(); ;
            txtsalary.Text= dataGridViewadvisor.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        string query;
        private void combodesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewadvisor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            query = "select Value from Lookup where Id='" + dataGridViewadvisor.Rows[e.RowIndex].Cells[5].Value.ToString() + "'";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home c = new Home();
            this.Hide();
            c.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && dateTimedob.Text != "" && txtcontactno.Text != "" && txtsalary.Text != "" /*&& combodesignation.Text != ""*/ && combogender.Text != "")
                {
                    conn.Open();
                    string query3 = "delete from ProjectAdvisor where AdvisorId='" + id + "'";
                    SqlDataAdapter cdn3 = new SqlDataAdapter(query3, conn);
                    cdn3.SelectCommand.ExecuteNonQuery();
                    string query = "delete from Person where Id='" + id + "'";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);
                    cdn.SelectCommand.ExecuteNonQuery();
                    string query1 = "delete from Advisor where Id='" + id + "'";
                    SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
                    cdn1.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Delete Successfully");
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation , Advisor.Salary from Person join Advisor on Person.Id = Advisor.Id", conn);
                    adapter.Fill(dt);
                    dataGridViewadvisor.DataSource = dt;
                    txtfirstname.Text = "";
                    txtlastname.Text = "";
                    txtemail.Text = "";
                    dateTimedob.Text = "";
                    txtsalary.Text = "";
                    txtcontactno.Text = "";
                    combodesignation.Text = "";
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
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
