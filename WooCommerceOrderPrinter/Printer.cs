using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;

namespace WooCommerceOrderPrinter
{
    class Printer : System.Drawing.Printing.PrintDocument
    {

        public Font PrinterFont { get; set; }
        public string TextToPrint { get; set; }

        // Static variable to hold the current character we're currently
        // dealing with.
        static int curChar;

        public Printer() : base()
        {
            //Set our Text property to an empty string
            TextToPrint = string.Empty;
        }

        public Printer(string str) : base()
        {
            //Set our Text property value
            TextToPrint = str;
        }

        protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs e)
        {
            // Run base code
            base.OnBeginPrint(e);

            //Check to see if the user provided a font
            //if they didn't then we default to Times New Roman
            if (PrinterFont == null)
            {
                //Create the font we need
                PrinterFont = new Font("Times New Roman", 10);
            }
        }

        public static void printErrorMessage(String message)
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
                    orderDetails += item.name + " " + item.price + "€" + "\n";

                    foreach (WooCommerceNET.WooCommerce.v2.OrderMeta orderMeta in item.meta_data)
                    {
                        orderDetails += " -" + orderMeta.key + ": " + orderMeta.value + "\n";
                    }
                }
            }
            orderDetails += "*************************" + "\n";
            if (order.discount_total != 0)
            {
                orderDetails += "POPUST" + "\n";
                orderDetails += "*************************" + "\n";
                foreach (WooCommerceNET.WooCommerce.v2.OrderCouponLine couponLine in order.coupon_lines)
                {
                    orderDetails += "(" + couponLine.code + "): " + couponLine.discount + "\n";
                }
                orderDetails += "CELOTEN POPUST: " + order.discount_total + "\n";
                orderDetails += "*************************" + "\n";
            }
            orderDetails += "Seštevek: " + (order.total - order.shipping_total) + "€\n";
            orderDetails += "Embalaža: " + order.shipping_total + "€\n";
            orderDetails += "*************************" + "\n";
            orderDetails += "KONČNI ZNESEK: " + order.total + "€\n";
            orderDetails += "Način plačila: " + order.payment_method_title + "\n";
            orderDetails += "*************************" + "\n";
            orderDetails += "NASLOV" + "\n";
            orderDetails += "*************************" + "\n";
            orderDetails += order.shipping.first_name + "\n";
            orderDetails += order.shipping.last_name + "\n";
            orderDetails += order.shipping.address_1 + "\n";
            if (order.shipping.address_2 != "") orderDetails += order.shipping.address_2 + "\n";
            orderDetails += order.shipping.city + "\n";
            orderDetails += order.shipping.postcode + "\n";
            orderDetails += order.shipping.country + "\n";
            orderDetails += order.billing.phone + "\n";
            return orderDetails;
        }

        public static void printOrder(Order order)
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



    }
}
