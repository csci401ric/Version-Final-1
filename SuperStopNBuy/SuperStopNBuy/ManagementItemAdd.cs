/********************************
 * ManagementItemAdd.cs
 * Created by The Dev Doods
********************************/

using SuperStopNBuy.SuperStopNBuyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperStopNBuy
{
    public partial class ManagementItemAdd : Form
    {
        ItemClass anItem = new ItemClass();

        public ManagementItemAdd()
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

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Check name text box
            if (String.IsNullOrEmpty(textboxName.Text))
            {
                MessageBox.Show("Please enter the product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check price text box
            if (String.IsNullOrEmpty(textboxPrice.Text))
            {
                MessageBox.Show("Please enter the product price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check number text box
            if (String.IsNullOrEmpty(textboxNumber.Text))
            {
                MessageBox.Show("Please enter the product number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check category combo box
            if (String.IsNullOrEmpty(comboBoxCategory.Text))
            {
                MessageBox.Show("Please enter the product category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check picture box
            if (pictureBoxImport.Image == null)
            {
                MessageBox.Show("Please select an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DropboxTools dropboxTools = new DropboxTools();

            anItem.itemName = textboxName.Text;
            anItem.itemNumber = Convert.ToInt32(textboxNumber.Text);
            anItem.itemPrice = Convert.ToDouble(textboxPrice.Text);
            anItem.itemCategory = comboBoxCategory.Text;

            bool wasSuccessful = anItem.InsertToDatabase(anItem);

            try
            {
                this.Enabled = false;
                await dropboxTools.Upload(openFileDialogImport.FileName, Path.Combine(Global.AppDirectory, textboxNumber.Text + Global.AppExtension));
            }
            catch
            {
                wasSuccessful = false;
            }

            if (wasSuccessful)
            {
                MessageBox.Show("Successful");
            }

            this.Hide();
            var formTemp = new ManagementItemView();
            formTemp.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new ManagementItemView();
            formTemp.Show();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (openFileDialogImport.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Variables
                Image importPicture;

                // Get picture
                importPicture = Image.FromFile(openFileDialogImport.FileName);

                // Check picture size
                if (importPicture.Height != 150 || importPicture.Width != 150)
                {
                    // Clear data
                    pictureBoxImport.Image = null;
                    openFileDialogImport.FileName = String.Empty;

                    // Error
                    MessageBox.Show("Image size must be exactly 150 x 150", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Set picture box to selected picture
                    pictureBoxImport.Image = importPicture;
                }
            }
        }
    }
}
