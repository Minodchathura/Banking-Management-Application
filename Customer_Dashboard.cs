using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App
{
    public partial class Customer_Dashboard : Form
    {
        string username;
        public Customer_Dashboard(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Profile customer_Profile = new Customer_Profile(username);
            customer_Profile.Show();
            this.Hide();
        }

      private void dis_amount()
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE Email = '" + username + "'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    label_v_b.Text = "Rs." + rd.GetValue(10).ToString();
                    // label_v_acc.Text = rd.GetValue(9).ToString();

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
        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email = '" + username + "'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    label_v_acc.Text = rd.GetValue(1).ToString();
                   // label_v_acc.Text = rd.GetValue(9).ToString();

                }

                dis_amount();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Login_Page llo = new Login_Page();
            llo.Show();
            this.Hide();
        }

        
    }
}
