using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Deployment.Application;

namespace WooCommerceOrderPrinter
{
    public partial class Form1 : Form
    {
        private string GetVersion => ApplicationDeployment.IsNetworkDeployed ? $"Version: {ApplicationDeployment.CurrentDeployment.CurrentVersion}" : $"Version: {Application.ProductVersion}";

        public Form1()
        {
            InitializeComponent();
            this.Text = Text + " " + GetVersion;
            updateOrdersTableAsync();//load previous orders
            timer1.Start();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

       
        public void displayOrders(List<Order> orders)
        {
            flowLayoutPanel1.Controls.Clear();
            OrderList[] ordersList = new OrderList[orders.Count];
            for (int i = 0; i < ordersList.Length; i++)
            {
                if (orders[i].status.ToString() != "processing" && !WoocommerceHandler.ShowCompletedOrders) continue;
                ordersList[i] = new OrderList(orders[i], WoocommerceHandler.Wc);
                flowLayoutPanel1.Controls.Add(ordersList[i]);
            }
        }

        public async Task updateOrdersTableAsync(bool print = true)
        {
            try
            {
                await WoocommerceHandler.updateOrders(print);
                displayOrders(WoocommerceHandler.Orders);
            }
            catch (Exception e)
            {
                Printer.printErrorMessage(e.ToString() + "\n\nPREVERI!!!\nTiskanje spletnih naročil mogoče ne deluje");
            }
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.restAPIURL != "" &&
                Properties.Settings.Default.restAPIKey != "" &&
                Properties.Settings.Default.restAPISecret != "") await updateOrdersTableAsync();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
                return;
            };
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool CloseCancel()
        {
            const string message = "Si prepričan da želiš zapreti program? (naročila se ne tiskajo)";
            const string caption = "Si prepričan?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void manualUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await updateOrdersTableAsync();
        }

        private void disableOrderPrintingParameterToolstripMenu(object sender, EventArgs e)
        {
            if (WoocommerceHandler.PrintingEnabled)
            {
                DialogResult d = MessageBox.Show("Si prepričan da želiš onemogočiti tiskanje naročil?", "Si prepričan?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == DialogResult.No)
                {
                    return;
                }
                d = MessageBox.Show("Si prepričan da želiš onemogočiti tiskanje naročil?", "Si prepričan?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.No)
                {
                    return;
                }
            }
            WoocommerceHandler.PrintingEnabled = !WoocommerceHandler.PrintingEnabled;
            disablePrintingStripMenuItem.Text = WoocommerceHandler.PrintingEnabled ? "Onemogoči tiskanje naročil" : "Omogoči tiskanje naročil";

        }

        private void showCompletedOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WoocommerceHandler.ShowCompletedOrders = !WoocommerceHandler.ShowCompletedOrders;
            showCompletedOrdersToolStripMenuItem.Text = WoocommerceHandler.ShowCompletedOrders ? "Skrij končana naročila" : "Prikaži končana naročila";
            displayOrders(WoocommerceHandler.Orders);
        }
    }
}
