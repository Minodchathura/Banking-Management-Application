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
    public partial class View_Account : Form
    {
        public View_Account()
        {
            InitializeComponent();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            Admin_Panel admin_panel = new Admin_Panel();
            admin_panel.Show();
            this.Hide();
        }

        

        private void button_account_Click(object sender, EventArgs e)
        {
            Account_Creation ac = new Account_Creation();
            ac.Show();
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
           Users us = new Users();
            us.Show();
            this.Hide();
        }

        private void button_view_search_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE AccountNumber = @account", con);
                cmd.Parameters.AddWithValue("@account", textBox_se_acount.Text);

                cmd.CommandType = CommandType.Text;

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);

                if (dt.Rows.Count == 0)
                {
                    dataGridView_viewaccounts.DataSource = null;

                    MessageBox.Show(
                        "Account Number not found.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                dataGridView_viewaccounts.DataSource = dt;
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

        private void View_Account_Load(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.conString;
            SqlConnection con = new SqlConnection(conString);


            try {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", con);
                cmd.CommandType = CommandType.Text;

                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);

                if (dt.Rows.Count == 0)
                {
                    dataGridView_viewaccounts.DataSource = null;
                    return;
                }
                dataGridView_viewaccounts.DataSource = dt;
            }

            catch(Exception ex) 
            {
                    MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void dataGridView_viewaccounts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_viewaccounts.Rows[e.RowIndex].Cells[0].Value);
            Update_Account_Form update = new Update_Account_Form(id);
            update.Show();
            this.Hide();
        }

        private void dataGridView_viewaccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit de = new Deposit();
            de.Show();
            this.Hide();
        }
    }
}
