using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBox_cr_acc_num.Text))
            {
                errorProvider1.SetError(textBox_cr_acc_num, "Account Number is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox_cr_nic.Text))
            {
                errorProvider1.SetError(textBox_cr_nic, "NIC is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox_cr_email.Text))
            {
                errorProvider1.SetError(textBox_cr_email, "Email is required.");
                isValid = false;
            }
            else if (!Regex.IsMatch(textBox_cr_email.Text,
                     @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(textBox_cr_email, "Invalid email format.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox_cr_phone.Text))
            {
                errorProvider1.SetError(textBox_cr_phone, "Phone number is required.");
                isValid = false;
            }
            else if (!Regex.IsMatch(textBox_cr_phone.Text, @"^\d{10}$"))
            {
                errorProvider1.SetError(textBox_cr_phone, "Phone number must be 10 digits.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox_cr_psw.Text))
            {
                errorProvider1.SetError(textBox_cr_psw, "Password is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox_cr_con_psw.Text))
            {
                errorProvider1.SetError(textBox_cr_con_psw, "Confirm Password is required.");
                isValid = false;
            }
            else if (textBox_cr_psw.Text != textBox_cr_con_psw.Text)
            {
                errorProvider1.SetError(textBox_cr_con_psw, "Passwords do not match.");
                isValid = false;
            }

            return isValid;
        }
        private void button_cr_sign_up_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                long ac_num = Convert.ToInt64(textBox_cr_acc_num.Text);
                string nic = textBox_cr_nic.Text;
                string email = textBox_cr_email.Text;
                int number = Convert.ToInt32(textBox_cr_phone.Text);
                string psw = textBox_cr_psw.Text;

                con.Open();

    
                SqlCommand customerCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Customers WHERE AccountNumber = @Account",
                    con);

                customerCmd.Parameters.AddWithValue("@Account", ac_num);

                int customerExists = Convert.ToInt32(customerCmd.ExecuteScalar());

                if (customerExists == 0)
                {
                    errorProvider1.SetError(
                        textBox_cr_acc_num,
                        "This Account Number does not exist."
                    );

                    MessageBox.Show(
                        "Account Number not found.\nPlease enter a valid customer account number.",
                        "Invalid Account Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

             
                SqlCommand userAccountCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE Account_Number = @Account",
                    con);

                userAccountCmd.Parameters.AddWithValue("@Account", ac_num);

                int accountAlreadyRegistered =
                    Convert.ToInt32(userAccountCmd.ExecuteScalar());

                if (accountAlreadyRegistered > 0)
                {
                    errorProvider1.SetError(
                        textBox_cr_acc_num,
                        "This account is already registered."
                    );

                    MessageBox.Show(
                        "This Account Number is already registered.",
                        "Already Registered",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE NIC = @NIC OR Email = @Email",
                    con);

                checkCmd.Parameters.AddWithValue("@NIC", nic);
                checkCmd.Parameters.AddWithValue("@Email", email);

                if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show(
                        "NIC or Email already exists.",
                        "Already Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                //SqlCommand cmd = new SqlCommand("DELEFROM Users; DBCC CHECKIDENT ('Users', RESEED, 0)", con);
                //cmd.CommandType = CommandType.Text;
                //cmd.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("INSERT INTO Users(Account_Number,NIC,Email,Phone_Number,Password) VALUES(" + ac_num + ",'" + nic + "','" + email + "'," + number + ",'" + psw + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show(
                     "New Account Create Successful \n",
                     "",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                 );
                Login_Page loginPage = new Login_Page();
                loginPage.Show();
                this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Page LoginPage = new Login_Page();
            LoginPage.Show();
            this.Hide();
        }

        

       
    }
}
