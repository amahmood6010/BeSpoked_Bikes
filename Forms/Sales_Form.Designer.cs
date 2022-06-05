namespace BeSpoked_Bikes
{
    partial class Sales_Form
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
            this.Sales_dataGridView = new System.Windows.Forms.DataGridView();
            this.Sales_Label = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateFilter = new System.Windows.Forms.CheckBox();
            this.Reload_Sales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sales_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Sales_dataGridView
            // 
            this.Sales_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sales_dataGridView.Location = new System.Drawing.Point(17, 54);
            this.Sales_dataGridView.Name = "Sales_dataGridView";
            this.Sales_dataGridView.Size = new System.Drawing.Size(879, 315);
            this.Sales_dataGridView.TabIndex = 0;
            // 
            // Sales_Label
            // 
            this.Sales_Label.AutoSize = true;
            this.Sales_Label.Location = new System.Drawing.Point(13, 22);
            this.Sales_Label.Name = "Sales_Label";
            this.Sales_Label.Size = new System.Drawing.Size(33, 13);
            this.Sales_Label.TabIndex = 1;
            this.Sales_Label.Text = "Sales";
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(821, 398);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 2;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From Date:";
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Location = new System.Drawing.Point(171, 15);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.From_dateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "To Date:";
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Location = new System.Drawing.Point(458, 16);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.To_dateTimePicker.TabIndex = 8;
            // 
            // DateFilter
            // 
            this.DateFilter.AutoSize = true;
            this.DateFilter.Location = new System.Drawing.Point(682, 18);
            this.DateFilter.Name = "DateFilter";
            this.DateFilter.Size = new System.Drawing.Size(71, 17);
            this.DateFilter.TabIndex = 9;
            this.DateFilter.Text = "DateFilter";
            this.DateFilter.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DateFilter.UseVisualStyleBackColor = true;
            // 
            // Reload_Sales
            // 
            this.Reload_Sales.Location = new System.Drawing.Point(719, 398);
            this.Reload_Sales.Name = "Reload_Sales";
            this.Reload_Sales.Size = new System.Drawing.Size(75, 23);
            this.Reload_Sales.TabIndex = 10;
            this.Reload_Sales.Text = "Reload";
            this.Reload_Sales.UseVisualStyleBackColor = true;
            this.Reload_Sales.Click += new System.EventHandler(this.Reload_Sales_Click);
            // 
            // Sales_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 444);
            this.Controls.Add(this.Reload_Sales);
            this.Controls.Add(this.DateFilter);
            this.Controls.Add(this.To_dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.From_dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Sales_Label);
            this.Controls.Add(this.Sales_dataGridView);
            this.Name = "Sales_Form";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.Sales_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Sales_dataGridView;
        private System.Windows.Forms.Label Sales_Label;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.CheckBox DateFilter;
        private System.Windows.Forms.Button Reload_Sales;
    }
}