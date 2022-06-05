using System;
using System.Windows.Forms;

namespace BeSpoked_Bikes
{
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
            LoadCustomers();
        }


        private void LoadCustomers()
        {

            using (var db = new BeSpokedModelContext())
            {
                var Customers = db.GetCustomers();
                Customer_List_dataGridView.DataSource = Customers;

                
                Customer_List_dataGridView.AutoResizeColumn(0);
                Customer_List_dataGridView.AutoResizeColumn(1);
                Customer_List_dataGridView.AutoResizeColumn(2);
                Customer_List_dataGridView.AutoResizeColumn(3);
                Customer_List_dataGridView.AutoResizeColumn(4);
                Customer_List_dataGridView.AutoResizeColumn(5);                
            }

        }

        private void Customer_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
