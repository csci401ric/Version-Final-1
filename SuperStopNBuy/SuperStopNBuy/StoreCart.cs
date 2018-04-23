using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using SuperStopNBuy.SuperStopNBuyClasses;

namespace SuperStopNBuy
{
    public partial class StoreCart : Form
    {
        ArrayList cart;
        ItemClass selectedItem;
        int rowIndex;
        double passSum;

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


        public StoreCart(ArrayList passCart)
        {
            cart = passCart;
            InitializeComponent();
        }

        private void StoreCart_Load(object sender, EventArgs e)
        {
            double sum= 0;
            dataGridCart.ColumnCount = 3;
            dataGridCart.Columns[0].Name = "Product Name";
            dataGridCart.Columns[1].Name = "Product Price";
            dataGridCart.Columns[2].Name = "Product Number";

            foreach (ItemClass item in cart)
            {
                if (item != null)
                {
                    dataGridCart.Rows.Add(item.itemName, item.itemPrice, item.itemNumber);
                }
                else
                {
                    MessageBox.Show("An error has occured");
                }
            }

            foreach(ItemClass item in cart)
            {
                if(item == null)
                {
                    MessageBox.Show("An error has occured");
                    break;
                }
                sum += item.itemPrice;
            }

            labelPrice.Text = "$" + sum.ToString($"F{2}");
            passSum = sum;
        }

        private void dataGridCart_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedItem = new ItemClass();

            rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                selectedItem.itemName = dataGridCart.Rows[rowIndex].Cells[0].Value.ToString();
                selectedItem.itemPrice = Convert.ToDouble(dataGridCart.Rows[rowIndex].Cells[1].Value.ToString());
                selectedItem.itemNumber = Convert.ToInt32(dataGridCart.Rows[rowIndex].Cells[2].Value.ToString());
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            double sum =0;

            if (cart.Count > 0)
            {
                if (rowIndex >= 0)
                {
                    cart.RemoveAt(rowIndex);
                    dataGridCart.Rows.Clear();

                    foreach (ItemClass item in cart)
                    {
                        dataGridCart.Rows.Add(item.itemName, item.itemPrice, item.itemNumber);
                    }

                    foreach (ItemClass item in cart)
                    {
                        sum += item.itemPrice;
                    }

                    labelPrice.Text = "$" + sum.ToString($"F{2}");
                }
            }
            passSum = sum;

        }

        private void labelLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreCategory(cart);
            formTemp.Show();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (dataGridCart.Rows.Count == 0)
            {
                // Error
                MessageBox.Show("Cart is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Return
                return;
            }

            this.Hide();
            var formTemp = new StoreCheckOut(passSum);
            formTemp.Show();
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            cart.Clear();

            double sum = 0;
            dataGridCart.Rows.Clear();

            foreach (ItemClass item in cart)
            {
                dataGridCart.Rows.Add(item.itemName, item.itemPrice, item.itemNumber);
            }

            foreach (ItemClass item in cart)
            {
                sum += item.itemPrice;
            }

            labelPrice.Text = "$" + sum.ToString($"F{2}");
            passSum = sum;
        }

        private void buttonShopMoar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreCategory(cart);
            formTemp.Show();
        }

        private void dataGridCart_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridCart.Rows.Count != 0)
            {
                dataGridCart.Rows[0].Selected = true;
            }
        }
    }
}
