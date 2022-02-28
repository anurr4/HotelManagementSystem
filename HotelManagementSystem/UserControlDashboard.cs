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
    public partial class UserControlDashboard : UserControl
    {


        int UserCount, ClientCount, RoomCount;
        public UserControlDashboard()
        {
            InitializeComponent();
        }
        //DESKTOP-IUGPBCH
        private void User()
        {
            string connString = @"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True";
            string select = "SELECT COUNT (*) FROM UserInfo";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(select, conn);
                try
                {
                    conn.Open();
                    UserCount = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
            labelUsers.Text = UserCount.ToString();
        }
        private void Client()
        {
            string connString = @"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True";
            string select = "SELECT COUNT (*) FROM ClientInfo";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(select, conn);
                try
                {
                    conn.Open();
                    ClientCount = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
            labelClients.Text = ClientCount.ToString();
        }
        private void Rooms()
        {
            string connString = @"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True";
            string select = "SELECT COUNT (*) FROM RoomTable";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(select, conn);
                try
                {
                    conn.Open();
                    RoomCount = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error");
                }
            }
            labelRooms.Text = RoomCount.ToString();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            User();
            Client();
            Rooms();
        }
    }
}
