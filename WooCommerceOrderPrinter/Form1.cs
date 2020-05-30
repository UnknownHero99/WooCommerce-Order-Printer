﻿using System;
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


namespace WooCommerceOrderPrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateOrdersTableAsync(false);//load previous orders wihout printing them
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
            await WoocommerceHandler.updateOrders(print);
            displayOrders(WoocommerceHandler.Orders);
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

        private void printSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Order orderToPrint = orders.Find(order => order.number == dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            //printOrder(orderToPrint);
        }

        private void changePrintOrdersParameterToolstripMenu(object sender, EventArgs e)
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
            
        }

        private void showCompletedOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WoocommerceHandler.ShowCompletedOrders = !WoocommerceHandler.ShowCompletedOrders;
            showCompletedOrdersToolStripMenuItem.Text = WoocommerceHandler.ShowCompletedOrders ? "Skrij končana naročila" : "Prikaži končana naročila";
            displayOrders(WoocommerceHandler.Orders);
        }
    }
}
