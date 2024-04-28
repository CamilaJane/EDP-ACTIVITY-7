namespace LogIn_Form
{
    partial class Transaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txttransaction_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtstudent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbook_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtborrow_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtreturn_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtoverduefee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpayment_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOptions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 43);
            this.panel1.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(588, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(137, 28);
            this.label26.TabIndex = 1;
            this.label26.Text = "Transactions";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(1189, 70);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 30);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(923, 70);
            this.textsearch.Multiline = true;
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(260, 30);
            this.textsearch.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txttransaction_id,
            this.txtstudent_id,
            this.txtfirstname,
            this.txtlastname,
            this.txtbook_id,
            this.txtborrow_date,
            this.txtdue_date,
            this.txtreturn_date,
            this.txtstatus,
            this.txtoverduefee,
            this.txtpayment_status,
            this.btnOptions});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(0, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 527);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txttransaction_id
            // 
            this.txttransaction_id.DataPropertyName = "transaction_id";
            this.txttransaction_id.HeaderText = "TRANSACTION ID";
            this.txttransaction_id.MinimumWidth = 6;
            this.txttransaction_id.Name = "txttransaction_id";
            this.txttransaction_id.Width = 125;
            // 
            // txtstudent_id
            // 
            this.txtstudent_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtstudent_id.DataPropertyName = "student_id";
            this.txtstudent_id.HeaderText = "STUDENT ID";
            this.txtstudent_id.MinimumWidth = 6;
            this.txtstudent_id.Name = "txtstudent_id";
            this.txtstudent_id.Width = 125;
            // 
            // txtfirstname
            // 
            this.txtfirstname.DataPropertyName = "firstname";
            this.txtfirstname.HeaderText = "FIRST NAME";
            this.txtfirstname.MinimumWidth = 6;
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Width = 130;
            // 
            // txtlastname
            // 
            this.txtlastname.DataPropertyName = "lastname";
            this.txtlastname.HeaderText = "LAST NAME";
            this.txtlastname.MinimumWidth = 6;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Width = 125;
            // 
            // txtbook_id
            // 
            this.txtbook_id.DataPropertyName = "book_id";
            this.txtbook_id.HeaderText = "BOOK ID";
            this.txtbook_id.MinimumWidth = 6;
            this.txtbook_id.Name = "txtbook_id";
            this.txtbook_id.Width = 125;
            // 
            // txtborrow_date
            // 
            this.txtborrow_date.DataPropertyName = "borrow_date";
            this.txtborrow_date.HeaderText = "BORROW DATE";
            this.txtborrow_date.MinimumWidth = 6;
            this.txtborrow_date.Name = "txtborrow_date";
            this.txtborrow_date.Width = 125;
            // 
            // txtdue_date
            // 
            this.txtdue_date.DataPropertyName = "due_date";
            this.txtdue_date.HeaderText = "DUE DATE";
            this.txtdue_date.MinimumWidth = 6;
            this.txtdue_date.Name = "txtdue_date";
            this.txtdue_date.Width = 125;
            // 
            // txtreturn_date
            // 
            this.txtreturn_date.DataPropertyName = "return_date";
            this.txtreturn_date.HeaderText = "RETURN DATE";
            this.txtreturn_date.MinimumWidth = 6;
            this.txtreturn_date.Name = "txtreturn_date";
            this.txtreturn_date.Width = 125;
            // 
            // txtstatus
            // 
            this.txtstatus.DataPropertyName = "status";
            this.txtstatus.HeaderText = "STATUS";
            this.txtstatus.MinimumWidth = 6;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Width = 125;
            // 
            // txtoverduefee
            // 
            this.txtoverduefee.DataPropertyName = "overduefee";
            this.txtoverduefee.HeaderText = "OVERDUE FEE";
            this.txtoverduefee.MinimumWidth = 6;
            this.txtoverduefee.Name = "txtoverduefee";
            this.txtoverduefee.Width = 125;
            // 
            // txtpayment_status
            // 
            this.txtpayment_status.DataPropertyName = "payment_status";
            this.txtpayment_status.HeaderText = "PAYMENT STATUS";
            this.txtpayment_status.MinimumWidth = 6;
            this.txtpayment_status.Name = "txtpayment_status";
            this.txtpayment_status.Width = 125;
            // 
            // btnOptions
            // 
            this.btnOptions.HeaderText = "OPTIONS";
            this.btnOptions.MinimumWidth = 6;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Text = "PRINT";
            this.btnOptions.Width = 125;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(593, 661);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 34);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD NEW +";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 43);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1283, 707);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.panel1);
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttransaction_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtstudent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtfirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtbook_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtborrow_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtdue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtreturn_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtoverduefee;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtpayment_status;
        private System.Windows.Forms.DataGridViewButtonColumn btnOptions;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}