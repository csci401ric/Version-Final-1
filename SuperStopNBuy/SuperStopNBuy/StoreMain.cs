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

namespace SuperStopNBuy
{
    public partial class StoreMain : Form
    {

        public StoreMain()
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

        private void buttonProduce_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreCategory("Produce");
            formTemp.Show();
        }

        private void buttonMeatDeli_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreCategory("Meat/Deli");
            formTemp.Show();
        }

        private void buttonGrocery_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreCategory("Grocery");
            formTemp.Show();
        }

        private void buttonBakery_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreCategory("Bakery");
            formTemp.Show();
        }

        private void buttonFrozen_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreCategory("Frozen");
            formTemp.Show();
        }

        private void buttonDairy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreCategory("Dairy");
            formTemp.Show();
        }

        private void textboxSearch_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new StoreCategory(textboxSearch.Text, true);
            formTemp.Show();
        }

    }
}
