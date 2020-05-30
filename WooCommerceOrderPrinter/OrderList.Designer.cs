namespace WooCommerceOrderPrinter
{
    partial class OrderList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.orderStatusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rePrintOrderButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customerNotesLabel = new System.Windows.Forms.Label();
            this.deliveryAddressLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderIDLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDLabel.ForeColor = System.Drawing.Color.White;
            this.orderIDLabel.Location = new System.Drawing.Point(21, 9);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(106, 20);
            this.orderIDLabel.TabIndex = 0;
            this.orderIDLabel.Text = "order #";
            this.orderIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // finishOrderButton
            // 
            this.finishOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishOrderButton.Location = new System.Drawing.Point(212, 122);
            this.finishOrderButton.Margin = new System.Windows.Forms.Padding(10);
            this.finishOrderButton.Name = "finishOrderButton";
            this.finishOrderButton.Size = new System.Drawing.Size(99, 28);
            this.finishOrderButton.TabIndex = 1;
            this.finishOrderButton.Text = "Zaključi naročilo";
            this.finishOrderButton.UseVisualStyleBackColor = true;
            this.finishOrderButton.Click += new System.EventHandler(this.completeOrderButton_Click);
            // 
            // orderTimeLabel
            // 
            this.orderTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderTimeLabel.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.orderTimeLabel.ForeColor = System.Drawing.Color.White;
            this.orderTimeLabel.Location = new System.Drawing.Point(124, 32);
            this.orderTimeLabel.Name = "orderTimeLabel";
            this.orderTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderTimeLabel.Size = new System.Drawing.Size(187, 20);
            this.orderTimeLabel.TabIndex = 2;
            this.orderTimeLabel.Text = "orderTime";
            this.orderTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.timeElapsedLabel);
            this.panel1.Controls.Add(this.orderStatusLabel);
            this.panel1.Controls.Add(this.orderTimeLabel);
            this.panel1.Controls.Add(this.orderIDLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 52);
            this.panel1.TabIndex = 4;
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsedLabel.ForeColor = System.Drawing.Color.White;
            this.timeElapsedLabel.Location = new System.Drawing.Point(171, 9);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(140, 20);
            this.timeElapsedLabel.TabIndex = 4;
            this.timeElapsedLabel.Text = "timeElapsed";
            this.timeElapsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderStatusLabel
            // 
            this.orderStatusLabel.AutoSize = true;
            this.orderStatusLabel.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatusLabel.ForeColor = System.Drawing.Color.White;
            this.orderStatusLabel.Location = new System.Drawing.Point(22, 35);
            this.orderStatusLabel.Name = "orderStatusLabel";
            this.orderStatusLabel.Size = new System.Drawing.Size(69, 15);
            this.orderStatusLabel.TabIndex = 3;
            this.orderStatusLabel.Text = "orderStatus";
            this.orderStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rePrintOrderButton
            // 
            this.rePrintOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rePrintOrderButton.Location = new System.Drawing.Point(10, 122);
            this.rePrintOrderButton.Margin = new System.Windows.Forms.Padding(10);
            this.rePrintOrderButton.Name = "rePrintOrderButton";
            this.rePrintOrderButton.Size = new System.Drawing.Size(99, 28);
            this.rePrintOrderButton.TabIndex = 5;
            this.rePrintOrderButton.Text = "Ponovno natisni";
            this.rePrintOrderButton.UseVisualStyleBackColor = true;
            this.rePrintOrderButton.Click += new System.EventHandler(this.rePrintOrderButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.customerNotesLabel);
            this.flowLayoutPanel1.Controls.Add(this.deliveryAddressLabel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 58);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(301, 39);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // customerNotesLabel
            // 
            this.customerNotesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customerNotesLabel.AutoSize = true;
            this.customerNotesLabel.BackColor = System.Drawing.Color.Transparent;
            this.customerNotesLabel.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.customerNotesLabel.Location = new System.Drawing.Point(3, 17);
            this.customerNotesLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.customerNotesLabel.Name = "customerNotesLabel";
            this.customerNotesLabel.Size = new System.Drawing.Size(124, 20);
            this.customerNotesLabel.TabIndex = 5;
            this.customerNotesLabel.Text = "customer notes";
            this.customerNotesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deliveryAddressLabel
            // 
            this.deliveryAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deliveryAddressLabel.AutoSize = true;
            this.deliveryAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.deliveryAddressLabel.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryAddressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deliveryAddressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deliveryAddressLabel.Location = new System.Drawing.Point(3, 0);
            this.deliveryAddressLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.deliveryAddressLabel.Name = "deliveryAddressLabel";
            this.deliveryAddressLabel.Size = new System.Drawing.Size(94, 15);
            this.deliveryAddressLabel.TabIndex = 7;
            this.deliveryAddressLabel.Text = "delivery address";
            this.deliveryAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.finishOrderButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rePrintOrderButton);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OrderList";
            this.Size = new System.Drawing.Size(321, 160);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.Button finishOrderButton;
        private System.Windows.Forms.Label orderTimeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label orderStatusLabel;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button rePrintOrderButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label customerNotesLabel;
        private System.Windows.Forms.Label deliveryAddressLabel;
    }
}
