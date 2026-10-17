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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Banking_App
{

    public partial class Customer_Profile : Form
    {
        string get_username = null;
        public Customer_Profile(string username)
        {
            InitializeComponent();
            get_username = username;
        }

        private void Customer_Profile_Load(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email = '"+ get_username + "'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    textBox_cr_acc_num.Text = rd.GetValue(1).ToString();
                    textBox_cr_nic.Text = rd.GetValue(2).ToString();
                    textBox_cr_email.Text = rd.GetValue(3).ToString();
                    textBox_cr_phone.Text = rd.GetValue(4).ToString(); 
 
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

        private void button5_Click(object sender, EventArgs e)
        {
           panel_psw.Visible = true;
            label_psw.Visible = true;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            string psw = textBox_psw.Text;
            string c_psw = textBox_con_psw.Text;

            if (string.IsNullOrWhiteSpace(psw))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            if (string.IsNullOrWhiteSpace(c_psw))
            {
                MessageBox.Show("Please confirm your password.");
                return;
            }

            if (psw != c_psw)
            {
                MessageBox.Show(
                    "Password does not match.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            try
            {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET Password = '" + c_psw + "' WHERE Email = '" + get_username + "'", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Password Update Successfully \n",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    textBox_psw.Clear();
                    textBox_con_psw.Clear();
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
            Customer_Dashboard cud = new Customer_Dashboard(get_username);
            cud.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_Page lg = new Login_Page();
            lg.Show();
            this.Hide();
        }
    }
    
}
