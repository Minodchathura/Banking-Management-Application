using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.Show();
            this.Hide();
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();

            bool isValid = true;

            
            if (string.IsNullOrWhiteSpace(textBox_lo_username.Text))
            {
                errorProvider1.SetError(textBox_lo_username, "Email is required.");
                isValid = false;
            }
            else if (!Regex.IsMatch(textBox_lo_username.Text,
                     @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(textBox_lo_username, "Enter a valid email address.");
                isValid = false;
            }

           
            if (string.IsNullOrWhiteSpace(textBox_lo_password.Text))
            {
                errorProvider1.SetError(textBox_lo_password, "Password is required.");
                isValid = false;
            }

            return isValid;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            string username = textBox_lo_username.Text;
            string password = textBox_lo_password.Text;

            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email=@username AND Password=@password", con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    MessageBox.Show(
                    "Login Successfull \n",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                    Customer_Dashboard customer = new Customer_Dashboard(username);
                    customer.Show();
                    this.Hide();
                    return;
                }

                else if (username == "admin@gmail.com" && password == "admin@123")
                {
                    MessageBox.Show(
                    "Login Successfull \n",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                    Admin_Panel admin_Panel = new Admin_Panel();
                    admin_Panel.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show(
                    "Invalid Email Or Password \n",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {
                con.Close();
            }

        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_lo_username_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_lo_username, "");
        }

        private void textBox_lo_password_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_lo_password, "");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
