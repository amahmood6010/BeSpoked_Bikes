namespace BeSpoked_Bikes
{
    partial class Products_Form
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
            this.Product_Exit_button = new System.Windows.Forms.Button();
            this.Product_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Manufacture_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.Style_textBox = new System.Windows.Forms.TextBox();
            this.Purchase_Price_textBox = new System.Windows.Forms.TextBox();
            this.Sale_Price_textBox = new System.Windows.Forms.TextBox();
            this.Qty_On_Hand_textBox = new System.Windows.Forms.TextBox();
            this.Commision_Percentage = new System.Windows.Forms.TextBox();
            this.Reload_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Product_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_Exit_button
            // 
            this.Product_Exit_button.Location = new System.Drawing.Point(936, 445);
            this.Product_Exit_button.Name = "Product_Exit_button";
            this.Product_Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Product_Exit_button.TabIndex = 0;
            this.Product_Exit_button.Text = "Exit";
            this.Product_Exit_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Product_Exit_button.UseVisualStyleBackColor = true;
            this.Product_Exit_button.Click += new System.EventHandler(this.Product_Exit_button_Click);
            // 
            // Product_dataGridView
            // 
            this.Product_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_dataGridView.Location = new System.Drawing.Point(12, 41);
            this.Product_dataGridView.MultiSelect = false;
            this.Product_dataGridView.Name = "Product_dataGridView";
            this.Product_dataGridView.ReadOnly = true;
            this.Product_dataGridView.Size = new System.Drawing.Size(999, 150);
            this.Product_dataGridView.TabIndex = 1;
            this.Product_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Product_dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Product:";
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(838, 444);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 3;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manufacturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Style";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Purchase_Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sale_Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Qty_On_Hand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Commission_Percentage";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(221, 247);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(182, 20);
            this.Name_TextBox.TabIndex = 11;
            // 
            // Manufacture_textBox
            // 
            this.Manufacture_textBox.Location = new System.Drawing.Point(221, 275);
            this.Manufacture_textBox.Name = "Manufacture_textBox";
            this.Manufacture_textBox.Size = new System.Drawing.Size(182, 20);
            this.Manufacture_textBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Id";
            // 
            // Id_textBox
            // 
            this.Id_textBox.Location = new System.Drawing.Point(221, 213);
            this.Id_textBox.Name = "Id_textBox";
            this.Id_textBox.ReadOnly = true;
            this.Id_textBox.Size = new System.Drawing.Size(100, 20);
            this.Id_textBox.TabIndex = 14;
            // 
            // Style_textBox
            // 
            this.Style_textBox.Location = new System.Drawing.Point(221, 308);
            this.Style_textBox.Name = "Style_textBox";
            this.Style_textBox.Size = new System.Drawing.Size(182, 20);
            this.Style_textBox.TabIndex = 15;
            // 
            // Purchase_Price_textBox
            // 
            this.Purchase_Price_textBox.Location = new System.Drawing.Point(221, 338);
            this.Purchase_Price_textBox.Name = "Purchase_Price_textBox";
            this.Purchase_Price_textBox.Size = new System.Drawing.Size(182, 20);
            this.Purchase_Price_textBox.TabIndex = 16;
            // 
            // Sale_Price_textBox
            // 
            this.Sale_Price_textBox.Location = new System.Drawing.Point(221, 366);
            this.Sale_Price_textBox.Name = "Sale_Price_textBox";
            this.Sale_Price_textBox.Size = new System.Drawing.Size(182, 20);
            this.Sale_Price_textBox.TabIndex = 17;
            // 
            // Qty_On_Hand_textBox
            // 
            this.Qty_On_Hand_textBox.Location = new System.Drawing.Point(221, 399);
            this.Qty_On_Hand_textBox.Name = "Qty_On_Hand_textBox";
            this.Qty_On_Hand_textBox.Size = new System.Drawing.Size(182, 20);
            this.Qty_On_Hand_textBox.TabIndex = 18;
            // 
            // Commision_Percentage
            // 
            this.Commision_Percentage.Location = new System.Drawing.Point(221, 429);
            this.Commision_Percentage.Name = "Commision_Percentage";
            this.Commision_Percentage.Size = new System.Drawing.Size(182, 20);
            this.Commision_Percentage.TabIndex = 19;
            // 
            // Reload_button
            // 
            this.Reload_button.Location = new System.Drawing.Point(746, 444);
            this.Reload_button.Name = "Reload_button";
            this.Reload_button.Size = new System.Drawing.Size(75, 23);
            this.Reload_button.TabIndex = 20;
            this.Reload_button.Text = "Reload";
            this.Reload_button.UseVisualStyleBackColor = true;
            this.Reload_button.Click += new System.EventHandler(this.Reload_button_Click);
            // 
            // Products_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 493);
            this.Controls.Add(this.Reload_button);
            this.Controls.Add(this.Commision_Percentage);
            this.Controls.Add(this.Qty_On_Hand_textBox);
            this.Controls.Add(this.Sale_Price_textBox);
            this.Controls.Add(this.Purchase_Price_textBox);
            this.Controls.Add(this.Style_textBox);
            this.Controls.Add(this.Id_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Manufacture_textBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Product_dataGridView);
            this.Controls.Add(this.Product_Exit_button);
            this.Name = "Products_Form";
            this.Text = "List of Products";
            ((System.ComponentModel.ISupportInitialize)(this.Product_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Product_Exit_button;        
        private System.Windows.Forms.DataGridView Product_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox Manufacture_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Id_textBox;
        private System.Windows.Forms.TextBox Style_textBox;
        private System.Windows.Forms.TextBox Purchase_Price_textBox;
        private System.Windows.Forms.TextBox Sale_Price_textBox;
        private System.Windows.Forms.TextBox Qty_On_Hand_textBox;
        private System.Windows.Forms.TextBox Commision_Percentage;
        private System.Windows.Forms.Button Reload_button;
    }
}