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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.printOrdersCheckbox = new System.Windows.Forms.CheckBox();
            this.shippinglinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDisplayBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippinglinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(859, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Manual Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.datecreatedDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.customernoteDataGridViewTextBoxColumn,
            this.paymentmethodtitleDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(981, 232);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "#";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datecreatedDataGridViewTextBoxColumn
            // 
            this.datecreatedDataGridViewTextBoxColumn.DataPropertyName = "date_created";
            this.datecreatedDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datecreatedDataGridViewTextBoxColumn.Name = "datecreatedDataGridViewTextBoxColumn";
            this.datecreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Znesek";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customernoteDataGridViewTextBoxColumn
            // 
            this.customernoteDataGridViewTextBoxColumn.DataPropertyName = "customer_note";
            this.customernoteDataGridViewTextBoxColumn.HeaderText = "Opombe";
            this.customernoteDataGridViewTextBoxColumn.Name = "customernoteDataGridViewTextBoxColumn";
            this.customernoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentmethodtitleDataGridViewTextBoxColumn
            // 
            this.paymentmethodtitleDataGridViewTextBoxColumn.DataPropertyName = "payment_method_title";
            this.paymentmethodtitleDataGridViewTextBoxColumn.HeaderText = "Način plačila";
            this.paymentmethodtitleDataGridViewTextBoxColumn.Name = "paymentmethodtitleDataGridViewTextBoxColumn";
            this.paymentmethodtitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Stranka";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WooCommerceNET.WooCommerce.v2.Order);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(748, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Print selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printOrdersCheckbox
            // 
            this.printOrdersCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printOrdersCheckbox.AutoSize = true;
            this.printOrdersCheckbox.Checked = true;
            this.printOrdersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printOrdersCheckbox.Location = new System.Drawing.Point(662, 493);
            this.printOrdersCheckbox.Name = "printOrdersCheckbox";
            this.printOrdersCheckbox.Size = new System.Drawing.Size(81, 17);
            this.printOrdersCheckbox.TabIndex = 4;
            this.printOrdersCheckbox.Text = "Print Orders";
            this.printOrdersCheckbox.UseVisualStyleBackColor = true;
            this.printOrdersCheckbox.Click += new System.EventHandler(this.printOrdersCheckbox_Click);
            // 
            // shippinglinesBindingSource
            // 
            this.shippinglinesBindingSource.DataMember = "shipping_lines";
            this.shippinglinesBindingSource.DataSource = this.orderBindingSource;
            // 
            // orderDisplayBox
            // 
            this.orderDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDisplayBox.Location = new System.Drawing.Point(12, 262);
            this.orderDisplayBox.Name = "orderDisplayBox";
            this.orderDisplayBox.Size = new System.Drawing.Size(280, 250);
            this.orderDisplayBox.TabIndex = 6;
            this.orderDisplayBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 524);
            this.Controls.Add(this.orderDisplayBox);
            this.Controls.Add(this.printOrdersCheckbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WooCommerce order printer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippinglinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox printOrdersCheckbox;
        private System.Windows.Forms.BindingSource shippinglinesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox orderDisplayBox;
    }
}

