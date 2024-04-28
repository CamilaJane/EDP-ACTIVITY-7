namespace LogIn_Form
{
    partial class Create
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
            this.gender = new System.Windows.Forms.Label();
            this.newGender = new System.Windows.Forms.ComboBox();
            this.newBirth = new System.Windows.Forms.TextBox();
            this.BDate = new System.Windows.Forms.Label();
            this.newLastName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.newFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Label();
            this.bttnClear = new System.Windows.Forms.Button();
            this.bttnCreate = new System.Windows.Forms.Button();
            this.newUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.newGender);
            this.panel1.Controls.Add(this.newBirth);
            this.panel1.Controls.Add(this.BDate);
            this.panel1.Controls.Add(this.newLastName);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.newFirstName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.newEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.newPass);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.bttnClear);
            this.panel1.Controls.Add(this.bttnCreate);
            this.panel1.Controls.Add(this.newUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 596);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(354, 259);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(63, 17);
            this.gender.TabIndex = 23;
            this.gender.Text = "Gender";
            // 
            // newGender
            // 
            this.newGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.newGender.FormattingEnabled = true;
            this.newGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.newGender.Location = new System.Drawing.Point(357, 279);
            this.newGender.Name = "newGender";
            this.newGender.Size = new System.Drawing.Size(156, 25);
            this.newGender.TabIndex = 22;
            // 
            // newBirth
            // 
            this.newBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.newBirth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBirth.ForeColor = System.Drawing.Color.Black;
            this.newBirth.Location = new System.Drawing.Point(29, 279);
            this.newBirth.Multiline = true;
            this.newBirth.Name = "newBirth";
            this.newBirth.Size = new System.Drawing.Size(232, 28);
            this.newBirth.TabIndex = 21;
            this.newBirth.TextChanged += new System.EventHandler(this.newBirth_TextChanged);
            // 
            // BDate
            // 
            this.BDate.AutoSize = true;
            this.BDate.Location = new System.Drawing.Point(26, 259);
            this.BDate.Name = "BDate";
            this.BDate.Size = new System.Drawing.Size(76, 17);
            this.BDate.TabIndex = 20;
            this.BDate.Text = "Birthdate";
            // 
            // newLastName
            // 
            this.newLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.newLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLastName.ForeColor = System.Drawing.Color.Black;
            this.newLastName.Location = new System.Drawing.Point(368, 106);
            this.newLastName.Multiline = true;
            this.newLastName.Name = "newLastName";
            this.newLastName.Size = new System.Drawing.Size(145, 28);
            this.newLastName.TabIndex = 19;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(277, 111);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(85, 17);
            this.lName.TabIndex = 18;
            this.lName.Text = "Last Name";
            // 
            // newFirstName
            // 
            this.newFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.newFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFirstName.ForeColor = System.Drawing.Color.Black;
            this.newFirstName.Location = new System.Drawing.Point(116, 106);
            this.newFirstName.Multiline = true;
            this.newFirstName.Name = "newFirstName";
            this.newFirstName.Size = new System.Drawing.Size(145, 28);
            this.newFirstName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "First Name";
            // 
            // newEmail
            // 
            this.newEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.newEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmail.ForeColor = System.Drawing.Color.Black;
            this.newEmail.Location = new System.Drawing.Point(29, 169);
            this.newEmail.Multiline = true;
            this.newEmail.Name = "newEmail";
            this.newEmail.Size = new System.Drawing.Size(232, 28);
            this.newEmail.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(368, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // newPass
            // 
            this.newPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.newPass.Location = new System.Drawing.Point(122, 218);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(236, 25);
            this.newPass.TabIndex = 12;
            this.newPass.UseSystemPasswordChar = true;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.IndianRed;
            this.back.Location = new System.Drawing.Point(209, 471);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 20);
            this.back.TabIndex = 11;
            this.back.Text = "Back to Log In";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.BackColor = System.Drawing.Color.White;
            this.bttnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClear.ForeColor = System.Drawing.Color.IndianRed;
            this.bttnClear.Location = new System.Drawing.Point(156, 416);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(236, 42);
            this.bttnClear.TabIndex = 10;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = false;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // bttnCreate
            // 
            this.bttnCreate.BackColor = System.Drawing.Color.IndianRed;
            this.bttnCreate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCreate.ForeColor = System.Drawing.Color.White;
            this.bttnCreate.Location = new System.Drawing.Point(156, 368);
            this.bttnCreate.Name = "bttnCreate";
            this.bttnCreate.Size = new System.Drawing.Size(236, 42);
            this.bttnCreate.TabIndex = 9;
            this.bttnCreate.Text = "Sign Up";
            this.bttnCreate.UseVisualStyleBackColor = false;
            this.bttnCreate.Click += new System.EventHandler(this.bttnCreate_Click);
            // 
            // newUser
            // 
            this.newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.newUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUser.ForeColor = System.Drawing.Color.Black;
            this.newUser.Location = new System.Drawing.Point(280, 169);
            this.newUser.Multiline = true;
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(233, 28);
            this.newUser.TabIndex = 4;
            this.newUser.TextChanged += new System.EventHandler(this.newUser_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(207, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 596);
            this.Controls.Add(this.panel1);
            this.Name = "Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newUser;
        private System.Windows.Forms.Button bttnCreate;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox newEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newLastName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.ComboBox newGender;
        private System.Windows.Forms.TextBox newBirth;
        private System.Windows.Forms.Label BDate;
    }
}