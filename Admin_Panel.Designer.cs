namespace Banking_App
{
    partial class Admin_Panel
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_count_accounts = new System.Windows.Forms.Label();
            this.label_coutl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_view = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_account = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_count_users = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label_count_accounts);
            this.panel3.Controls.Add(this.label_coutl);
            this.panel3.Location = new System.Drawing.Point(353, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 195);
            this.panel3.TabIndex = 2;
            // 
            // label_count_accounts
            // 
            this.label_count_accounts.AutoSize = true;
            this.label_count_accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_accounts.ForeColor = System.Drawing.Color.White;
            this.label_count_accounts.Location = new System.Drawing.Point(146, 78);
            this.label_count_accounts.Name = "label_count_accounts";
            this.label_count_accounts.Size = new System.Drawing.Size(153, 108);
            this.label_count_accounts.TabIndex = 2;
            this.label_count_accounts.Text = "00";
            // 
            // label_coutl
            // 
            this.label_coutl.AutoSize = true;
            this.label_coutl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coutl.ForeColor = System.Drawing.Color.White;
            this.label_coutl.Location = new System.Drawing.Point(20, 20);
            this.label_coutl.Name = "label_coutl";
            this.label_coutl.Size = new System.Drawing.Size(245, 37);
            this.label_coutl.TabIndex = 0;
            this.label_coutl.Text = "Total Accounts";
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
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 574);
            this.panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::Banking_App.Properties.Resources.Screenshot_2026_08_17_1814021;
            this.pictureBox1.Location = new System.Drawing.Point(5, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button_view
            // 
            this.button_view.Location = new System.Drawing.Point(37, 302);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(237, 50);
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
            this.button_logout.Location = new System.Drawing.Point(37, 514);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(237, 50);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_users
            // 
            this.button_users.Location = new System.Drawing.Point(37, 449);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(237, 50);
            this.button_users.TabIndex = 4;
            this.button_users.Text = "Users";
            this.button_users.UseVisualStyleBackColor = true;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // button_account
            // 
            this.button_account.Location = new System.Drawing.Point(37, 231);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(237, 50);
            this.button_account.TabIndex = 3;
            this.button_account.Text = "New Accounts";
            this.button_account.UseVisualStyleBackColor = true;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.BackColor = System.Drawing.Color.Lime;
            this.button_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashboard.ForeColor = System.Drawing.Color.Black;
            this.button_dashboard.Location = new System.Drawing.Point(37, 163);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(237, 50);
            this.button_dashboard.TabIndex = 2;
            this.button_dashboard.Text = "DashBoard";
            this.button_dashboard.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label_count_users);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(740, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 195);
            this.panel2.TabIndex = 3;
            // 
            // label_count_users
            // 
            this.label_count_users.AutoSize = true;
            this.label_count_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_users.ForeColor = System.Drawing.Color.White;
            this.label_count_users.Location = new System.Drawing.Point(146, 78);
            this.label_count_users.Name = "label_count_users";
            this.label_count_users.Size = new System.Drawing.Size(153, 108);
            this.label_count_users.TabIndex = 2;
            this.label_count_users.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Users";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Banking_App.Properties.Resources.Screenshot_2026_08_17_1758134;
            this.pictureBox2.Location = new System.Drawing.Point(475, -11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(466, 363);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 576);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Admin_Panel";
            this.Text = "Admin_Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_coutl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Label label_count_accounts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_count_users;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}