using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Banking_App
{
    public partial class Account_Creation : Form
    {
        public Account_Creation()
        {
            InitializeComponent();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            Admin_Panel admin_Panel = new Admin_Panel();
            admin_Panel.Show();
            this.Hide();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            View_Account view_Account = new View_Account();
            view_Account.Show();
            this.Hide();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

       

        private void button_logout_Click(object sender, EventArgs e)
        {
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
            this.Hide();
        }


        private void button_ac_add_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);
            string gender = null;

            errorProvider1.Clear();

            bool isValid = true;

           
            if (string.IsNullOrWhiteSpace(textBox_ac_name.Text))
            {
                errorProvider1.SetError(textBox_ac_name, "Name is required");
                isValid = false;
            }

            
            string nic = textBox_ac_nic.Text.Trim();

            if (string.IsNullOrWhiteSpace(nic))
            {
                errorProvider1.SetError(textBox_ac_nic, "NIC is required");
                isValid = false;
            }
            else if (nic.Length != 12)
            {
                errorProvider1.SetError(textBox_ac_nic, "NIC must contain 12 characters");
                isValid = false;
            }

            
            if (string.IsNullOrWhiteSpace(textBox_ac_address.Text))
            {
                errorProvider1.SetError(textBox_ac_address, "Address is required");
                isValid = false;
            }

            
            string phone = textBox_ac_phone.Text.Trim();

            if (string.IsNullOrWhiteSpace(phone))
            {
                errorProvider1.SetError(textBox_ac_phone, "Phone number is required");
                isValid = false;
            }
            else if (!phone.All(char.IsDigit))
            {
                errorProvider1.SetError(textBox_ac_phone, "Phone number must contain only numbers");
                isValid = false;
            }
            else if (phone.Length != 10)
            {
                errorProvider1.SetError(textBox_ac_phone, "Phone number must be exactly 10 digits");
                isValid = false;
            }

           
            string email = textBox_ac_email.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(textBox_ac_email, "Email is required");
                isValid = false;
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                errorProvider1.SetError(textBox_ac_email, "Enter a valid email address");
                isValid = false;
            }

            
            string gender_ = null;

            if (radioButton_ac_female.Checked)
            {
                gender_ = "Female";
            }
            else if (radioButton_ac_male.Checked)
            {
                gender_ = "Male";
            }
            else
            {
                errorProvider1.SetError(radioButton_ac_male, "Please select gender");
                isValid = false;
            }

           
            if (string.IsNullOrWhiteSpace(comboBox_ac_type.Text))
            {
                errorProvider1.SetError(comboBox_ac_type, "Please select account type");
                isValid = false;
            }

           
            if (dateTimePicker_ac_db.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(dateTimePicker_ac_db, "Birth date cannot be in the future");
                isValid = false;
            }

         
            if (!isValid)
            {
                return;
            }

            try
            {
                if (radioButton_ac_female.Checked)
                {
                    gender = "Female";
                }
                else if (radioButton_ac_male.Checked) {
                    gender = "Male";
                }

                con.Open();
                //int inc = Convert.ToInt32(new SqlCommand("SELECT ISNULL(MAX(CustomerID),0)+1 FROM Customers", con).ExecuteScalar());
                //string nic_c = textBox_ac_nic.Text.Trim();

                //SqlCommand cmd = new SqlCommand("DELEFROM Customers; DBCC CHECKIDENT ('Customers', RESEED, 0)", con);
                //cmd.CommandType = CommandType.Text;
                //cmd.ExecuteNonQuery();

                //string accountNumber = "83" + inc + nic_c.Substring(0, 7);
                SqlCommand cmd = new SqlCommand("INSERT INTO Customers(FullName,NIC,Address,BirthDate,Gender,Phone,Email,AccountType) VALUES(@name,@nic,@address,@birth,@gender,@phone,@email,@type)", con);

                cmd.Parameters.AddWithValue("@name", textBox_ac_name.Text);
                cmd.Parameters.AddWithValue("@nic", textBox_ac_nic.Text);
                cmd.Parameters.AddWithValue("@address", textBox_ac_address.Text);
                cmd.Parameters.AddWithValue("@birth", dateTimePicker_ac_db.Value);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@phone", textBox_ac_phone.Text);
                cmd.Parameters.AddWithValue("@email", textBox_ac_email.Text);
                cmd.Parameters.AddWithValue("@type", comboBox_ac_type.Text);
               // cmd.Parameters.AddWithValue("@account", accountNumber);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                // Insert customer first
                cmd.ExecuteNonQuery();

                // Get generated CustomerID
                SqlCommand idCmd = new SqlCommand("SELECT SCOPE_IDENTITY()", con);
                int customerId = Convert.ToInt32(idCmd.ExecuteScalar());

                // Generate account number
                string accountNumber = "83" + customerId + nic.Substring(0, 7);

                // Update account number
                SqlCommand updateCmd = new SqlCommand(
                    "UPDATE Customers SET AccountNumber=@acc WHERE CustomerID=@id", con);

                updateCmd.Parameters.AddWithValue("@acc", accountNumber);
                updateCmd.Parameters.AddWithValue("@id", customerId);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Customer Account Create Successfully! \n" ,
                   // "Account Number is: " + accountNumber,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                textBox_ac_name.Clear();
                textBox_ac_nic.Clear();
                textBox_ac_address.Clear();
                textBox_ac_phone.Clear();
                textBox_ac_email.Clear();

                radioButton_ac_female.Checked = false;
                radioButton_ac_male.Checked = false;

                comboBox_ac_type.SelectedIndex = -1;

                dateTimePicker_ac_db.Value = DateTime.Now;

            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void button_ac_clear_Click(object sender, EventArgs e)
        {
            textBox_ac_name.Clear();
            textBox_ac_nic.Clear();
            textBox_ac_address.Clear();
            textBox_ac_phone.Clear();
            textBox_ac_email.Clear();

            radioButton_ac_female.Checked = false;
            radioButton_ac_male.Checked = false;

            comboBox_ac_type.SelectedIndex = -1;

            dateTimePicker_ac_db.Value = DateTime.Now;
        }

        private void Account_Creation_Load(object sender, EventArgs e)
        {
            comboBox_ac_type.Items.Add("Saving");
            comboBox_ac_type.Items.Add("Current");

            comboBox_ac_type.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit de = new Deposit();
            de.Show();
            this.Hide();
        }
    }
}
