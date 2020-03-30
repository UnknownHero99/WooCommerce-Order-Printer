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


namespace WooCommerceOrderPrinter
{
    public partial class Form1 : Form
    {
        WooCommerceNET.RestAPI rest;
        static WCObject wc;
        List<Order> orders;
        List<String> alreadyPrintedOrders = new List<String>();
        static bool printingEnabled = true;

        public Form1()
        {
            InitializeComponent();
            updateOrdersTableAsync(false);
            timer1.Start();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        public async Task<List<Order>> getOrders(WCObject wc, bool print = true) 
        {
            List<Order> orders = await wc.Order.GetAll();

            orders.Reverse();

            foreach (Order order in orders)
            {
                if (alreadyPrintedOrders.Contains(order.number))
                {
                    continue;
                }
                if (printingEnabled && print)
                {
                    //orderPopUpMessage(order);
                    printOrder(order);
                }
                alreadyPrintedOrders.Add(order.number);
                if(alreadyPrintedOrders.Count>10) alreadyPrintedOrders.Remove(alreadyPrintedOrders.First());
                Properties.Settings.Default["lastPrintedTicketID"] = order.number;
                Properties.Settings.Default.Save();
            }       
            return orders;
        }

        public void displayOrders(List<Order> orders)
        {
            orders.Reverse();
            dataGridView1.DataSource = orders;
        }

        public async Task updateOrdersTableAsync(bool print = true)
        {
            try
            {
                rest = new WooCommerceNET.RestAPI(Properties.Settings.Default.restAPIURL, Properties.Settings.Default.restAPIKey, Properties.Settings.Default.restAPISecret);
                wc = new WCObject(rest);
                orders = await getOrders(wc, print);
                displayOrders(orders);
            }
            catch (Exception e)
            {
                printErrorMessage(e.Message + "\n\nPREVERI!!!\nTiskanje spletnih naročil mogoče ne deluje");
            } 
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            updateOrdersTableAsync();
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.restAPIURL != "" &&
                Properties.Settings.Default.restAPIKey != "" &&
                Properties.Settings.Default.restAPISecret != "") updateOrdersTableAsync();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Order order = orders[e.RowIndex];
            orderPopUpMessage(order);
        }

        private static void orderPopUpMessage(Order order)
        {
            String orderDetails = printOrderMessage(order);
            Task.Run(() =>
            {
                MessageBox.Show(orderDetails, "Naročilo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            });

        }

        private static void printErrorMessage(String message)
        {
            PrintMessage(message);
        }

        private static string printOrderMessage(Order order)
        {
            String orderDetails = "";
            orderDetails += order.date_created + "  #" + order.number + "\n";
            //orderDetails += "TA IZPISEK JE V \nNAMENE TESTIRANJA" + "\n";
            orderDetails += "Stanje: " + order.status + "\n";
            if (order.customer_note != "")
            {
                orderDetails += "*************************" + "\n";
                orderDetails += "OPOMBE:" + order.customer_note + "\n";
            }
            orderDetails += "*************************" + "\n";
            orderDetails += "NAROČILO" + "\n";
            orderDetails += "*************************" + "\n";
            foreach (WooCommerceNET.WooCommerce.v2.OrderLineItem item in order.line_items)
            {
                for (var i = item.quantity; i > 0; i--)
                {
                    orderDetails += item.name + " " + item.price+ "€" + "\n";

                    if (item.variation_id != 0)
                    {
                        var varItems = wc.Product.Variations.Get((int)item.variation_id, (int)item.product_id);
                        while (varItems.Status != TaskStatus.RanToCompletion) ;
                        foreach (VariationAttribute variationAttribute in varItems.Result.attributes)
                        {
                            orderDetails += "  " + variationAttribute.name + ": " + variationAttribute.option + "\n";
                        }
                    }
                }
            }
            orderDetails += "*************************" + "\n";
            if(order.discount_total != 0) orderDetails += "POPUST(" + order.coupon_lines + "): " + order.discount_total + "\n";
            orderDetails += "Seštevek: " + (order.total-order.shipping_total) + "€\n";
            orderDetails += "Embalaža: " + order.shipping_total + "€\n";
            orderDetails += "Končni Znesek: " + order.total + "€\n";
            orderDetails += "Način plačila: " + order.payment_method_title + "\n";
            orderDetails += "*************************" + "\n";
            orderDetails += "NASLOV" + "\n";
            orderDetails += "*************************" + "\n";
            orderDetails += order.shipping.first_name + "\n";
            orderDetails += order.shipping.last_name + "\n";
            orderDetails += order.shipping.address_1 + "\n";
            if(order.shipping.address_2 != "") orderDetails += order.shipping.address_2 + "\n";
            orderDetails += order.shipping.city + "\n";
            orderDetails += order.shipping.postcode + "\n";
            orderDetails += order.shipping.country + "\n";
            orderDetails += order.billing.phone + "\n";
            return orderDetails;
        }

        private static void printOrder(Order order)
        {
            String printMessage = printOrderMessage(order);
            PrintMessage(printMessage);
        }

        private static void PrintMessage(String message)
        {
            PrintDocument p = new PrintDocument();
            p.PrinterSettings.PrinterName = Properties.Settings.Default.Printer;
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(message, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

            };

            try
            {
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order orderToPrint = orders.Find(order => order.number == dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            printOrder(orderToPrint);
        }

        private void printOrdersCheckbox_Click(object sender, EventArgs e)
        {
            if (printingEnabled)
            {
                DialogResult d = MessageBox.Show("Are you sure you want to disable order printing?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == DialogResult.No)
                {
                    printOrdersCheckbox.Checked = !printOrdersCheckbox.Checked;
                    return;
                }
            }
            printingEnabled = !printingEnabled;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool CloseCancel()
        {
            const string message = "Are you sure you want to quit?";
            const string caption = "Are you sure?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
    }
}
