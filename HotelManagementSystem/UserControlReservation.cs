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
    public partial class UserControlReservation : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private string RID = "",No;
        Login lg = new Login();
        public UserControlReservation()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            comboBoxRoomType.SelectedIndex = 0;
            textBoxClientID.Clear();
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value = DateTime.Now;
            tabControlReservations.SelectedTab = tabPageAddReservation;
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            
            
            comboBoxRoomType.SelectedIndex = 0;
            comboBoxRoomType1.SelectedIndex = 0;
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxRoomType.SelectedIndex==-1 || comboBoxRoomNumber.SelectedIndex==-1 || string.IsNullOrEmpty(textBoxClientID.Text))
            {
                MessageBox.Show("Please fill in the room information you wish to add!", "Error");
            }
            else
            {
                conn = new SqlConnection(@"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                conn.Open();
                String st = "INSERT INTO ReservationTable VALUES('" + comboBoxRoomType.SelectedItem.ToString() + "', '" + comboBoxRoomNumber.SelectedItem.ToString()+ "', '" + textBoxClientID.Text + "', '"+dateTimePickerIN.Text+"', '"+dateTimePickerOUT.Text+"');";
                SqlCommand sqlcom = new SqlCommand(st, conn);
                try
                {
                    sqlcom.ExecuteNonQuery();
                    MessageBox.Show("Reservation Added Successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tabPageSearch_Enter(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            conn.Open();
            adapter = new SqlDataAdapter("Select * From ReservationTable", conn);
            adapter.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewReservation.DataSource = dt;
        }

        private void tabPageSearch_Leave(object sender, EventArgs e)
        {
            textBoxSearchReservation.Clear();
        }

        private void textBoxSearchReservation_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * From ReservationTable WHERE ReservationClientID LIKE '%" + textBoxSearchReservation.Text + "%';", conn);
            adapter.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewReservation.DataSource = dt;
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();
                comboBoxRoomType1.SelectedItem = row.Cells[1].Value.ToString();
                No = row.Cells[3].Value.ToString();
                dateTimePickerIN1.Text = row.Cells[4].Value.ToString();
                dateTimePickerOUT.Text = row.Cells[5].Value.ToString();
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if(RID != "")
            {
                if (comboBoxRoomType1.SelectedIndex == -1 || comboBoxRoomNumber1.SelectedIndex == -1 || string.IsNullOrEmpty(textBoxClientID1.Text))
                {
                    MessageBox.Show("Please fill in the reservation information you wish to edit!", "Error");
                }
                else
                {
                    conn = new SqlConnection(@"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                    conn.Open();
                    String st = "UPDATE ReservationTable SET ReservationRoomType = '" + comboBoxRoomType1.SelectedItem.ToString() + "', ReservationRoomNumber = '" + comboBoxRoomNumber1.SelectedItem.ToString() + "', ReservationClientID = '" + textBoxClientID1.Text + "', ReservationIN = '" + dateTimePickerIN1.Text + "', ReservationOUT = '" + dateTimePickerOUT1.Text + "' WHERE ReservationID = " + RID + ";";
                    SqlCommand sqlcom = new SqlCommand(st, conn);
                    try
                    {
                        sqlcom.ExecuteNonQuery();
                        MessageBox.Show("Reservation Updated Successfully!");
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
            if (RID != "")
            {
                if (comboBoxRoomType1.SelectedIndex == 0 || comboBoxRoomNumber1.SelectedIndex == 0 || string.IsNullOrEmpty(textBoxClientID1.Text))
                {
                    MessageBox.Show("Please fill in the reservation information you wish to cancel!", "Error");
                }
                else
                {
                    conn = new SqlConnection(@"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                    conn.Open();
                    String st = "DELETE FROM ReservationTable WHERE ReservationID = " + RID + ";";
                    SqlCommand sqlcom = new SqlCommand(st, conn);
                    try
                    {
                        sqlcom.ExecuteNonQuery();
                        MessageBox.Show("Reservation cancelled Successfully!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row from the table first!", "Error");
            }
        }

        private void tabPageEdit_Leave(object sender, EventArgs e)
        {
            Clear1();
        }


        private void tabPageEdit_Enter(object sender, EventArgs e)
        {
            string connString = @"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True";
            string userrole = default;
            string sql = "SELECT UserRole FROM UserInfo WHERE UserName ='" + lg.Username() + "';";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    userrole = (string)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
            if (userrole == "Administrator")
            {
                tabPageEdit.Show();
            }
            else
            {
                MessageBox.Show("You do not have access to view this page!", "Error");
                tabPageEdit.Hide();
            }
        }

        private void comboBoxRoomType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = @"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True";
            int rooms;
            string sql = "SELECT RoomNumber FROM RoomTable WHERE RoomType ='" + comboBoxRoomType1.SelectedItem.ToString() + "' AND RoomFree = 'Yes' ORDER BY RoomNumber;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    rooms = (int)cmd.ExecuteScalar();
                    comboBoxRoomNumber1.Items.Add(rooms.ToString());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = @"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True";
            int rooms;
            string sql = "SELECT RoomNumber FROM RoomTable WHERE RoomType ='" + comboBoxRoomType.SelectedItem.ToString() + "' AND RoomFree = 'Yes' ORDER BY RoomNumber;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    rooms = (int)cmd.ExecuteScalar();
                    comboBoxRoomNumber.Items.Add(rooms.ToString());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Clear1()
        {
            comboBoxRoomType1.SelectedIndex = 0;
            textBoxClientID1.Clear();
            dateTimePickerIN1.Value = DateTime.Now;
            dateTimePickerOUT1.Value = DateTime.Now;
            RID = "";
        }
    }
}
