namespace BeSpoked_Bikes
{
    partial class NewSaleForm
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
            this.Products_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Customers_ComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SalePersons_ComboBox = new System.Windows.Forms.ComboBox();
            this.New_Sale = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Display_Available = new System.Windows.Forms.Label();
            this.Item_Count_Sale = new System.Windows.Forms.TextBox();
            this.Customer_Exit = new System.Windows.Forms.Button();
            this.Reload_Sales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Products_ComboBox
            // 
            this.Products_ComboBox.FormattingEnabled = true;
            this.Products_ComboBox.Location = new System.Drawing.Point(111, 44);
            this.Products_ComboBox.Name = "Products_ComboBox";
            this.Products_ComboBox.Size = new System.Drawing.Size(414, 21);
            this.Products_ComboBox.TabIndex = 0;
            this.Products_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Products_ComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customers:";
            // 
            // Customers_ComboBox
            // 
            this.Customers_ComboBox.FormattingEnabled = true;
            this.Customers_ComboBox.Location = new System.Drawing.Point(111, 75);
            this.Customers_ComboBox.Name = "Customers_ComboBox";
            this.Customers_ComboBox.Size = new System.Drawing.Size(414, 21);
            this.Customers_ComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sale Person:";
            // 
            // SalePersons_ComboBox
            // 
            this.SalePersons_ComboBox.FormattingEnabled = true;
            this.SalePersons_ComboBox.Location = new System.Drawing.Point(111, 110);
            this.SalePersons_ComboBox.Name = "SalePersons_ComboBox";
            this.SalePersons_ComboBox.Size = new System.Drawing.Size(414, 21);
            this.SalePersons_ComboBox.TabIndex = 6;
            // 
            // New_Sale
            // 
            this.New_Sale.Location = new System.Drawing.Point(638, 172);
            this.New_Sale.Name = "New_Sale";
            this.New_Sale.Size = new System.Drawing.Size(89, 23);
            this.New_Sale.TabIndex = 7;
            this.New_Sale.Text = "New Sale";
            this.New_Sale.UseVisualStyleBackColor = true;
            this.New_Sale.Click += new System.EventHandler(this.New_Sale_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Avilabale Items:";
            // 
            // Display_Available
            // 
            this.Display_Available.AutoSize = true;
            this.Display_Available.Location = new System.Drawing.Point(635, 52);
            this.Display_Available.Name = "Display_Available";
            this.Display_Available.Size = new System.Drawing.Size(93, 13);
            this.Display_Available.TabIndex = 10;
            this.Display_Available.Text = "Display_Available:";
            // 
            // Item_Count_Sale
            // 
            this.Item_Count_Sale.Location = new System.Drawing.Point(746, 49);
            this.Item_Count_Sale.Name = "Item_Count_Sale";
            this.Item_Count_Sale.Size = new System.Drawing.Size(68, 20);
            this.Item_Count_Sale.TabIndex = 11;
            // 
            // Customer_Exit
            // 
            this.Customer_Exit.Location = new System.Drawing.Point(746, 172);
            this.Customer_Exit.Name = "Customer_Exit";
            this.Customer_Exit.Size = new System.Drawing.Size(75, 23);
            this.Customer_Exit.TabIndex = 12;
            this.Customer_Exit.Text = "Exit";
            this.Customer_Exit.UseVisualStyleBackColor = true;
            this.Customer_Exit.Click += new System.EventHandler(this.Customer_Exit_Click);
            // 
            // Reload_Sales
            // 
            this.Reload_Sales.Location = new System.Drawing.Point(542, 172);
            this.Reload_Sales.Name = "Reload_Sales";
            this.Reload_Sales.Size = new System.Drawing.Size(75, 23);
            this.Reload_Sales.TabIndex = 13;
            this.Reload_Sales.Text = "Reload";
            this.Reload_Sales.UseVisualStyleBackColor = true;
            this.Reload_Sales.Click += new System.EventHandler(this.Reload_Sales_Click);
            // 
            // NewSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 220);
            this.Controls.Add(this.Reload_Sales);
            this.Controls.Add(this.Customer_Exit);
            this.Controls.Add(this.Item_Count_Sale);
            this.Controls.Add(this.Display_Available);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.New_Sale);
            this.Controls.Add(this.SalePersons_ComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Customers_ComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Products_ComboBox);
            this.Name = "NewSaleForm";
            this.Text = "New Sale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Products_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Customers_ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SalePersons_ComboBox;
        private System.Windows.Forms.Button New_Sale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Display_Available;
        private System.Windows.Forms.TextBox Item_Count_Sale;
        private System.Windows.Forms.Button Customer_Exit;
        private System.Windows.Forms.Button Reload_Sales;
    }
}