namespace LogIn_Form
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelPic = new System.Windows.Forms.Panel();
            this.pictureReading = new System.Windows.Forms.PictureBox();
            this.pictureBook = new System.Windows.Forms.PictureBox();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).BeginInit();
            this.panelAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.panelPic);
            this.panel1.Controls.Add(this.panelAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 566);
            this.panel1.TabIndex = 4;
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonBack.Location = new System.Drawing.Point(3, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(39, 40);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelPic
            // 
            this.panelPic.Controls.Add(this.pictureReading);
            this.panelPic.Controls.Add(this.pictureBook);
            this.panelPic.Location = new System.Drawing.Point(12, 49);
            this.panelPic.Name = "panelPic";
            this.panelPic.Size = new System.Drawing.Size(484, 469);
            this.panelPic.TabIndex = 5;
            // 
            // pictureReading
            // 
            this.pictureReading.Image = ((System.Drawing.Image)(resources.GetObject("pictureReading.Image")));
            this.pictureReading.Location = new System.Drawing.Point(279, 111);
            this.pictureReading.Name = "pictureReading";
            this.pictureReading.Size = new System.Drawing.Size(202, 248);
            this.pictureReading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureReading.TabIndex = 1;
            this.pictureReading.TabStop = false;
            // 
            // pictureBook
            // 
            this.pictureBook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBook.Image")));
            this.pictureBook.Location = new System.Drawing.Point(3, 36);
            this.pictureBook.Name = "pictureBook";
            this.pictureBook.Size = new System.Drawing.Size(374, 389);
            this.pictureBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBook.TabIndex = 0;
            this.pictureBook.TabStop = false;
            // 
            // panelAbout
            // 
            this.panelAbout.Controls.Add(this.label1);
            this.panelAbout.Controls.Add(this.labelTitle);
            this.panelAbout.Location = new System.Drawing.Point(513, 63);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(351, 437);
            this.panelAbout.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 168);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(114, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(122, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "About";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(876, 566);
            this.Controls.Add(this.panel1);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.panelPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureReading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).EndInit();
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPic;
        private System.Windows.Forms.PictureBox pictureReading;
        private System.Windows.Forms.PictureBox pictureBook;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonBack;
    }
}