namespace Banking_App
{
    partial class Form1
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
            this.button_welcome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_welcome
            // 
            this.button_welcome.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_welcome.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_welcome.ForeColor = System.Drawing.Color.White;
            this.button_welcome.Location = new System.Drawing.Point(298, 527);
            this.button_welcome.Name = "button_welcome";
            this.button_welcome.Size = new System.Drawing.Size(490, 87);
            this.button_welcome.TabIndex = 0;
            this.button_welcome.Text = "GET STARTED";
            this.button_welcome.UseVisualStyleBackColor = false;
            this.button_welcome.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(120, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(883, 91);
            this.label2.TabIndex = 2;
            this.label2.Text = " BANK MENAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banking_App.Properties.Resources.Screenshot_2026_08_17_1758133;
            this.pictureBox1.Location = new System.Drawing.Point(391, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1096, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_welcome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

