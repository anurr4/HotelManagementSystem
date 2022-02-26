using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username, pass;
            username = textBoxEmail.Text;
            pass = textBoxPassword.Text;
            
            conn = new SqlConnection(@"Data Source=DESKTOP-IUGPBCH;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    MessageBox.Show("Please fill out the Login Form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "SELECT * FROM UserInfo WHERE UserName='" + textBoxEmail.Text + "' AND pass ='" + textBoxPassword.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dtable = new DataTable();
                    adapter.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        username = textBoxEmail.Text;
                        pass = textBoxPassword.Text;
                        Dashboard dash = new Dashboard();
                        dash.Visible = true;
                        dash.username = textBoxEmail.Text;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmail.Clear();
                        textBoxPassword.Clear();
                    }
                }
            
                
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Close Application", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
