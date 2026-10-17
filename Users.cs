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
    public partial class Users : Form
    {

        string selectedAccountNumber;
        public Users()
        {
            InitializeComponent();
        }

  

        private void button_account_Click(object sender, EventArgs e)
        {
            Account_Creation ac = new Account_Creation();
            ac.Show();
            this.Hide();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            Admin_Panel ad = new Admin_Panel();
            ad.Show();
            this.Hide();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            View_Account vw = new View_Account();
            vw.Show();
            this.Hide();
        }

      

        private void button_logout_Click(object sender, EventArgs e)
        {
            Login_Page lg = new Login_Page();
            lg.Show();
            this.Hide();
        }

        private void LoadData()
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
                cmd.CommandType = CommandType.Text;

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView_users.DataSource = dt;
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

        private void Users_Load(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
                cmd.CommandType = CommandType.Text;

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView_users.DataSource = dt;
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

        private void button_view_search_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Account_Number = @account", con);
                cmd.Parameters.AddWithValue("@account", textBox_us_acount.Text);

                cmd.CommandType = CommandType.Text;

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView_users.DataSource = dt;
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

        private void dataGridView_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                selectedAccountNumber = dataGridView_users.Rows[e.RowIndex].Cells["Account_Number"].Value.ToString();
            }
        }

        private void button_users_del_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE Account_Number = " + selectedAccountNumber + "", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadData();

                MessageBox.Show(
                    "Account Deletion Successfully \n",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

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
            Deposit de = new Deposit();
            de.Show();
            this.Hide();
        }
    }
    
}
