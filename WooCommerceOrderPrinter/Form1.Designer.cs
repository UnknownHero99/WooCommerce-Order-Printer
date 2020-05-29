namespace WooCommerceOrderPrinter
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCompletedOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippinglinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippinglinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.printSelectedToolStripMenuItem,
            this.manualUpdateToolStripMenuItem,
            this.tiskanjeToolStripMenuItem,
            this.showCompletedOrdersToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // printSelectedToolStripMenuItem
            // 
            this.printSelectedToolStripMenuItem.Name = "printSelectedToolStripMenuItem";
            resources.ApplyResources(this.printSelectedToolStripMenuItem, "printSelectedToolStripMenuItem");
            this.printSelectedToolStripMenuItem.Click += new System.EventHandler(this.printSelectedToolStripMenuItem_Click);
            // 
            // manualUpdateToolStripMenuItem
            // 
            this.manualUpdateToolStripMenuItem.Name = "manualUpdateToolStripMenuItem";
            resources.ApplyResources(this.manualUpdateToolStripMenuItem, "manualUpdateToolStripMenuItem");
            this.manualUpdateToolStripMenuItem.Click += new System.EventHandler(this.manualUpdateToolStripMenuItem_Click);
            // 
            // tiskanjeToolStripMenuItem
            // 
            this.tiskanjeToolStripMenuItem.Name = "tiskanjeToolStripMenuItem";
            resources.ApplyResources(this.tiskanjeToolStripMenuItem, "tiskanjeToolStripMenuItem");
            this.tiskanjeToolStripMenuItem.Click += new System.EventHandler(this.changePrintOrdersParameterToolstripMenu);
            // 
            // showCompletedOrdersToolStripMenuItem
            // 
            this.showCompletedOrdersToolStripMenuItem.Name = "showCompletedOrdersToolStripMenuItem";
            resources.ApplyResources(this.showCompletedOrdersToolStripMenuItem, "showCompletedOrdersToolStripMenuItem");
            this.showCompletedOrdersToolStripMenuItem.Click += new System.EventHandler(this.showCompletedOrdersToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WooCommerceNET.WooCommerce.v2.Order);
            // 
            // shippinglinesBindingSource
            // 
            this.shippinglinesBindingSource.DataMember = "shipping_lines";
            this.shippinglinesBindingSource.DataSource = this.orderBindingSource;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippinglinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shippinglinesBindingSource;
        private System.Windows.Forms.ToolStripMenuItem printSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskanjeToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem showCompletedOrdersToolStripMenuItem;
    }
}

