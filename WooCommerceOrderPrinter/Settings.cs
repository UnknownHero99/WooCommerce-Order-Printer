using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WooCommerceOrderPrinter
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            // load settings
            APIURLTextBox.Text = Properties.Settings.Default.restAPIURL;
            APISecretTextBox.Text = Properties.Settings.Default.restAPISecret;
            APIKeyTextBox.Text = Properties.Settings.Default.restAPIKey;
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                PrinterComboBox.Items.Add(printer);
            }
            PrinterComboBox.SelectedItem = Properties.Settings.Default.Printer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["restAPIURL"] = APIURLTextBox.Text;
            Properties.Settings.Default["restAPISecret"] = APISecretTextBox.Text;
            Properties.Settings.Default["restAPIKey"] = APIKeyTextBox.Text;
            Properties.Settings.Default["printer"] = PrinterComboBox.SelectedItem;
            Properties.Settings.Default.Save();
            Close();
        }

    }
}
