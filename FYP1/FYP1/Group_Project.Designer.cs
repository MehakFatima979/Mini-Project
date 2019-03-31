namespace FYP1
{
    partial class Group_Project
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
            this.dataGridProject = new System.Windows.Forms.DataGridView();
            this.dataGridGroupList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprojectid = new System.Windows.Forms.TextBox();
            this.txtgroupid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeassignment = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroupList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProject
            // 
            this.dataGridProject.AllowUserToAddRows = false;
            this.dataGridProject.AllowUserToDeleteRows = false;
            this.dataGridProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProject.Location = new System.Drawing.Point(3, 43);
            this.dataGridProject.Name = "dataGridProject";
            this.dataGridProject.ReadOnly = true;
            this.dataGridProject.Size = new System.Drawing.Size(330, 150);
            this.dataGridProject.TabIndex = 0;
            // 
            // dataGridGroupList
            // 
            this.dataGridGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGroupList.Location = new System.Drawing.Point(398, 43);
            this.dataGridGroupList.Name = "dataGridGroupList";
            this.dataGridGroupList.Size = new System.Drawing.Size(292, 150);
            this.dataGridGroupList.TabIndex = 1;
            this.dataGridGroupList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridGroupList_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projects List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Group List";
            // 
            // txtprojectid
            // 
            this.txtprojectid.Location = new System.Drawing.Point(254, 204);
            this.txtprojectid.Name = "txtprojectid";
            this.txtprojectid.Size = new System.Drawing.Size(200, 20);
            this.txtprojectid.TabIndex = 5;
            // 
            // txtgroupid
            // 
            this.txtgroupid.Location = new System.Drawing.Point(254, 236);
            this.txtgroupid.Name = "txtgroupid";
            this.txtgroupid.Size = new System.Drawing.Size(200, 20);
            this.txtgroupid.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ProjectId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "GroupId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Assignment Date";
            // 
            // dateTimeassignment
            // 
            this.dateTimeassignment.Location = new System.Drawing.Point(254, 270);
            this.dateTimeassignment.Name = "dateTimeassignment";
            this.dateTimeassignment.Size = new System.Drawing.Size(200, 20);
            this.dateTimeassignment.TabIndex = 10;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(340, 316);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(114, 29);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Assign Projects";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BackToHome";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridProject);
            this.panel1.Controls.Add(this.dataGridGroupList);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimeassignment);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtgroupid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtprojectid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 480);
            this.panel1.TabIndex = 13;
            // 
            // Group_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Group_Project";
            this.Text = "Group_Project";
            this.Load += new System.EventHandler(this.Group_Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroupList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProject;
        private System.Windows.Forms.DataGridView dataGridGroupList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprojectid;
        private System.Windows.Forms.TextBox txtgroupid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeassignment;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}