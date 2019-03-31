namespace FYP1
{
    partial class ListofProjects
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
            this.dataGridList = new System.Windows.Forms.DataGridView();
            this.btnpdf = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridList
            // 
            this.dataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridList.Location = new System.Drawing.Point(12, 70);
            this.dataGridList.Name = "dataGridList";
            this.dataGridList.Size = new System.Drawing.Size(592, 369);
            this.dataGridList.TabIndex = 0;
            // 
            // btnpdf
            // 
            this.btnpdf.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdf.Location = new System.Drawing.Point(12, 29);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(143, 35);
            this.btnpdf.TabIndex = 1;
            this.btnpdf.Text = "Generate PDF";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back To Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ListofProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 451);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.dataGridList);
            this.Name = "ListofProjects";
            this.Text = "ListofProjects";
            this.Load += new System.EventHandler(this.ListofProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridList;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}