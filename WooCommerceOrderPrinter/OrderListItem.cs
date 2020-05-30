using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WooCommerceOrderPrinter
{
    public partial class OrderListItem : UserControl
    {
        public OrderListItem(WooCommerceNET.WooCommerce.v2.OrderLineItem item)
        {
            InitializeComponent();
            ItemNameLabel.Text = item.name;
            itemMetaLabel.Text = "";
            foreach (WooCommerceNET.WooCommerce.v2.OrderMeta orderMeta in item.meta_data)
            {
                itemMetaLabel.Text += orderMeta.key + "- " + orderMeta.value + "\n";
            }
            if (itemMetaLabel.Text == "") itemMetaLabel.Visible = false;
        }
    }
}
