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
    public partial class OrderList : UserControl
    {
        public OrderList(Order order, WCObject Wc)
        {
            InitializeComponent();
            this.order = order;
            wc = Wc;
            orderIDLabel.Text = "#" + order.number;
            orderTimeLabel.Text = order.date_created.Value.ToString("dd.MM HH:mm");
            orderStatusLabel.Text = order.status;
            customerNotesLabel.Text = order.customer_note;
            if (order.discount_total != 0)
            {
                customerNotesLabel.Text += "\nPOPUST" + "\n";
                customerNotesLabel.Text += "*************************" + "\n";
                foreach (WooCommerceNET.WooCommerce.v2.OrderCouponLine couponLine in order.coupon_lines)
                {
                    customerNotesLabel.Text += "[" + couponLine.code + "]: " + couponLine.discount + "\n";
                }
                customerNotesLabel.Text += "CELOTEN POPUST: " + order.discount_total + "\n";
                customerNotesLabel.Text += "*************************" + "\n";
            }
            if (customerNotesLabel.Text == "") customerNotesLabel.Visible = false;
            deliveryAddressLabel.Text = "";
            deliveryAddressLabel.Text += order.shipping.first_name + "\n";
            deliveryAddressLabel.Text += order.shipping.last_name + "\n";
            deliveryAddressLabel.Text += order.shipping.address_1 + "\n";
            if (order.shipping.address_2 != "") deliveryAddressLabel.Text += order.shipping.address_2 + "\n";
            deliveryAddressLabel.Text += order.shipping.city + "\n";
            deliveryAddressLabel.Text += order.shipping.postcode + "\n";
            deliveryAddressLabel.Text += order.shipping.country + "\n";
            deliveryAddressLabel.Text += order.billing.phone + "\n";
            populateItems(order);
            timer1_Tick(null, null);
            timer1.Start();
        }

        private Order order;
        private WCObject wc;

        private void populateItems(Order order)
        {
            foreach (WooCommerceNET.WooCommerce.v2.OrderLineItem item in order.line_items)
            {
                for (var i = item.quantity; i > 0; i--)
                {
                    OrderListItem orderListItem = new OrderListItem(item);
                    flowLayoutPanel1.Controls.Add(orderListItem);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now.Subtract(order.date_created.Value);
            timeElapsedLabel.Text = timeElapsed.TotalMinutes.ToString("F0") + " min";
            if (timeElapsed.TotalMinutes < 5) panel1.BackColor = Color.FromArgb(39, 174, 96);
            else if (timeElapsed.TotalMinutes < 10) panel1.BackColor = Color.FromArgb(241, 196, 15);
            else if (timeElapsed.TotalMinutes < 15) panel1.BackColor = Color.FromArgb(243, 156, 18);
            else if (timeElapsed.TotalMinutes < 20) panel1.BackColor = Color.FromArgb(230, 126, 34);
            else if (timeElapsed.TotalMinutes < 25) panel1.BackColor = Color.FromArgb(211, 84, 0);
            else if (timeElapsed.TotalMinutes < 30) panel1.BackColor = Color.FromArgb(231, 76, 60);
            else panel1.BackColor = Color.FromArgb(192, 57, 43);
        }

        private void rePrintOrderButton_Click(object sender, EventArgs e)
        {
            Printer.printOrder(order);
        }
        private async void completeOrderButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)ParentForm;
            form.flowLayoutPanel1.Controls.Remove(this);
            var response = await wc.Order.Update((int)order.id, new Order { status = "completed" }); 
            await form.updateOrdersTableAsync();
        }
    }
}
