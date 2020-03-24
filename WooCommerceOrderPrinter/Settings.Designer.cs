namespace WooCommerceOrderPrinter
{
    partial class Settings
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
            this.APIURLTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.APIKeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.APISecretTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PrinterComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // APIURLTextBox
            // 
            this.APIURLTextBox.Location = new System.Drawing.Point(113, 39);
            this.APIURLTextBox.Name = "APIURLTextBox";
            this.APIURLTextBox.Size = new System.Drawing.Size(211, 20);
            this.APIURLTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "API Key";
            // 
            // APIKeyTextBox
            // 
            this.APIKeyTextBox.Location = new System.Drawing.Point(113, 65);
            this.APIKeyTextBox.Name = "APIKeyTextBox";
            this.APIKeyTextBox.Size = new System.Drawing.Size(211, 20);
            this.APIKeyTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "API Secret";
            // 
            // APISecretTextBox
            // 
            this.APISecretTextBox.Location = new System.Drawing.Point(113, 91);
            this.APISecretTextBox.Name = "APISecretTextBox";
            this.APISecretTextBox.Size = new System.Drawing.Size(211, 20);
            this.APISecretTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Printer";
            // 
            // PrinterComboBox
            // 
            this.PrinterComboBox.FormattingEnabled = true;
            this.PrinterComboBox.Location = new System.Drawing.Point(113, 117);
            this.PrinterComboBox.Name = "PrinterComboBox";
            this.PrinterComboBox.Size = new System.Drawing.Size(211, 21);
            this.PrinterComboBox.TabIndex = 9;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 286);
            this.Controls.Add(this.PrinterComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.APISecretTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.APIKeyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APIURLTextBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox APIURLTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox APIKeyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox APISecretTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PrinterComboBox;
    }
}