/********************************
 * ManagementLogin.cs
 * Created by The Dev Doods
********************************/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperStopNBuy
{
    public partial class ManagementLogin : Form
    {
        public ManagementLogin()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Initialize
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Open form
            this.Hide();
            DemoMain formDemoMain = new DemoMain();
            formDemoMain.Show();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            // Check user name text box
            if (String.IsNullOrEmpty(textboxUsername.Text))
            {
                MessageBox.Show("Please enter the user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check password text box
            if (String.IsNullOrEmpty(textboxPassword.Text))
            {
                MessageBox.Show("Please enter the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Login
            if (CheckUserIDAndPassword())
            {
                if (GetAccessLevel() == 1)
                {
                    this.Hide();
                    var formTemp = new ManagementItemView();
                    formTemp.Show();
                }
                else if (GetAccessLevel() == 2)
                {
                    this.Hide();
                    var formTemp = new AdminMain();
                    formTemp.Show();
                }
                else
                {
                    MessageBox.Show("Access level is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User ID or password are invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetAccessLevel()
        {
            // Variables
            int accessLevel = 0;

            // Connect to database
            using (MySqlConnection databaseConnect = new MySqlConnection(Global.ConnectionString))
            {
                // Open connection
                try
                {
                    databaseConnect.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                // Get data
                MySqlCommand databaseCommand = new MySqlCommand("SELECT accessLevel FROM manager WHERE username=@0 AND password=@1", databaseConnect);
                databaseCommand.Parameters.Add(new MySqlParameter("0", textboxUsername.Text));
                databaseCommand.Parameters.Add(new MySqlParameter("1", textboxPassword.Text));

                // Read data
                using (MySqlDataReader databaseReader = databaseCommand.ExecuteReader())
                {
                    while (databaseReader.Read())
                    {
                        // Check if userid and password are valid
                        if (databaseReader.HasRows)
                        {
                            accessLevel = databaseReader.GetInt32(0);
                        }
                    }
                }
            }

            // Return access level
            return accessLevel;
        }

        private bool CheckUserIDAndPassword()
        {
            // Variables
            bool isValid = false;

            // Connect to database
            using (MySqlConnection databaseConnect = new MySqlConnection(Global.ConnectionString))
            {
                // Open connection
                try
                {
                    databaseConnect.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                // Get data
                MySqlCommand databaseCommand = new MySqlCommand("SELECT username, password FROM manager WHERE username=@0 AND password=@1", databaseConnect);
                databaseCommand.Parameters.Add(new MySqlParameter("0", textboxUsername.Text));
                databaseCommand.Parameters.Add(new MySqlParameter("1", textboxPassword.Text));

                // Read data
                using (MySqlDataReader databaseReader = databaseCommand.ExecuteReader())
                {
                    while (databaseReader.Read())
                    {
                        // Check if userid and password are valid
                        if (databaseReader.HasRows)
                        {
                            isValid = true;
                        }
                    }
                }
            }

            // Return if userid and password are valid
            return isValid;
        }
    }
}
