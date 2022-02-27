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
    public partial class UserControlClient : UserControl
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommandBuilder scb;
        DataTable dt;
        private string ID = "";
        public UserControlClient()
        {
            InitializeComponent();
        }
        public void clear()
        {
            textBoxFName.Clear();
            textBoxLName.Clear();
            textBoxPhone.Clear();
            textBoxAddress.Clear();
            tabControlClient.SelectedTab = tabPageAddClient;
        }
        public void clear1()
        {
            textBoxFName1.Clear();
            textBoxLName1.Clear();
            textBoxPhone1.Clear();
            textBoxAddress1.Clear();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFName.Text) || string.IsNullOrEmpty(textBoxLName.Text) || string.IsNullOrEmpty(textBoxPhone.Text) || string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Please fill in the client information you wish to add!", "Error");
            }
            else
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-IUGPBCH;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                conn.Open();
                String st = "INSERT INTO ClientInfo(ClientN, ClientLN, ClientPhone, ClientAddress)VALUES('"+textBoxFName.Text+"', '"+textBoxLName.Text+"', '"+textBoxPhone.Text+"', '"+textBoxAddress.Text+"')";
                SqlCommand sqlcom = new SqlCommand(st, conn);
                try
                {
                    sqlcom.ExecuteNonQuery();
                    MessageBox.Show("Client Added Successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            clear();
        }

        private void tabPageSearch_Leave(object sender, EventArgs e)
        {
            textBoxSearchPhone.Clear();
        }

       


        private void textBoxSearchPhone_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * From ClientInfo WHERE ClientPhone LIKE '%" + textBoxSearchPhone.Text + "%';", conn);
            adapter.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewClient.DataSource = dt;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (string.IsNullOrEmpty(textBoxFName1.Text) || string.IsNullOrEmpty(textBoxLName1.Text) || string.IsNullOrEmpty(textBoxPhone1.Text) || string.IsNullOrEmpty(textBoxAddress1.Text))
                {
                    MessageBox.Show("Please fill in the client information you wish to add!", "Error");
                }
                else
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-IUGPBCH;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                    conn.Open();
                    String st = "UPDATE ClientInfo SET ClientN = '" + textBoxFName1.Text + "', ClientLN = '" + textBoxLName1.Text + "', ClientPhone = '" + textBoxPhone1.Text + "', ClientAddress ='" + textBoxAddress1.Text + "' WHERE ClientID = " + ID + ";";
                    SqlCommand sqlcom = new SqlCommand(st, conn);
                    try
                    {
                        sqlcom.ExecuteNonQuery();
                        MessageBox.Show("Client Updated Successfully!");
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
                if (string.IsNullOrEmpty(textBoxFName1.Text) || string.IsNullOrEmpty(textBoxLName1.Text) || string.IsNullOrEmpty(textBoxPhone1.Text) || string.IsNullOrEmpty(textBoxAddress1.Text))
                {
                    MessageBox.Show("Please fill in the Client information you wish to add!", "Error");
                }
                else
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-IUGPBCH;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                    conn.Open();
                    String st = "DELETE FROM ClientInfo WHERE ClientID = " + ID + ";";
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

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxFName1.Text = row.Cells[1].Value.ToString();
                textBoxLName1.Text = row.Cells[2].Value.ToString();
                textBoxPhone1.Text = row.Cells[3].Value.ToString();
                textBoxAddress1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void tabPageEdit_Leave(object sender, EventArgs e)
        {
            clear1();
        }

        private void tabPageSearch_Enter(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-IUGPBCH;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            conn.Open();
            adapter = new SqlDataAdapter("Select * From ClientInfo", conn);
            adapter.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewClient.DataSource = dt;
        }

        
    }
}
