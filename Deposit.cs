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

namespace Banking_App
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
            panel1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(
                Properties.Settings.Default.conString);

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT Amount FROM Customers WHERE AccountNumber=@account", con);

                cmd.Parameters.AddWithValue("@account", textBox_de_acc.Text);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    label_amount.Text = rd["Amount"].ToString();
                }
                else
                {
                    MessageBox.Show(
                      "Account Number Not Found! \n",
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                  );

                }

                rd.Close();
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
            Admin_Panel ad = new Admin_Panel();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(label_amount.Text);
            decimal deposit = Convert.ToDecimal(textBox_de_value.Text);

            decimal newAmount = amount + deposit;

            SqlConnection con = new SqlConnection(
                Properties.Settings.Default.conString);

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Customers SET Amount=@amount WHERE AccountNumber=@account",
                    con);

                cmd.Parameters.AddWithValue("@amount", newAmount);
                cmd.Parameters.AddWithValue("@account", textBox_de_acc.Text);

                cmd.ExecuteNonQuery();

                label_amount.Text = newAmount.ToString();

                MessageBox.Show(
                     "Deposit Successfully! \n",
                     "Success",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                 );
                Admin_Panel ad = new Admin_Panel();
                ad.Show();
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
    }
    
}
