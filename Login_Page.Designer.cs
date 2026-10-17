namespace Banking_App
{
    partial class Login_Page
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
            this.button_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_lo_username = new System.Windows.Forms.TextBox();
            this.textBox_lo_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_login.Location = new System.Drawing.Point(357, 615);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(138, 47);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // textBox_lo_username
            // 
            this.textBox_lo_username.Location = new System.Drawing.Point(173, 422);
            this.textBox_lo_username.Multiline = true;
            this.textBox_lo_username.Name = "textBox_lo_username";
            this.textBox_lo_username.Size = new System.Drawing.Size(322, 34);
            this.textBox_lo_username.TabIndex = 3;
            this.textBox_lo_username.TextChanged += new System.EventHandler(this.textBox_lo_username_TextChanged);
            // 
            // textBox_lo_password
            // 
            this.textBox_lo_password.Location = new System.Drawing.Point(173, 536);
            this.textBox_lo_password.Multiline = true;
            this.textBox_lo_password.Name = "textBox_lo_password";
            this.textBox_lo_password.Size = new System.Drawing.Size(322, 34);
            this.textBox_lo_password.TabIndex = 4;
            this.textBox_lo_password.TextChanged += new System.EventHandler(this.textBox_lo_password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 68);
            this.label3.TabIndex = 7;
            this.label3.Text = "SIGN IN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_signup);
            this.panel1.Controls.Add(this.textBox_lo_password);
            this.panel1.Controls.Add(this.textBox_lo_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Location = new System.Drawing.Point(216, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 729);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banking_App.Properties.Resources.Screenshot_2026_08_17_1758132;
            this.pictureBox1.Location = new System.Drawing.Point(206, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button_signup
            // 
            this.button_signup.BackColor = System.Drawing.Color.Cyan;
            this.button_signup.Location = new System.Drawing.Point(173, 615);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(140, 47);
            this.button_signup.TabIndex = 5;
            this.button_signup.Text = "Sign Up";
            this.button_signup.UseVisualStyleBackColor = false;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 902);
            this.Controls.Add(this.panel1);
            this.Name = "Login_Page";
            this.Text = "Login_Page";
            this.Load += new System.EventHandler(this.Login_Page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_lo_username;
        private System.Windows.Forms.TextBox textBox_lo_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}