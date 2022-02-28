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
    public partial class Dashboard : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public string username
        {
            get
            {
                return this.labelUsername.Text;
            }
            set
            {
                this.labelUsername.Text = value;
            }
        }
        public Dashboard()
        {
            InitializeComponent();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
            timer1.Stop();
        }
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3DateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = username;
            userControlDashboard1.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControl12.Hide();
            userControlClient2.Hide();
            userControlClientRooms1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            userControl12.Hide();
            userControlClientRooms1.Hide();
            userControlDashboard1.Hide();
            userControlReservation1.Hide();
            string connString = @"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True";
            string userrole = default;
            string sql = "SELECT UserRole FROM UserInfo WHERE UserName ='" + username + "';";
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
                userControlClient2.clear();
                userControlClient2.Show();
            }
            else
            {
                MessageBox.Show("You do not have access to view this page!", "Error");
            }
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRooms);
            userControl12.Hide();
            userControlClient2.Hide();
            userControlDashboard1.Hide();
            userControlReservation1.Hide();
            string connString = @"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True";
            string userrole = default;
            string sql = "SELECT UserRole FROM UserInfo WHERE UserName ='" + username + "';";
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
                userControlClientRooms1.clear();
                userControlClientRooms1.Show();
            }
            else
            {
                MessageBox.Show("You do not have access to view this page!", "Error");
            }
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControl12.Hide();
            userControlClient2.Hide();
            userControlClientRooms1.Hide();
            userControlDashboard1.Hide();
            userControlReservation1.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSettings);
            userControlClient2.Hide();
            userControlClientRooms1.Hide();
            userControlDashboard1.Hide();
            userControlReservation1.Hide();
            string connString = @"Data Source=Anurra;Initial Catalog=HotelManagementSystem;Integrated Security=True";
            string userrole = default;
            string sql = "SELECT UserRole FROM UserInfo WHERE UserName ='" + username + "';";
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
            if(userrole == "Administrator")
            {
                userControl12.Clear();
                userControl12.Show();
            }
            else
            {
                MessageBox.Show("You do not have access to view this page!", "Error");
            }

        }

    }
}
