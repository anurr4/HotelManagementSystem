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
    public partial class UserControl1 : UserControl
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommandBuilder scb;
        DataTable dt;
        private string ID = "";
        public UserControl1()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxEmail.Clear();   
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }
        private void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxEmail1.Clear();
            textBoxPassword1.Clear();
        }


        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Please fill in the user information you wish to add!", "Error");
            }
            else
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-IUGPBCH;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                conn.Open();
                String st = "INSERT INTO UserInfo(UserName, email, pass)VALUES('" + textBoxUsername.Text + "', '" + textBoxEmail.Text + "','"+textBoxPassword.Text+"')";
                SqlCommand sqlcom = new SqlCommand(st, conn );
                try
                {
                    sqlcom.ExecuteNonQuery();
                    MessageBox.Show("User Inserted Successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-IUGPBCH;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            conn.Open();
            adapter = new SqlDataAdapter("Select * From UserInfo", conn);
            adapter.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                textBoxEmail1.Text = row.Cells[2].Value.ToString();
                textBoxPassword1.Text = row.Cells[3].Value.ToString();
                comboBoxRoles.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if(ID != "")
            {
                if (string.IsNullOrEmpty(textBoxUsername1.Text) || string.IsNullOrEmpty(textBoxEmail1.Text) || string.IsNullOrEmpty(textBoxPassword1.Text))
                {
                    MessageBox.Show("Please fill in the user information you wish to add!", "Error");
                }
                else
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-IUGPBCH;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                    conn.Open();
                    int where = Convert.ToInt32(ID) + 1;
                    String st = "UPDATE UserInfo SET UserName = '"+textBoxUsername1.Text+"', email = '"+textBoxEmail1.Text+"', pass = '"+textBoxPassword1.Text+"', UserRole='"+comboBoxRoles.Text+"' WHERE UserID = "+ID+";";
                    SqlCommand sqlcom = new SqlCommand(st, conn);
                    try
                    {
                        sqlcom.ExecuteNonQuery();
                        MessageBox.Show("User Updated Successfully!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (string.IsNullOrEmpty(textBoxUsername1.Text) || string.IsNullOrEmpty(textBoxEmail1.Text) || string.IsNullOrEmpty(textBoxPassword1.Text))
                {
                    MessageBox.Show("Please fill in the user information you wish to add!", "Error");
                }
                else
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-IUGPBCH;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                    conn.Open();
                    String st = "DELETE FROM UserInfo WHERE UserID = "+ID+";";
                    SqlCommand sqlcom = new SqlCommand(st, conn);
                    try
                    {
                        sqlcom.ExecuteNonQuery();
                        MessageBox.Show("Client Deleted Successfully!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-IUGPBCH;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            conn.Open();
            adapter = new SqlDataAdapter("Select * From UserInfo WHERE UserName LIKE '%"+textBox3.Text+"%';", conn);
            adapter.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
