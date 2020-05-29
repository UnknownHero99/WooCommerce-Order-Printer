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
            this.components = new System.ComponentModel.Container();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.finishOrderButton = new System.Windows.Forms.Button();
            this.orderTimeLabel = new System.Windows.Forms.Label();
            this.orderItemsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderStatusLabel = new System.Windows.Forms.Label();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rePrintOrderButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDLabel.Location = new System.Drawing.Point(21, 15);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(106, 20);
            this.orderIDLabel.TabIndex = 0;
            this.orderIDLabel.Text = "order #";
            this.orderIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // finishOrderButton
            // 
            this.finishOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishOrderButton.Location = new System.Drawing.Point(264, 400);
            this.finishOrderButton.Margin = new System.Windows.Forms.Padding(10);
            this.finishOrderButton.Name = "finishOrderButton";
            this.finishOrderButton.Size = new System.Drawing.Size(99, 28);
            this.finishOrderButton.TabIndex = 1;
            this.finishOrderButton.Text = "Končaj naročilo";
            this.finishOrderButton.UseVisualStyleBackColor = true;
            this.finishOrderButton.Click += new System.EventHandler(this.finishOrderButton_Click);
            // 
            // orderTimeLabel
            // 
            this.orderTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTimeLabel.Location = new System.Drawing.Point(168, 15);
            this.orderTimeLabel.Name = "orderTimeLabel";
            this.orderTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderTimeLabel.Size = new System.Drawing.Size(187, 20);
            this.orderTimeLabel.TabIndex = 2;
            this.orderTimeLabel.Text = "orderTime";
            this.orderTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderItemsLabel
            // 
            this.orderItemsLabel.AutoEllipsis = true;
            this.orderItemsLabel.AutoSize = true;
            this.orderItemsLabel.Location = new System.Drawing.Point(22, 88);
            this.orderItemsLabel.Name = "orderItemsLabel";
            this.orderItemsLabel.Size = new System.Drawing.Size(32, 13);
            this.orderItemsLabel.TabIndex = 3;
            this.orderItemsLabel.Text = "Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.timeElapsedLabel);
            this.panel1.Controls.Add(this.orderStatusLabel);
            this.panel1.Controls.Add(this.orderTimeLabel);
            this.panel1.Controls.Add(this.orderIDLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 68);
            this.panel1.TabIndex = 4;
            // 
            // orderStatusLabel
            // 
            this.orderStatusLabel.AutoSize = true;
            this.orderStatusLabel.Location = new System.Drawing.Point(22, 45);
            this.orderStatusLabel.Name = "orderStatusLabel";
            this.orderStatusLabel.Size = new System.Drawing.Size(61, 13);
            this.orderStatusLabel.TabIndex = 3;
            this.orderStatusLabel.Text = "orderStatus";
            this.orderStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsedLabel.Location = new System.Drawing.Point(268, 45);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(75, 13);
            this.timeElapsedLabel.TabIndex = 4;
            this.timeElapsedLabel.Text = "timeElapsed";
            this.timeElapsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rePrintOrderButton
            // 
            this.rePrintOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rePrintOrderButton.Location = new System.Drawing.Point(10, 400);
            this.rePrintOrderButton.Margin = new System.Windows.Forms.Padding(10);
            this.rePrintOrderButton.Name = "rePrintOrderButton";
            this.rePrintOrderButton.Size = new System.Drawing.Size(99, 28);
            this.rePrintOrderButton.TabIndex = 5;
            this.rePrintOrderButton.Text = "Ponovno natisni";
            this.rePrintOrderButton.UseVisualStyleBackColor = true;
            this.rePrintOrderButton.Click += new System.EventHandler(this.rePrintOrderButton_Click);
            // 
            // OrderListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rePrintOrderButton);
            this.Controls.Add(this.finishOrderButton);
            this.Controls.Add(this.orderItemsLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OrderListItem";
            this.Size = new System.Drawing.Size(373, 438);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.Button finishOrderButton;
        private System.Windows.Forms.Label orderTimeLabel;
        private System.Windows.Forms.Label orderItemsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label orderStatusLabel;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button rePrintOrderButton;
    }
}
