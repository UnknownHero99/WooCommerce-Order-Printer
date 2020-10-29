using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;

namespace WooCommerceOrderPrinter
{
    class WoocommerceHandler
    {
        static WooCommerceNET.RestAPI rest;
        static WCObject wc;
        static List<Order> orders;
        static bool printingEnabled = true;
        static bool showCompletedOrders = false;

        public static bool PrintingEnabled { get => printingEnabled; set => printingEnabled = value; }
        public static RestAPI Rest { get => rest; set => rest = value; }
        public static WCObject Wc { get => wc; set => wc = value; }
        public static List<Order> Orders { get => orders; set => orders = value; }
        public static bool ShowCompletedOrders { get => showCompletedOrders; set => showCompletedOrders = value; }

        public async static Task updateOrders(bool print = true)
        {
            try
            {
                WoocommerceHandler.Rest = new WooCommerceNET.RestAPI(Properties.Settings.Default.restAPIURL, Properties.Settings.Default.restAPIKey, Properties.Settings.Default.restAPISecret);
                WoocommerceHandler.Wc = new WCObject(WoocommerceHandler.Rest);
                WoocommerceHandler.Orders = await getOrders(WoocommerceHandler.Wc, print);
            }
            catch (Exception e)
            {
                Printer.printErrorMessage(e.ToString() + "\n\nPREVERI!!!\nTiskanje spletnih naročil mogoče ne deluje");
            }
        }

        private static async Task<List<Order>> getOrders(WCObject wc, bool print = true)
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                //dic.Add("status", "processing");
                dic.Add("per_page", "10");
                List<Order> orders = await wc.Order.GetAll(dic);
                orders.Reverse();

                foreach (Order order in orders)
                {
                    if (Properties.Settings.Default.LastPrintedOrderTimeStamp == default(DateTime))
                    {
                        Properties.Settings.Default["LastPrintedOrderTimeStamp"] = DateTime.Now;
                        Properties.Settings.Default.Save();
                    }
                    if ( DateTime.Compare((DateTime)order.date_created, Properties.Settings.Default.LastPrintedOrderTimeStamp) <= 0)
                    {
                        continue;
                    }
                    if (WoocommerceHandler.PrintingEnabled && print)
                    {
                        //orderPopUpMessage(order);
                        Printer.printOrder(order);
                    }
                    Properties.Settings.Default["LastPrintedOrderTimeStamp"] = (DateTime)order.date_created;
                    Properties.Settings.Default.Save();
                }
                orders.Reverse();
                return orders;
            }
            catch(Exception e)
            {
                Printer.printErrorMessage(e.ToString() + "\n\nPREVERI!!!\nTiskanje spletnih naročil mogoče ne deluje");
            }
            return null;
        }

    }
}
