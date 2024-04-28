namespace LogIn_Form
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbook_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtauthor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtlanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgenre_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpublication_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbook_stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgbookimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 43);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.buttonBack.TabIndex = 7;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(594, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 28);
            this.label26.TabIndex = 0;
            this.label26.Text = "Books";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 707);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.textsearch);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1283, 664);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(1196, 27);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 30);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // textsearch
            // 
            this.textsearch.AllowDrop = true;
            this.textsearch.Location = new System.Drawing.Point(930, 27);
            this.textsearch.Multiline = true;
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(260, 30);
            this.textsearch.TabIndex = 1;
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
            this.txtbook_id,
            this.txttitle,
            this.txtauthor_name,
            this.txtlanguage,
            this.txtgenre_type,
            this.txtpublisher,
            this.txtpublication_year,
            this.txtquantity,
            this.txtbook_stat,
            this.imgbookimage});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 529);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtbook_id
            // 
            this.txtbook_id.DataPropertyName = "book_id";
            this.txtbook_id.HeaderText = "BOOK ID";
            this.txtbook_id.MinimumWidth = 6;
            this.txtbook_id.Name = "txtbook_id";
            this.txtbook_id.Width = 125;
            // 
            // txttitle
            // 
            this.txttitle.DataPropertyName = "title";
            this.txttitle.HeaderText = "TITLE";
            this.txttitle.MinimumWidth = 6;
            this.txttitle.Name = "txttitle";
            this.txttitle.Width = 125;
            // 
            // txtauthor_name
            // 
            this.txtauthor_name.DataPropertyName = "author";
            this.txtauthor_name.HeaderText = "AUTHOR";
            this.txtauthor_name.MinimumWidth = 6;
            this.txtauthor_name.Name = "txtauthor_name";
            this.txtauthor_name.Width = 125;
            // 
            // txtlanguage
            // 
            this.txtlanguage.DataPropertyName = "language";
            this.txtlanguage.HeaderText = "LANGUAGE";
            this.txtlanguage.MinimumWidth = 6;
            this.txtlanguage.Name = "txtlanguage";
            this.txtlanguage.Width = 125;
            // 
            // txtgenre_type
            // 
            this.txtgenre_type.DataPropertyName = "genre_type";
            this.txtgenre_type.HeaderText = "GENRE";
            this.txtgenre_type.MinimumWidth = 6;
            this.txtgenre_type.Name = "txtgenre_type";
            this.txtgenre_type.Width = 125;
            // 
            // txtpublisher
            // 
            this.txtpublisher.DataPropertyName = "publisher";
            this.txtpublisher.HeaderText = "PUBLISHER";
            this.txtpublisher.MinimumWidth = 6;
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Width = 125;
            // 
            // txtpublication_year
            // 
            this.txtpublication_year.DataPropertyName = "publication_year";
            this.txtpublication_year.HeaderText = "PUBLICATION YEAR";
            this.txtpublication_year.MinimumWidth = 6;
            this.txtpublication_year.Name = "txtpublication_year";
            this.txtpublication_year.Width = 125;
            // 
            // txtquantity
            // 
            this.txtquantity.DataPropertyName = "quantity";
            this.txtquantity.HeaderText = "QUANTITY";
            this.txtquantity.MinimumWidth = 6;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Width = 125;
            // 
            // txtbook_stat
            // 
            this.txtbook_stat.DataPropertyName = "book_stat";
            this.txtbook_stat.HeaderText = "STATUS";
            this.txtbook_stat.MinimumWidth = 6;
            this.txtbook_stat.Name = "txtbook_stat";
            this.txtbook_stat.Width = 125;
            // 
            // imgbookimage
            // 
            this.imgbookimage.DataPropertyName = "bookimage";
            this.imgbookimage.HeaderText = "BOOK IMAGE";
            this.imgbookimage.MinimumWidth = 6;
            this.imgbookimage.Name = "imgbookimage";
            this.imgbookimage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imgbookimage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.imgbookimage.Width = 125;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(545, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "EXPORT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 707);
            this.Controls.Add(this.panel1);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.FormLoad1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtbook_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtauthor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtlanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtgenre_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtpublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtpublication_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtbook_stat;
        private System.Windows.Forms.DataGridViewImageColumn imgbookimage;
        private System.Windows.Forms.Button button2;
    }
}