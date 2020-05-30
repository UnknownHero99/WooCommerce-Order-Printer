namespace WooCommerceOrderPrinter
{
    partial class OrderListItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.itemMetaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(91, 20);
            this.ItemNameLabel.TabIndex = 0;
            this.ItemNameLabel.Text = "Item name";
            // 
            // itemMetaLabel
            // 
            this.itemMetaLabel.AutoSize = true;
            this.itemMetaLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemMetaLabel.Location = new System.Drawing.Point(10, 16);
            this.itemMetaLabel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 0);
            this.itemMetaLabel.Name = "itemMetaLabel";
            this.itemMetaLabel.Size = new System.Drawing.Size(101, 16);
            this.itemMetaLabel.TabIndex = 1;
            this.itemMetaLabel.Text = "item meta data";
            // 
            // OrderListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.itemMetaLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Name = "OrderListItem";
            this.Size = new System.Drawing.Size(260, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label itemMetaLabel;
    }
}
