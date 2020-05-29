using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET;

namespace WooCommerceOrderPrinter
{
    public partial class OrderListItem : UserControl
    {
        public OrderListItem(Order order, WCObject Wc)
        {
            InitializeComponent();
            this.order = order;
            wc = Wc;
            orderIDLabel.Text = "#" + order.number;
            orderTimeLabel.Text = order.date_created.ToString();
            orderStatusLabel.Text = order.status;
            orderItemsLabel.Text = orderItems(order);
            timer1_Tick(null, null);
            timer1.Start();
        }

        private Order order;
        private WCObject wc;

        private static string orderItems(Order order)
        {
            String orderItems = "";
            if (order.customer_note != "")
            {
                orderItems += "*************************" + "\n";
                orderItems += "OPOMBE:" + order.customer_note + "\n";
            }
            orderItems += "*************************" + "\n";
            foreach (WooCommerceNET.WooCommerce.v2.OrderLineItem item in order.line_items)
            {
                for (var i = item.quantity; i > 0; i--)
                {
                    orderItems += item.name + " " + item.price + "€" + "\n";

                    foreach (WooCommerceNET.WooCommerce.v2.OrderMeta orderMeta in item.meta_data)
                    {
                        orderItems += " -" + orderMeta.key + ": " + orderMeta.value + "\n";
                    }
                }
            }
            orderItems += "*************************" + "\n";
            if (order.discount_total != 0)
            {
                orderItems += "POPUST" + "\n";
                orderItems += "*************************" + "\n";
                foreach (WooCommerceNET.WooCommerce.v2.OrderCouponLine couponLine in order.coupon_lines)
                {
                    orderItems += "(" + couponLine.code + "): " + couponLine.discount + "\n";
                }
                orderItems += "CELOTEN POPUST: " + order.discount_total + "\n";
                orderItems += "*************************" + "\n";
            }
            orderItems += "Seštevek: " + (order.total - order.shipping_total) + "€\n";
            orderItems += "Embalaža: " + order.shipping_total + "€\n";
            orderItems += "*************************" + "\n";
            orderItems += "KONČNI ZNESEK: " + order.total + "€\n";
            orderItems += "Način plačila: " + order.payment_method_title + "\n";
            orderItems += "*************************" + "\n";
            orderItems += "NASLOV" + "\n";
            orderItems += "*************************" + "\n";
            orderItems += order.shipping.first_name + "\n";
            orderItems += order.shipping.last_name + "\n";
            orderItems += order.shipping.address_1 + "\n";
            if (order.shipping.address_2 != "") orderItems += order.shipping.address_2 + "\n";
            orderItems += order.shipping.city + "\n";
            orderItems += order.shipping.postcode + "\n";
            orderItems += order.shipping.country + "\n";
            orderItems += order.billing.phone + "\n";
            return orderItems;
        }
        private async void finishOrderButton_Click(object sender, EventArgs e)
        {
            var response = await wc.Order.Update((int)order.id, new Order { status = "completed" });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now.Subtract(order.date_created.Value);
            timeElapsedLabel.Text = timeElapsed.ToString(@"d\ \ hh\:mm\:ss");
            if (timeElapsed.TotalMinutes < 5) panel1.BackColor = Color.Green;
            else if (timeElapsed.TotalMinutes < 10) panel1.BackColor = Color.GreenYellow;
            else if (timeElapsed.TotalMinutes < 15) panel1.BackColor = Color.Yellow;
            else if (timeElapsed.TotalMinutes < 20) panel1.BackColor = Color.Orange;
            else if (timeElapsed.TotalMinutes < 25) panel1.BackColor = Color.DarkOrange;
            else if (timeElapsed.TotalMinutes < 30) panel1.BackColor = Color.OrangeRed;
            else panel1.BackColor = Color.Red;
        }

        private void rePrintOrderButton_Click(object sender, EventArgs e)
        {
            Printer.printOrder(order);
        }
    }
}
