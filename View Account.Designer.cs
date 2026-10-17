namespace Banking_App
{
    partial class View_Account
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_view = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_account = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_se_acount = new System.Windows.Forms.TextBox();
            this.button_view_search = new System.Windows.Forms.Button();
            this.dataGridView_viewaccounts = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viewaccounts)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 471);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::Banking_App.Properties.Resources.Screenshot_2026_08_17_1814021;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button_view
            // 
            this.button_view.BackColor = System.Drawing.Color.Lime;
            this.button_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_view.Location = new System.Drawing.Point(21, 260);
            this.button_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(211, 40);
            this.button_view.TabIndex = 7;
            this.button_view.Text = "View Account";
            this.button_view.UseVisualStyleBackColor = false;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Red;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(21, 421);
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
            this.button_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_users.Location = new System.Drawing.Point(21, 368);
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
            this.button_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_account.Location = new System.Drawing.Point(21, 203);
            this.button_account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(211, 40);
            this.button_account.TabIndex = 3;
            this.button_account.Text = "New Accounts";
            this.button_account.UseVisualStyleBackColor = true;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashboard.Location = new System.Drawing.Point(21, 149);
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
            this.label1.Location = new System.Drawing.Point(278, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "All Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Account Number: ";
            // 
            // textBox_se_acount
            // 
            this.textBox_se_acount.Location = new System.Drawing.Point(444, 110);
            this.textBox_se_acount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_se_acount.Multiline = true;
            this.textBox_se_acount.Name = "textBox_se_acount";
            this.textBox_se_acount.Size = new System.Drawing.Size(386, 27);
            this.textBox_se_acount.TabIndex = 10;
            // 
            // button_view_search
            // 
            this.button_view_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_view_search.Location = new System.Drawing.Point(859, 114);
            this.button_view_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_view_search.Name = "button_view_search";
            this.button_view_search.Size = new System.Drawing.Size(97, 27);
            this.button_view_search.TabIndex = 11;
            this.button_view_search.Text = "Search";
            this.button_view_search.UseVisualStyleBackColor = false;
            this.button_view_search.Click += new System.EventHandler(this.button_view_search_Click);
            // 
            // dataGridView_viewaccounts
            // 
            this.dataGridView_viewaccounts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_viewaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_viewaccounts.Location = new System.Drawing.Point(292, 184);
            this.dataGridView_viewaccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_viewaccounts.Name = "dataGridView_viewaccounts";
            this.dataGridView_viewaccounts.RowHeadersWidth = 62;
            this.dataGridView_viewaccounts.RowTemplate.Height = 28;
            this.dataGridView_viewaccounts.Size = new System.Drawing.Size(644, 278);
            this.dataGridView_viewaccounts.TabIndex = 12;
            this.dataGridView_viewaccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_viewaccounts_CellContentClick);
            this.dataGridView_viewaccounts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_viewaccounts_CellContentDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // View_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 471);
            this.Controls.Add(this.dataGridView_viewaccounts);
            this.Controls.Add(this.button_view_search);
            this.Controls.Add(this.textBox_se_acount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_Account";
            this.Text = "View_Account";
            this.Load += new System.EventHandler(this.View_Account_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viewaccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_se_acount;
        private System.Windows.Forms.Button button_view_search;
        private System.Windows.Forms.DataGridView dataGridView_viewaccounts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}