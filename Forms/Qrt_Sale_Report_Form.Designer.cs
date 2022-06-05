namespace BeSpoked_Bikes
{
    partial class Qrt_Sale_Report_Form
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
            this.Quarterly_Sale_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Customer_Exit = new System.Windows.Forms.Button();
            this.Quarter_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Year_comboBox = new System.Windows.Forms.ComboBox();
            this.Generate_Report_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Quarterly_Sale_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Quarterly_Sale_dataGridView
            // 
            this.Quarterly_Sale_dataGridView.AllowUserToDeleteRows = false;
            this.Quarterly_Sale_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Quarterly_Sale_dataGridView.Location = new System.Drawing.Point(23, 50);
            this.Quarterly_Sale_dataGridView.Name = "Quarterly_Sale_dataGridView";
            this.Quarterly_Sale_dataGridView.ReadOnly = true;
            this.Quarterly_Sale_dataGridView.Size = new System.Drawing.Size(870, 360);
            this.Quarterly_Sale_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quarterly Sale Report";
            // 
            // Customer_Exit
            // 
            this.Customer_Exit.Location = new System.Drawing.Point(818, 443);
            this.Customer_Exit.Name = "Customer_Exit";
            this.Customer_Exit.Size = new System.Drawing.Size(75, 23);
            this.Customer_Exit.TabIndex = 3;
            this.Customer_Exit.Text = "Exit";
            this.Customer_Exit.UseVisualStyleBackColor = true;
            this.Customer_Exit.Click += new System.EventHandler(this.Customer_Exit_Click);
            // 
            // Quarter_comboBox
            // 
            this.Quarter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Quarter_comboBox.FormattingEnabled = true;
            this.Quarter_comboBox.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth"});
            this.Quarter_comboBox.Location = new System.Drawing.Point(278, 14);
            this.Quarter_comboBox.Name = "Quarter_comboBox";
            this.Quarter_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Quarter_comboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quarters:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Years:";
            // 
            // Year_comboBox
            // 
            this.Year_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Year_comboBox.FormattingEnabled = true;
            this.Year_comboBox.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.Year_comboBox.Location = new System.Drawing.Point(479, 14);
            this.Year_comboBox.Name = "Year_comboBox";
            this.Year_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Year_comboBox.TabIndex = 7;
            // 
            // Generate_Report_button
            // 
            this.Generate_Report_button.Location = new System.Drawing.Point(722, 443);
            this.Generate_Report_button.Name = "Generate_Report_button";
            this.Generate_Report_button.Size = new System.Drawing.Size(75, 23);
            this.Generate_Report_button.TabIndex = 8;
            this.Generate_Report_button.Text = "Report";
            this.Generate_Report_button.UseVisualStyleBackColor = true;
            this.Generate_Report_button.Click += new System.EventHandler(this.Generate_Report_button_Click);
            // 
            // Qrt_Sale_Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 488);
            this.Controls.Add(this.Generate_Report_button);
            this.Controls.Add(this.Year_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Quarter_comboBox);
            this.Controls.Add(this.Customer_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quarterly_Sale_dataGridView);
            this.Name = "Qrt_Sale_Report_Form";
            this.Text = "Quarterly Salesperson Commission Report";
            ((System.ComponentModel.ISupportInitialize)(this.Quarterly_Sale_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Quarterly_Sale_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Customer_Exit;
        private System.Windows.Forms.ComboBox Quarter_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Year_comboBox;
        private System.Windows.Forms.Button Generate_Report_button;
    }
}