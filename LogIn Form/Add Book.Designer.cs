namespace LogIn_Form
{
    partial class Add_Book
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.newStat = new System.Windows.Forms.ComboBox();
            this.newQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.newYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.newPublisher = new System.Windows.Forms.TextBox();
            this.newLanguage = new System.Windows.Forms.TextBox();
            this.newGenre = new System.Windows.Forms.TextBox();
            this.newAuthor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.newTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.newStat);
            this.panel1.Controls.Add(this.newQuantity);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.newYear);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.newPublisher);
            this.panel1.Controls.Add(this.newLanguage);
            this.panel1.Controls.Add(this.newGenre);
            this.panel1.Controls.Add(this.newAuthor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelT);
            this.panel1.Controls.Add(this.newTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 596);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(202, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Back to BOOKS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // newStat
            // 
            this.newStat.FormattingEnabled = true;
            this.newStat.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.newStat.Location = new System.Drawing.Point(358, 394);
            this.newStat.Name = "newStat";
            this.newStat.Size = new System.Drawing.Size(144, 29);
            this.newStat.TabIndex = 17;
            // 
            // newQuantity
            // 
            this.newQuantity.Location = new System.Drawing.Point(119, 394);
            this.newQuantity.Multiline = true;
            this.newQuantity.Name = "newQuantity";
            this.newQuantity.Size = new System.Drawing.Size(159, 30);
            this.newQuantity.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "STATUS:";
            // 
            // newYear
            // 
            this.newYear.Location = new System.Drawing.Point(167, 347);
            this.newYear.Multiline = true;
            this.newYear.Name = "newYear";
            this.newYear.Size = new System.Drawing.Size(335, 30);
            this.newYear.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "PUBLISHED YEAR:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(167, 483);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(206, 41);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // newPublisher
            // 
            this.newPublisher.Location = new System.Drawing.Point(131, 300);
            this.newPublisher.Multiline = true;
            this.newPublisher.Name = "newPublisher";
            this.newPublisher.Size = new System.Drawing.Size(371, 30);
            this.newPublisher.TabIndex = 11;
            // 
            // newLanguage
            // 
            this.newLanguage.Location = new System.Drawing.Point(131, 242);
            this.newLanguage.Multiline = true;
            this.newLanguage.Name = "newLanguage";
            this.newLanguage.Size = new System.Drawing.Size(371, 30);
            this.newLanguage.TabIndex = 10;
            // 
            // newGenre
            // 
            this.newGenre.Location = new System.Drawing.Point(358, 185);
            this.newGenre.Multiline = true;
            this.newGenre.Name = "newGenre";
            this.newGenre.Size = new System.Drawing.Size(144, 30);
            this.newGenre.TabIndex = 9;
            // 
            // newAuthor
            // 
            this.newAuthor.Location = new System.Drawing.Point(131, 185);
            this.newAuthor.Multiline = true;
            this.newAuthor.Name = "newAuthor";
            this.newAuthor.Size = new System.Drawing.Size(147, 30);
            this.newAuthor.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "QUANTITY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "GENRE ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "PUBLISHER:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "LANGUAGE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "AUTHOR:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(39, 136);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(45, 21);
            this.labelT.TabIndex = 2;
            this.labelT.Text = "TITLE:";
            // 
            // newTitle
            // 
            this.newTitle.Location = new System.Drawing.Point(131, 127);
            this.newTitle.Multiline = true;
            this.newTitle.Name = "newTitle";
            this.newTitle.Size = new System.Drawing.Size(371, 30);
            this.newTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD BOOK";
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 596);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Book";
            this.Load += new System.EventHandler(this.Add_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.TextBox newTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox newPublisher;
        private System.Windows.Forms.TextBox newLanguage;
        private System.Windows.Forms.TextBox newGenre;
        private System.Windows.Forms.TextBox newAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox newStat;
        private System.Windows.Forms.TextBox newQuantity;
        private System.Windows.Forms.Label label9;
    }
}