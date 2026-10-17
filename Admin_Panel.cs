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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }



        private void button_account_Click(object sender, EventArgs e)
        {
            Account_Creation account_Account = new Account_Creation();
            account_Account.Show();
            this.Hide();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            View_Account view = new View_Account();
            view.Show();
            this.Hide();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
            this.Hide();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

        

        private void get_users()
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users", con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                label_count_users.Text = count.ToString();
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

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customers", con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                label_count_accounts.Text = count.ToString();
                get_users();

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
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }
    }
}
