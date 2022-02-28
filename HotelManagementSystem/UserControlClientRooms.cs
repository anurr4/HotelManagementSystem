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
    public partial class UserControlClientRooms : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        private string No = "", Free = "";
        public UserControlClientRooms()
        {
            InitializeComponent();
        }
        public void clear()
        {
            comboBoxRoomType.SelectedIndex = -1;
            textBoxPhone.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            tabControlRooms.SelectedTab = tabPageAddRoom;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked)
                Free = "Yes";
            if (radioButtonNo.Checked)
                Free = "No";
            if (string.IsNullOrEmpty(comboBoxRoomType.SelectedItem.ToString()) || string.IsNullOrEmpty(textBoxPhone.Text) || string.IsNullOrEmpty(Free))
            {
                MessageBox.Show("Please fill in the room information you wish to add!", "Error");
            }
            else
            {
                conn = new SqlConnection(@"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                conn.Open();
                String st = "INSERT INTO RoomTable VALUES('" + comboBoxRoomType.SelectedItem.ToString() + "', '" + textBoxPhone.Text + "', '"+Free+"');";
                SqlCommand sqlcom = new SqlCommand(st, conn);
                try
                {
                    sqlcom.ExecuteNonQuery();
                    MessageBox.Show("Room Added Successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            clear();
            clear1();
        }

        private void tabPageSearch_Enter(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            conn.Open();
            adapter = new SqlDataAdapter("Select * From RoomTable", conn);
            adapter.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewRoom.DataSource = dt;
        }
        

        private void tabPageSearch_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoom.Clear();
        }

        private void textBoxSearchRoom_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * From RoomTable WHERE RoomNumber LIKE '%" + textBoxSearchRoom.Text + "%';", conn);
            adapter.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewRoom.DataSource = dt;
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                No = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                textBoxPhone1.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();
                if (Free == "Yes")
                    radioButtonYes1.Checked = true;
                if (Free == "No")
                    radioButtonNo1.Checked = true;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                Free = "Yes";
            if (radioButtonNo1.Checked)
                Free = "No";
            if(No != "") {
                if (string.IsNullOrEmpty(comboBoxType1.SelectedItem.ToString()) || string.IsNullOrEmpty(textBoxPhone1.Text) || string.IsNullOrEmpty(Free))
                {
                    MessageBox.Show("Please fill in the Room information you wish to edit!", "Error");
                }
                else
                {
                    conn = new SqlConnection(@"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                    conn.Open();
                    String st = "UPDATE RoomTable SET RoomType = '" + comboBoxType1.SelectedItem.ToString() + "', RoomPhone = '" + textBoxPhone1.Text + "', RoomFree = '"+ Free +"'  WHERE RoomNumber = "+No+";";
                    SqlCommand sqlcom = new SqlCommand(st, conn);
                    try
                    {
                        sqlcom.ExecuteNonQuery();
                        MessageBox.Show("Room Updated Successfully!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row from the table first!", "Error!");
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                Free = "Yes";
            if (radioButtonNo1.Checked)
                Free = "No";
            if (No != "") {
                if (string.IsNullOrEmpty(comboBoxType1.SelectedItem.ToString()) || string.IsNullOrEmpty(textBoxPhone1.Text) || string.IsNullOrEmpty(Free))
                {
                    MessageBox.Show("Please fill in the Room information you wish to remove!", "Error");
                }
                else
                {
                    conn = new SqlConnection(@"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                    conn.Open();
                    String st = "DELETE FROM RoomTable WHERE RoomNumber = " + No + ";";
                    SqlCommand sqlcom = new SqlCommand(st, conn);
                    try
                    {
                        sqlcom.ExecuteNonQuery();
                        MessageBox.Show("Room Deleted Successfully!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row from the table first!","Error");
            }
            
        }

        private void tabPageEdit_Leave(object sender, EventArgs e)
        {
            clear1();
        }

        public void clear1()
        {
            comboBoxType1.SelectedItem = -1;
            textBoxPhone1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            No = "";
        }
    }
}
