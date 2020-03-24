using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;

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

        

    }
}
