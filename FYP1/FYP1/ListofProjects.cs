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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace FYP1
{
    public partial class ListofProjects : Form
    {
        public ListofProjects()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=projectA;Integrated Security=True");

        int id = 0;
        private object richTextBox;

        public object Pdfwriter { get; private set; }

        private void ListofProjects_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Project.Title,Project.Description,Advisor.Salary,Lookup.Value,ProjectAdvisor.AssignmentDate,Person.FirstName,Person.LastName,GroupProject.GroupId,[Group].Created_On,GroupStudent.StudentId,Student.RegistrationNo from Project join ProjectAdvisor on ProjectAdvisor.ProjectId=Project.Id join Advisor on Advisor.Id=ProjectAdvisor.AdvisorId join Lookup on Lookup.Id=Advisor.Designation join Person on Person.Id=Advisor.Id join GroupProject on GroupProject.ProjectId=Project.Id join [Group] on [Group].Id=GroupProject.GroupId join GroupStudent on GroupStudent.GroupId=[Group].Id join Student on Student.Id=GroupStudent.StudentId", conn);
            adapter.Fill(dt);
            dataGridList.DataSource = dt;
            //And Lookup.Id = Advisor.Designation
            this.dataGridList.Columns[2].Visible = false;
            this.dataGridList.Columns[4].Visible = false;
            this.dataGridList.Columns[9].Visible = false;
            this.dataGridList.Columns[8].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|* .pdf", ValidateNames = true })
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(dataGridList.ToString()));
                        PdfPTable table = new PdfPTable(dataGridList.Columns.Count);
                        for(int j=0;j<dataGridList.Columns.Count;j++)
                        {
                            table.AddCell(new Phrase(dataGridList.Columns[j].HeaderText));

                        }
                        table.HeaderRows = 1;

                        for(int i=0;i<dataGridList.Rows.Count;i++)
                        {
                            for(int k=0;k<dataGridList.Columns.Count;k++)
                            {
                                if(dataGridList[k,i].Value!=null)
                                {
                                    table.AddCell(new Phrase(dataGridList[k, i].Value.ToString()));
                                }
                            }
                        }
                        doc.Add(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home c = new Home();
            this.Hide();
            c.Show();
        }
    }
}
