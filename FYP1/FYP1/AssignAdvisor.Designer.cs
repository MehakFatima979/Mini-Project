namespace FYP1
{
    partial class AssignAdvisor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridProjectList = new System.Windows.Forms.DataGridView();
            this.dataGridadvisorlist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprojectid = new System.Windows.Forms.TextBox();
            this.txtadvisorid = new System.Windows.Forms.TextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.comboadvisorrole = new System.Windows.Forms.ComboBox();
            this.dateTimedate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridadvisorlist)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProjectList
            // 
            this.dataGridProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProjectList.Location = new System.Drawing.Point(13, 47);
            this.dataGridProjectList.Name = "dataGridProjectList";
            this.dataGridProjectList.Size = new System.Drawing.Size(307, 150);
            this.dataGridProjectList.TabIndex = 0;
            this.dataGridProjectList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProjectList_CellContentClick);
            // 
            // dataGridadvisorlist
            // 
            this.dataGridadvisorlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridadvisorlist.Location = new System.Drawing.Point(394, 47);
            this.dataGridadvisorlist.Name = "dataGridadvisorlist";
            this.dataGridadvisorlist.Size = new System.Drawing.Size(298, 150);
            this.dataGridadvisorlist.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Advisor List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Project Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Advisor Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Advisor Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Assignment";
            // 
            // txtprojectid
            // 
            this.txtprojectid.Location = new System.Drawing.Point(295, 216);
            this.txtprojectid.Name = "txtprojectid";
            this.txtprojectid.Size = new System.Drawing.Size(200, 20);
            this.txtprojectid.TabIndex = 8;
            // 
            // txtadvisorid
            // 
            this.txtadvisorid.Location = new System.Drawing.Point(295, 242);
            this.txtadvisorid.Name = "txtadvisorid";
            this.txtadvisorid.Size = new System.Drawing.Size(200, 20);
            this.txtadvisorid.TabIndex = 9;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(408, 334);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(87, 27);
            this.btnAssign.TabIndex = 12;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // comboadvisorrole
            // 
            this.comboadvisorrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboadvisorrole.FormattingEnabled = true;
            this.comboadvisorrole.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisror",
            "Industry Advisor"});
            this.comboadvisorrole.Location = new System.Drawing.Point(295, 268);
            this.comboadvisorrole.Name = "comboadvisorrole";
            this.comboadvisorrole.Size = new System.Drawing.Size(200, 21);
            this.comboadvisorrole.TabIndex = 13;
            // 
            // dateTimedate
            // 
            this.dateTimedate.Location = new System.Drawing.Point(295, 297);
            this.dateTimedate.Name = "dateTimedate";
            this.dateTimedate.Size = new System.Drawing.Size(200, 20);
            this.dateTimedate.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.dataGridProjectList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimedate);
            this.panel1.Controls.Add(this.dataGridadvisorlist);
            this.panel1.Controls.Add(this.comboadvisorrole);
            this.panel1.Controls.Add(this.btnAssign);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtadvisorid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtprojectid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 439);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(10, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back To Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AssignAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 439);
            this.Controls.Add(this.panel1);
            this.Name = "AssignAdvisor";
            this.Text = "AssignAdvisor";
            this.Load += new System.EventHandler(this.AssignAdvisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridadvisorlist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProjectList;
        private System.Windows.Forms.DataGridView dataGridadvisorlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprojectid;
        private System.Windows.Forms.TextBox txtadvisorid;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox comboadvisorrole;
        private System.Windows.Forms.DateTimePicker dateTimedate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}