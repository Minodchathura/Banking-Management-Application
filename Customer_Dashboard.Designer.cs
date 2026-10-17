namespace Banking_App
{
    partial class Customer_Dashboard
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
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_v_acc = new System.Windows.Forms.Label();
            this.label_v_b = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 459);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::Banking_App.Properties.Resources.Screenshot_2026_08_17_1814021;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(25, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "My Profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "DashBoard";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(356, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "My Account";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label_v_acc);
            this.panel2.Controls.Add(this.label_v_b);
            this.panel2.Location = new System.Drawing.Point(419, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 198);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Avilable Balance";
            // 
            // label_v_acc
            // 
            this.label_v_acc.AutoSize = true;
            this.label_v_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_v_acc.Location = new System.Drawing.Point(17, 50);
            this.label_v_acc.Name = "label_v_acc";
            this.label_v_acc.Size = new System.Drawing.Size(272, 37);
            this.label_v_acc.TabIndex = 1;
            this.label_v_acc.Text = "Account Number";
            // 
            // label_v_b
            // 
            this.label_v_b.AutoSize = true;
            this.label_v_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_v_b.Location = new System.Drawing.Point(242, 148);
            this.label_v_b.Name = "label_v_b";
            this.label_v_b.Size = new System.Drawing.Size(124, 46);
            this.label_v_b.TabIndex = 0;
            this.label_v_b.Text = "00.00";
            // 
            // Customer_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Customer_Dashboard";
            this.Text = "Customer_Dashboard";
            this.Load += new System.EventHandler(this.Customer_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_v_acc;
        private System.Windows.Forms.Label label_v_b;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}