namespace BeSpoked_Bikes
{
    partial class Customer_Form
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
            this.Customer_List_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Customer_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_List_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_List_dataGridView
            // 
            this.Customer_List_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer_List_dataGridView.Location = new System.Drawing.Point(24, 35);
            this.Customer_List_dataGridView.Name = "Customer_List_dataGridView";
            this.Customer_List_dataGridView.ReadOnly = true;
            this.Customer_List_dataGridView.Size = new System.Drawing.Size(705, 150);
            this.Customer_List_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers List:";
            // 
            // Customer_Exit
            // 
            this.Customer_Exit.Location = new System.Drawing.Point(654, 212);
            this.Customer_Exit.Name = "Customer_Exit";
            this.Customer_Exit.Size = new System.Drawing.Size(75, 23);
            this.Customer_Exit.TabIndex = 2;
            this.Customer_Exit.Text = "Exit";
            this.Customer_Exit.UseVisualStyleBackColor = true;
            this.Customer_Exit.Click += new System.EventHandler(this.Customer_Exit_Click);
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 262);
            this.Controls.Add(this.Customer_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Customer_List_dataGridView);
            this.Name = "Customer_Form";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.Customer_List_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Customer_List_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Customer_Exit;
    }
}