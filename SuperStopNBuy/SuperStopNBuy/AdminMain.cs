/********************************
 * AdminMain.cs
 * Created by The Dev Doods
********************************/

using SuperStopNBuy.SuperStopNBuyClasses;
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
    public partial class AdminMain : Form
    {
        ManagerClass aManager = new ManagerClass();
        ManagerClass selectedManager = new ManagerClass();

        public AdminMain()
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new ManagementLogin();
            formTemp.Show();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            DataTable databaseTable = aManager.Select();
            datagridviewMain.DataSource = databaseTable;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTemp = new AdminManagerAdd();
            formTemp.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var formTemp = new AdminManagerEdit(selectedManager);
                this.Hide();
                formTemp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must Select A Value to Edit");
            }
        }

        private void datagridviewMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                selectedManager.managerUsername = datagridviewMain.Rows[rowIndex].Cells[0].Value.ToString();
                selectedManager.managerPassword = datagridviewMain.Rows[rowIndex].Cells[1].Value.ToString();
                selectedManager.managerFName = datagridviewMain.Rows[rowIndex].Cells[2].Value.ToString();
                selectedManager.managerLName = datagridviewMain.Rows[rowIndex].Cells[3].Value.ToString();
                selectedManager.managerAccessLvl = Convert.ToInt32(datagridviewMain.Rows[rowIndex].Cells[4].Value.ToString());
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedManager != null)
            {

                bool wasSucessful = selectedManager.DeleteDatabaseManager(selectedManager);
                if (wasSucessful)
                {
                    MessageBox.Show("Manager Successfully Deleted");
                }
                DataTable databaseTable = aManager.Select();
                datagridviewMain.DataSource = databaseTable;
            }
            else
            {
                MessageBox.Show("Manager must be selected");
            }
        }

        private void datagridviewMain_DataSourceChanged(object sender, EventArgs e)
        {
            if (datagridviewMain.Rows.Count != 0)
            {
                datagridviewMain.Rows[0].Selected = true;
            }
        }
    }
}
