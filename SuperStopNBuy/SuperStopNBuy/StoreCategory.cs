/********************************
 * StoreCategory.cs
 * Created by Michael M.
********************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperStopNBuy.SuperStopNBuyClasses;
using System.Collections;
using System.IO;

namespace SuperStopNBuy
{
    public partial class StoreCategory : Form
    {
        ItemClass selectedItem;
        ItemClass anItem = new ItemClass();
        String passedCategory;
        bool isSearch = false;
        ArrayList cart;

        public StoreCategory()
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

        public StoreCategory(String passed)
        {
            cart = new ArrayList();
            passedCategory = passed;
            InitializeComponent();
        }

        public StoreCategory(ArrayList passedList)
        {
            cart = new ArrayList(passedList);
            InitializeComponent();
            labelCartAmt.Text = "(" + cart.Count + ")";
        }

        public StoreCategory(String passed, bool passedBool)
        {
            cart = new ArrayList();
            isSearch = passedBool;
            passedCategory = passed;
            InitializeComponent();
        }

        private void labelLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cart will be emptied");
            this.Hide();
            var formTemp = new StoreMain();
            formTemp.Show();
        }

        private void StoreCategory_Load(object sender, EventArgs e)
        {
            if (isSearch == false)
            {
                DataTable databaseTable = anItem.SelectCategory(passedCategory);
                dataGridCategory.DataSource = databaseTable;
            }
            else
            {
                DataTable databaseTable = anItem.SelectSearch(passedCategory, false);
                dataGridCategory.DataSource = databaseTable;
            }
        }

        private void buttonProduce_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Produce");
            dataGridCategory.DataSource = databaseTable;
        }

        private void buttonMeatDeli_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Meat/Deli");
            dataGridCategory.DataSource = databaseTable;
        }

        private void buttonFrozen_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Frozen");
            dataGridCategory.DataSource = databaseTable;
        }

        private void buttonGrocery_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Grocery");
            dataGridCategory.DataSource = databaseTable;
        }

        private void buttonDairy_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Dairy");
            dataGridCategory.DataSource = databaseTable;
        }

        private void buttonBakery_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectCategory("Bakery");
            dataGridCategory.DataSource = databaseTable;
        }

        private void textboxSearch_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataTable databaseTable = anItem.SelectSearch(textboxSearch.Text, false);
            dataGridCategory.DataSource = databaseTable;
        }

        public async void dataGridCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedItem = new ItemClass();
            int rowIndex = e.RowIndex;
            string srcFileName, trgFileName;
            DropboxTools dropboxTools = new DropboxTools();
            if (rowIndex >= 0)
            {
                selectedItem.itemName = dataGridCategory.Rows[rowIndex].Cells[0].Value.ToString();
                selectedItem.itemPrice = Convert.ToDouble(dataGridCategory.Rows[rowIndex].Cells[1].Value.ToString());
                selectedItem.itemNumber = Convert.ToInt32(dataGridCategory.Rows[rowIndex].Cells[2].Value.ToString());

                srcFileName = Global.AppDirectory + selectedItem.itemNumber + Global.AppExtension;
                trgFileName = Global.GetTemporaryDownloadPath() + selectedItem.itemNumber + Global.AppExtension;
                try
                {
                    await dropboxTools.DownloadToPictureBox(srcFileName, trgFileName, pictureBoxItem);
                }
                catch
                {
                    // Error
                }
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreCart(cart);
            formTemp.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                cart.Add(selectedItem);
                labelCartAmt.Text = "(" + cart.Count + ")";
            }
        }

        private void dataGridCategory_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridCategory.Rows.Count != 0)
            {
                dataGridCategory.Rows[0].Selected = true;
            }
        }
    }
}
