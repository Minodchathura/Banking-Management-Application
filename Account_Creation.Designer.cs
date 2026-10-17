namespace Banking_App
{
    partial class Account_Creation
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_view = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_account = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ac_name = new System.Windows.Forms.TextBox();
            this.textBox_ac_nic = new System.Windows.Forms.TextBox();
            this.textBox_ac_address = new System.Windows.Forms.TextBox();
            this.textBox_ac_phone = new System.Windows.Forms.TextBox();
            this.textBox_ac_email = new System.Windows.Forms.TextBox();
            this.comboBox_ac_type = new System.Windows.Forms.ComboBox();
            this.radioButton_ac_male = new System.Windows.Forms.RadioButton();
            this.radioButton_ac_female = new System.Windows.Forms.RadioButton();
            this.button_ac_clear = new System.Windows.Forms.Button();
            this.button_ac_add = new System.Windows.Forms.Button();
            this.dateTimePicker_ac_db = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_view);
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.button_users);
            this.panel1.Controls.Add(this.button_account);
            this.panel1.Controls.Add(this.button_dashboard);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 467);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::Banking_App.Properties.Resources.Screenshot_2026_08_17_1814021;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button_view
            // 
            this.button_view.Location = new System.Drawing.Point(20, 242);
            this.button_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(211, 40);
            this.button_view.TabIndex = 7;
            this.button_view.Text = "View Account";
            this.button_view.UseVisualStyleBackColor = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Red;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(20, 415);
            this.button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(211, 40);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_users
            // 
            this.button_users.Location = new System.Drawing.Point(20, 359);
            this.button_users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(211, 40);
            this.button_users.TabIndex = 4;
            this.button_users.Text = "Users";
            this.button_users.UseVisualStyleBackColor = true;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // button_account
            // 
            this.button_account.BackColor = System.Drawing.Color.Lime;
            this.button_account.Location = new System.Drawing.Point(20, 191);
            this.button_account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(211, 40);
            this.button_account.TabIndex = 3;
            this.button_account.Text = "New Accounts";
            this.button_account.UseVisualStyleBackColor = false;
            // 
            // button_dashboard
            // 
            this.button_dashboard.Location = new System.Drawing.Point(20, 134);
            this.button_dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(211, 40);
            this.button_dashboard.TabIndex = 2;
            this.button_dashboard.Text = "DashBoard";
            this.button_dashboard.UseVisualStyleBackColor = true;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(288, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Creation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "NIC Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Birth Day:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Account Type:";
            // 
            // textBox_ac_name
            // 
            this.textBox_ac_name.Location = new System.Drawing.Point(429, 106);
            this.textBox_ac_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ac_name.Name = "textBox_ac_name";
            this.textBox_ac_name.Size = new System.Drawing.Size(238, 22);
            this.textBox_ac_name.TabIndex = 11;
            // 
            // textBox_ac_nic
            // 
            this.textBox_ac_nic.Location = new System.Drawing.Point(429, 148);
            this.textBox_ac_nic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ac_nic.Name = "textBox_ac_nic";
            this.textBox_ac_nic.Size = new System.Drawing.Size(238, 22);
            this.textBox_ac_nic.TabIndex = 12;
            // 
            // textBox_ac_address
            // 
            this.textBox_ac_address.Location = new System.Drawing.Point(429, 190);
            this.textBox_ac_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ac_address.Name = "textBox_ac_address";
            this.textBox_ac_address.Size = new System.Drawing.Size(238, 22);
            this.textBox_ac_address.TabIndex = 13;
            // 
            // textBox_ac_phone
            // 
            this.textBox_ac_phone.Location = new System.Drawing.Point(429, 310);
            this.textBox_ac_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ac_phone.Name = "textBox_ac_phone";
            this.textBox_ac_phone.Size = new System.Drawing.Size(238, 22);
            this.textBox_ac_phone.TabIndex = 14;
            // 
            // textBox_ac_email
            // 
            this.textBox_ac_email.Location = new System.Drawing.Point(429, 345);
            this.textBox_ac_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ac_email.Name = "textBox_ac_email";
            this.textBox_ac_email.Size = new System.Drawing.Size(238, 22);
            this.textBox_ac_email.TabIndex = 15;
            // 
            // comboBox_ac_type
            // 
            this.comboBox_ac_type.FormattingEnabled = true;
            this.comboBox_ac_type.Location = new System.Drawing.Point(429, 381);
            this.comboBox_ac_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_ac_type.Name = "comboBox_ac_type";
            this.comboBox_ac_type.Size = new System.Drawing.Size(238, 24);
            this.comboBox_ac_type.TabIndex = 16;
            // 
            // radioButton_ac_male
            // 
            this.radioButton_ac_male.AutoSize = true;
            this.radioButton_ac_male.Location = new System.Drawing.Point(429, 271);
            this.radioButton_ac_male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_ac_male.Name = "radioButton_ac_male";
            this.radioButton_ac_male.Size = new System.Drawing.Size(58, 20);
            this.radioButton_ac_male.TabIndex = 18;
            this.radioButton_ac_male.TabStop = true;
            this.radioButton_ac_male.Text = "Male";
            this.radioButton_ac_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_ac_female
            // 
            this.radioButton_ac_female.AutoSize = true;
            this.radioButton_ac_female.Location = new System.Drawing.Point(536, 271);
            this.radioButton_ac_female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_ac_female.Name = "radioButton_ac_female";
            this.radioButton_ac_female.Size = new System.Drawing.Size(74, 20);
            this.radioButton_ac_female.TabIndex = 19;
            this.radioButton_ac_female.TabStop = true;
            this.radioButton_ac_female.Text = "Female";
            this.radioButton_ac_female.UseVisualStyleBackColor = true;
            // 
            // button_ac_clear
            // 
            this.button_ac_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_ac_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ac_clear.Location = new System.Drawing.Point(778, 241);
            this.button_ac_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ac_clear.Name = "button_ac_clear";
            this.button_ac_clear.Size = new System.Drawing.Size(133, 46);
            this.button_ac_clear.TabIndex = 20;
            this.button_ac_clear.Text = "Clear";
            this.button_ac_clear.UseVisualStyleBackColor = false;
            this.button_ac_clear.Click += new System.EventHandler(this.button_ac_clear_Click);
            // 
            // button_ac_add
            // 
            this.button_ac_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_ac_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ac_add.Location = new System.Drawing.Point(778, 158);
            this.button_ac_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ac_add.Name = "button_ac_add";
            this.button_ac_add.Size = new System.Drawing.Size(133, 50);
            this.button_ac_add.TabIndex = 21;
            this.button_ac_add.Text = "Add";
            this.button_ac_add.UseVisualStyleBackColor = false;
            this.button_ac_add.Click += new System.EventHandler(this.button_ac_add_Click);
            // 
            // dateTimePicker_ac_db
            // 
            this.dateTimePicker_ac_db.Location = new System.Drawing.Point(429, 226);
            this.dateTimePicker_ac_db.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_ac_db.Name = "dateTimePicker_ac_db";
            this.dateTimePicker_ac_db.Size = new System.Drawing.Size(238, 22);
            this.dateTimePicker_ac_db.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Account_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 465);
            this.Controls.Add(this.dateTimePicker_ac_db);
            this.Controls.Add(this.button_ac_add);
            this.Controls.Add(this.button_ac_clear);
            this.Controls.Add(this.radioButton_ac_female);
            this.Controls.Add(this.radioButton_ac_male);
            this.Controls.Add(this.comboBox_ac_type);
            this.Controls.Add(this.textBox_ac_email);
            this.Controls.Add(this.textBox_ac_phone);
            this.Controls.Add(this.textBox_ac_address);
            this.Controls.Add(this.textBox_ac_nic);
            this.Controls.Add(this.textBox_ac_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Account_Creation";
            this.Text = "Account_Form";
            this.Load += new System.EventHandler(this.Account_Creation_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ac_name;
        private System.Windows.Forms.TextBox textBox_ac_nic;
        private System.Windows.Forms.TextBox textBox_ac_address;
        private System.Windows.Forms.TextBox textBox_ac_phone;
        private System.Windows.Forms.TextBox textBox_ac_email;
        private System.Windows.Forms.ComboBox comboBox_ac_type;
        private System.Windows.Forms.RadioButton radioButton_ac_male;
        private System.Windows.Forms.RadioButton radioButton_ac_female;
        private System.Windows.Forms.Button button_ac_clear;
        private System.Windows.Forms.Button button_ac_add;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ac_db;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}