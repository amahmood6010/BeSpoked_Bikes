namespace BeSpoked_Bikes
{
    partial class SalesPerson_Form
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
            this.SalePersons_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesPerson_Exit = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Manager_TextBox = new System.Windows.Forms.TextBox();
            this.Phone_TextBox = new System.Windows.Forms.TextBox();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Last_Name_TextBox = new System.Windows.Forms.TextBox();
            this.First_Name_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reload_button = new System.Windows.Forms.Button();
            this.Terminate_Date_textBox = new System.Windows.Forms.TextBox();
            this.Start_Date_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalePersons_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalePersons_dataGridView
            // 
            this.SalePersons_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalePersons_dataGridView.Location = new System.Drawing.Point(15, 48);
            this.SalePersons_dataGridView.Name = "SalePersons_dataGridView";
            this.SalePersons_dataGridView.Size = new System.Drawing.Size(896, 150);
            this.SalePersons_dataGridView.TabIndex = 0;
            this.SalePersons_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalePersons_dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Persons:";
            // 
            // SalesPerson_Exit
            // 
            this.SalesPerson_Exit.Location = new System.Drawing.Point(846, 487);
            this.SalesPerson_Exit.Name = "SalesPerson_Exit";
            this.SalesPerson_Exit.Size = new System.Drawing.Size(75, 23);
            this.SalesPerson_Exit.TabIndex = 2;
            this.SalesPerson_Exit.Text = "Exit";
            this.SalesPerson_Exit.UseVisualStyleBackColor = true;
            this.SalesPerson_Exit.Click += new System.EventHandler(this.SalesPerson_Exit_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(755, 487);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 3;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Manager_TextBox
            // 
            this.Manager_TextBox.Location = new System.Drawing.Point(231, 443);
            this.Manager_TextBox.Name = "Manager_TextBox";
            this.Manager_TextBox.Size = new System.Drawing.Size(150, 20);
            this.Manager_TextBox.TabIndex = 35;
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Location = new System.Drawing.Point(231, 352);
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Phone_TextBox.TabIndex = 32;
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Location = new System.Drawing.Point(231, 322);
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(324, 20);
            this.Address_TextBox.TabIndex = 31;
            // 
            // Id_textBox
            // 
            this.Id_textBox.Location = new System.Drawing.Point(231, 227);
            this.Id_textBox.Name = "Id_textBox";
            this.Id_textBox.ReadOnly = true;
            this.Id_textBox.Size = new System.Drawing.Size(100, 20);
            this.Id_textBox.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Id:";
            // 
            // Last_Name_TextBox
            // 
            this.Last_Name_TextBox.Location = new System.Drawing.Point(231, 289);
            this.Last_Name_TextBox.Name = "Last_Name_TextBox";
            this.Last_Name_TextBox.Size = new System.Drawing.Size(150, 20);
            this.Last_Name_TextBox.TabIndex = 28;
            // 
            // First_Name_TextBox
            // 
            this.First_Name_TextBox.Location = new System.Drawing.Point(231, 261);
            this.First_Name_TextBox.Name = "First_Name_TextBox";
            this.First_Name_TextBox.Size = new System.Drawing.Size(150, 20);
            this.First_Name_TextBox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Manager:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Termination Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name:";
            // 
            // Reload_button
            // 
            this.Reload_button.Location = new System.Drawing.Point(658, 487);
            this.Reload_button.Name = "Reload_button";
            this.Reload_button.Size = new System.Drawing.Size(75, 23);
            this.Reload_button.TabIndex = 36;
            this.Reload_button.Text = "Reload";
            this.Reload_button.UseVisualStyleBackColor = true;
            this.Reload_button.Click += new System.EventHandler(this.Reload_button_Click);
            // 
            // Terminate_Date_textBox
            // 
            this.Terminate_Date_textBox.Location = new System.Drawing.Point(231, 410);
            this.Terminate_Date_textBox.Name = "Terminate_Date_textBox";
            this.Terminate_Date_textBox.Size = new System.Drawing.Size(150, 20);
            this.Terminate_Date_textBox.TabIndex = 38;
            // 
            // Start_Date_TextBox
            // 
            this.Start_Date_TextBox.Location = new System.Drawing.Point(231, 380);
            this.Start_Date_TextBox.Name = "Start_Date_TextBox";
            this.Start_Date_TextBox.Size = new System.Drawing.Size(150, 20);
            this.Start_Date_TextBox.TabIndex = 39;
            // 
            // SalesPerson_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 543);
            this.Controls.Add(this.Start_Date_TextBox);
            this.Controls.Add(this.Terminate_Date_textBox);
            this.Controls.Add(this.Reload_button);
            this.Controls.Add(this.Manager_TextBox);
            this.Controls.Add(this.Phone_TextBox);
            this.Controls.Add(this.Address_TextBox);
            this.Controls.Add(this.Id_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Last_Name_TextBox);
            this.Controls.Add(this.First_Name_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.SalesPerson_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalePersons_dataGridView);
            this.Name = "SalesPerson_Form";
            this.Text = "Sale Persons";
            ((System.ComponentModel.ISupportInitialize)(this.SalePersons_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalePersons_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalesPerson_Exit;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.TextBox Manager_TextBox;
        private System.Windows.Forms.TextBox Phone_TextBox;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.TextBox Id_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Last_Name_TextBox;
        private System.Windows.Forms.TextBox First_Name_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reload_button;
        private System.Windows.Forms.TextBox Terminate_Date_textBox;
        private System.Windows.Forms.TextBox Start_Date_TextBox;
    }
}