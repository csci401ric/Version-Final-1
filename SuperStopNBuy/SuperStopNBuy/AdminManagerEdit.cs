/********************************
 * AdminManagerEdit.cs
 * Created by The Dev Doods
********************************/

using SuperStopNBuy.SuperStopNBuyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperStopNBuy
{
    public partial class AdminManagerEdit : Form
    {
        ManagerClass aManager = new ManagerClass();

        public AdminManagerEdit()
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

        public AdminManagerEdit(ManagerClass aManager)
        {
            InitializeComponent();

            textboxUsername.Text = aManager.managerUsername;
            textboxPassword.Text = aManager.managerPassword;
            textboxFirstName.Text = aManager.managerFName;
            textboxLastName.Text = aManager.managerLName;
            comboBoxAccessLevel.Text = aManager.managerAccessLvl.ToString();
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            int tempVal = 0;

            // Check first name text box
            if (String.IsNullOrEmpty(textboxFirstName.Text))
            {
                MessageBox.Show("Please enter the first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check last name text box
            if (String.IsNullOrEmpty(textboxLastName.Text))
            {
                MessageBox.Show("Please enter the last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            // Check access level combo box
            if (String.IsNullOrEmpty(comboBoxAccessLevel.Text))
            {
                MessageBox.Show("Please enter the access level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if combo box is integer
            if (!Int32.TryParse(comboBoxAccessLevel.Text, out tempVal))
            {
                MessageBox.Show("Access level must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            aManager.managerUsername = textboxUsername.Text;
            aManager.managerPassword = textboxPassword.Text;
            aManager.managerFName = textboxFirstName.Text;
            aManager.managerLName = textboxLastName.Text;
            aManager.managerAccessLvl = Convert.ToInt32(comboBoxAccessLevel.Text);

            bool wasSucessful = aManager.UpdateDatabaseManager(aManager);
            if (wasSucessful)
            {
                MessageBox.Show("Update Successful");
            }
            else
            {
                MessageBox.Show("Update Not Successful");
            }

            this.Hide();
            var formTemp = new AdminMain();
            formTemp.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes will not be saved");
            this.Hide();
            var formTemp = new AdminMain();
            formTemp.Show();
        }
    }
}
