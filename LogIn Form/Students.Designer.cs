﻿namespace LogIn_Form
{
    partial class Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.txtstudent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtphonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtyearblock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtborrowedbooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOptions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnsearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 43);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.datagrid);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 707);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(595, 661);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "EXPORT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datagrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtstudent_id,
            this.txtfirstname,
            this.txtlastname,
            this.txtemail,
            this.txtphonenumber,
            this.txtaddress,
            this.txtcourse,
            this.txtyearblock,
            this.txtcollege,
            this.txtborrowedbooks,
            this.btnOptions});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.Location = new System.Drawing.Point(3, 117);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(1283, 527);
            this.datagrid.TabIndex = 10;
            // 
            // txtstudent_id
            // 
            this.txtstudent_id.DataPropertyName = "student_id";
            this.txtstudent_id.HeaderText = "STUDENT ID";
            this.txtstudent_id.MinimumWidth = 6;
            this.txtstudent_id.Name = "txtstudent_id";
            this.txtstudent_id.Width = 125;
            // 
            // txtfirstname
            // 
            this.txtfirstname.DataPropertyName = "first_name";
            this.txtfirstname.HeaderText = "FIRST NAME";
            this.txtfirstname.MinimumWidth = 6;
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Width = 130;
            // 
            // txtlastname
            // 
            this.txtlastname.DataPropertyName = "last_name";
            this.txtlastname.HeaderText = "LAST NAME";
            this.txtlastname.MinimumWidth = 6;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Width = 125;
            // 
            // txtemail
            // 
            this.txtemail.DataPropertyName = "email";
            this.txtemail.HeaderText = "EMAIL";
            this.txtemail.MinimumWidth = 6;
            this.txtemail.Name = "txtemail";
            this.txtemail.Width = 125;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.DataPropertyName = "phone_number";
            this.txtphonenumber.HeaderText = "PHONE NUMBER";
            this.txtphonenumber.MinimumWidth = 6;
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Width = 125;
            // 
            // txtaddress
            // 
            this.txtaddress.DataPropertyName = "address";
            this.txtaddress.HeaderText = "ADDRESS";
            this.txtaddress.MinimumWidth = 6;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Width = 125;
            // 
            // txtcourse
            // 
            this.txtcourse.DataPropertyName = "course";
            this.txtcourse.HeaderText = "COURSE";
            this.txtcourse.MinimumWidth = 6;
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Width = 125;
            // 
            // txtyearblock
            // 
            this.txtyearblock.DataPropertyName = "year_block";
            this.txtyearblock.HeaderText = "YEAR and BLOCK";
            this.txtyearblock.MinimumWidth = 6;
            this.txtyearblock.Name = "txtyearblock";
            this.txtyearblock.Width = 125;
            // 
            // txtcollege
            // 
            this.txtcollege.DataPropertyName = "college";
            this.txtcollege.HeaderText = "COLLEGE";
            this.txtcollege.MinimumWidth = 6;
            this.txtcollege.Name = "txtcollege";
            this.txtcollege.Width = 125;
            // 
            // txtborrowedbooks
            // 
            this.txtborrowedbooks.DataPropertyName = "borrowedbooks";
            this.txtborrowedbooks.HeaderText = "BORROWED BOOKS";
            this.txtborrowedbooks.MinimumWidth = 6;
            this.txtborrowedbooks.Name = "txtborrowedbooks";
            this.txtborrowedbooks.Width = 125;
            // 
            // btnOptions
            // 
            this.btnOptions.HeaderText = "OPTIONS";
            this.btnOptions.MinimumWidth = 6;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Text = "PRINT";
            this.btnOptions.Width = 125;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(1196, 66);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 30);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(930, 66);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(260, 30);
            this.search.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADD NEW +";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(43, 43);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 707);
            this.Controls.Add(this.panel1);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtstudent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtfirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtphonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtyearblock;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtborrowedbooks;
        private System.Windows.Forms.DataGridViewButtonColumn btnOptions;
        private System.Windows.Forms.Button buttonBack;
    }
}