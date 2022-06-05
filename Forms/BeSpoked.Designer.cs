namespace BeSpoked_Bikes
{
    partial class BeSpoked
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
            this.Products_button = new System.Windows.Forms.Button();
            this.SalesPersons_Button = new System.Windows.Forms.Button();
            this.Customers_button = new System.Windows.Forms.Button();
            this.Sale_button = new System.Windows.Forms.Button();
            this.Qrt_Sale_Report_Button = new System.Windows.Forms.Button();
            this.New_Sale_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Products_button
            // 
            this.Products_button.Location = new System.Drawing.Point(26, 34);
            this.Products_button.Name = "Products_button";
            this.Products_button.Size = new System.Drawing.Size(84, 23);
            this.Products_button.TabIndex = 0;
            this.Products_button.Text = "Products";
            this.Products_button.UseVisualStyleBackColor = true;
            this.Products_button.Click += new System.EventHandler(this.Products_button_Click);
            // 
            // SalesPersons_Button
            // 
            this.SalesPersons_Button.Location = new System.Drawing.Point(134, 34);
            this.SalesPersons_Button.Name = "SalesPersons_Button";
            this.SalesPersons_Button.Size = new System.Drawing.Size(88, 23);
            this.SalesPersons_Button.TabIndex = 1;
            this.SalesPersons_Button.Text = "Sale Persons";
            this.SalesPersons_Button.UseVisualStyleBackColor = true;
            this.SalesPersons_Button.Click += new System.EventHandler(this.SalesPersons_Button_Click);
            // 
            // Customers_button
            // 
            this.Customers_button.Location = new System.Drawing.Point(250, 34);
            this.Customers_button.Name = "Customers_button";
            this.Customers_button.Size = new System.Drawing.Size(85, 23);
            this.Customers_button.TabIndex = 2;
            this.Customers_button.Text = "Customers";
            this.Customers_button.UseVisualStyleBackColor = true;
            this.Customers_button.Click += new System.EventHandler(this.Customers_button_Click);
            // 
            // Sale_button
            // 
            this.Sale_button.Location = new System.Drawing.Point(367, 34);
            this.Sale_button.Name = "Sale_button";
            this.Sale_button.Size = new System.Drawing.Size(89, 23);
            this.Sale_button.TabIndex = 3;
            this.Sale_button.Text = "Sales";
            this.Sale_button.UseVisualStyleBackColor = true;
            this.Sale_button.Click += new System.EventHandler(this.Sale_button_Click);
            // 
            // Qrt_Sale_Report_Button
            // 
            this.Qrt_Sale_Report_Button.Location = new System.Drawing.Point(609, 34);
            this.Qrt_Sale_Report_Button.Name = "Qrt_Sale_Report_Button";
            this.Qrt_Sale_Report_Button.Size = new System.Drawing.Size(107, 23);
            this.Qrt_Sale_Report_Button.TabIndex = 4;
            this.Qrt_Sale_Report_Button.Text = "Qrt Sales Report";
            this.Qrt_Sale_Report_Button.UseVisualStyleBackColor = true;
            this.Qrt_Sale_Report_Button.Click += new System.EventHandler(this.Qrt_Sale_Report_Button_Click);
            // 
            // New_Sale_Button
            // 
            this.New_Sale_Button.Location = new System.Drawing.Point(498, 34);
            this.New_Sale_Button.Name = "New_Sale_Button";
            this.New_Sale_Button.Size = new System.Drawing.Size(75, 23);
            this.New_Sale_Button.TabIndex = 5;
            this.New_Sale_Button.Text = "New Sale";
            this.New_Sale_Button.UseVisualStyleBackColor = true;
            this.New_Sale_Button.Click += new System.EventHandler(this.New_Sale_Button_Click);
            // 
            // BeSpoked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 89);
            this.Controls.Add(this.New_Sale_Button);
            this.Controls.Add(this.Qrt_Sale_Report_Button);
            this.Controls.Add(this.Sale_button);
            this.Controls.Add(this.Customers_button);
            this.Controls.Add(this.SalesPersons_Button);
            this.Controls.Add(this.Products_button);
            this.Name = "BeSpoked";
            this.Text = "BeSpoked Bikes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Products_button;
        private System.Windows.Forms.Button SalesPersons_Button;
        private System.Windows.Forms.Button Customers_button;
        private System.Windows.Forms.Button Sale_button;
        private System.Windows.Forms.Button Qrt_Sale_Report_Button;
        private System.Windows.Forms.Button New_Sale_Button;
    }
}

