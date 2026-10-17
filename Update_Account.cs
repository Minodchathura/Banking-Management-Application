using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App
{
    public partial class Update_Account_Form : Form
    {
        int uid;
        public Update_Account_Form()
        {
            InitializeComponent();
        }

        public Update_Account_Form(int up_id)
        {
            InitializeComponent();
            this.uid = up_id;
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();

            bool isValid = true;

            // Name
            if (string.IsNullOrWhiteSpace(textBox_up_name.Text))
            {
                errorProvider1.SetError(
                    textBox_up_name,
                    "Name is required."
                );
                isValid = false;
            }

            // NIC
            if (string.IsNullOrWhiteSpace(textBox_up_nic.Text))
            {
                errorProvider1.SetError(
                    textBox_up_nic,
                    "NIC is required."
                );
                isValid = false;
            }
            else if (textBox_up_nic.Text.Length != 12)
            {
                errorProvider1.SetError(
                    textBox_up_nic,
                    "NIC must be exactly 12 digits."
                );
                isValid = false;
            }

            // Address
            if (string.IsNullOrWhiteSpace(textBox_up_address.Text))
            {
                errorProvider1.SetError(
                    textBox_up_address,
                    "Address is required."
                );
                isValid = false;
            }

            // Phone
            if (string.IsNullOrWhiteSpace(textBox_up_phone.Text))
            {
                errorProvider1.SetError(
                    textBox_up_phone,
                    "Phone number is required."
                );
                isValid = false;
            }
            else if (!textBox_up_phone.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(
                    textBox_up_phone,
                    "Phone number must contain only numbers."
                );
                isValid = false;
            }
            else if (textBox_up_phone.Text.Length != 10)
            {
                errorProvider1.SetError(
                    textBox_up_phone,
                    "Phone number must be exactly 10 digits."
                );
                isValid = false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(textBox_up_email.Text))
            {
                errorProvider1.SetError(
                    textBox_up_email,
                    "Email is required."
                );
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(
                textBox_up_email.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(
                    textBox_up_email,
                    "Invalid email format."
                );
                isValid = false;
            }

            // Account Type
            if (string.IsNullOrWhiteSpace(comboBox_up_type.Text))
            {
                errorProvider1.SetError(
                    comboBox_up_type,
                    "Account type is required."
                );
                isValid = false;
            }

            // Gender
            if (!radioButton_up_male.Checked &&
                !radioButton_up_female.Checked)
            {
                errorProvider1.SetError(
                    radioButton_up_male,
                    "Please select gender."
                );
                isValid = false;
            }

            return isValid;
        }

        private void Update_Account_Form_Load(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

           

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE CustomerID = " + uid + "", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    textBox_up_account_number.Text = rd.GetValue(9).ToString();
                    textBox_up_name.Text = rd.GetValue(1).ToString();
                    textBox_up_nic.Text = rd.GetValue(2).ToString();
                    textBox_up_address.Text = rd.GetValue(3).ToString();
                    textBox_up_phone.Text = rd.GetValue(6).ToString().PadLeft(10, '0');
                    textBox_up_email.Text = rd.GetValue(7).ToString();

                    dateTimePicker_up_db.Value = Convert.ToDateTime(rd.GetValue(4));
                    comboBox_up_type.Text = rd.GetValue(8).ToString();

                    if(rd.GetValue(5).ToString() == "Female")
                    {
                        radioButton_up_female.Checked = true;
                    }
                    else if (rd.GetValue(5).ToString() == "Male")
                    {
                        radioButton_up_male.Checked = true;
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerID = " + uid + "", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Account Deletion Successfully \n" ,  
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                textBox_up_name.Clear();
                textBox_up_nic.Clear();
                textBox_up_address.Clear();
                textBox_up_phone.Clear();
                textBox_up_email.Clear();

                radioButton_up_female.Checked = false;
                radioButton_up_male.Checked = false;

                comboBox_up_type.SelectedIndex = -1;

                dateTimePicker_up_db.Value = DateTime.Now;
                View_Account view_ac = new View_Account();
                view_ac.Show();
                this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                con.Open();
                SqlCommand nicCmd = new SqlCommand(
            "SELECT COUNT(*) FROM Customers WHERE NIC = @NIC AND CustomerID <> @ID",
            con);

                nicCmd.Parameters.AddWithValue("@NIC", textBox_up_nic.Text.Trim());
                nicCmd.Parameters.AddWithValue("@ID", uid);

                int nicExists = Convert.ToInt32(nicCmd.ExecuteScalar());

                if (nicExists > 0)
                {
                    errorProvider1.SetError(
                        textBox_up_nic,
                        "This NIC already exists."
                    );

                    MessageBox.Show(
                        "This NIC is already registered to another customer.",
                        "NIC Already Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Check Email already exists for another customer
                SqlCommand emailCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Customers WHERE Email = @Email AND CustomerID <> @ID",
                    con);

                emailCmd.Parameters.AddWithValue(
                    "@Email",
                    textBox_up_email.Text.Trim()
                );

                emailCmd.Parameters.AddWithValue("@ID", uid);

                int emailExists = Convert.ToInt32(emailCmd.ExecuteScalar());

                if (emailExists > 0)
                {
                    errorProvider1.SetError(
                        textBox_up_email,
                        "This email already exists."
                    );

                    MessageBox.Show(
                        "This Email is already registered to another customer.",
                        "Email Already Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                SqlCommand cmd = new SqlCommand("UPDATE Customers SET FullName = @Name,NIC = @NIC,Address = @Address,BirthDate = @bd,Gender = @gender,Phone = @phone,Email = @email,AccountType = @actype WHERE AccountNumber = @AccountNumber", con);

                string gender = "";

                if (radioButton_up_male.Checked)
                {
                    gender = "Male";
                }
                else if (radioButton_up_female.Checked)
                {
                    gender = "Female";
                }

                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@AccountNumber", textBox_up_account_number.Text);
                cmd.Parameters.AddWithValue("@Name", textBox_up_name.Text);
                cmd.Parameters.AddWithValue("@NIC", textBox_up_nic.Text);
                cmd.Parameters.AddWithValue("@actype", comboBox_up_type.Text);
                cmd.Parameters.AddWithValue("@Address", textBox_up_address.Text);
                cmd.Parameters.AddWithValue("@Phone", textBox_up_phone.Text);
                cmd.Parameters.AddWithValue("@email", textBox_up_email.Text);
                cmd.Parameters.AddWithValue("@bd", dateTimePicker_up_db.Value);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Account Update Successfully \n",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                textBox_up_name.Clear();
                textBox_up_nic.Clear();
                textBox_up_address.Clear();
                textBox_up_phone.Clear();
                textBox_up_email.Clear();

                radioButton_up_female.Checked = false;
                radioButton_up_male.Checked = false;

                comboBox_up_type.SelectedIndex = -1;

                dateTimePicker_up_db.Value = DateTime.Now;
                View_Account view_ac = new View_Account();
                view_ac.Show();
                this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Account vi = new View_Account();
            vi.Show();
            this.Hide();
        }
    }
}
