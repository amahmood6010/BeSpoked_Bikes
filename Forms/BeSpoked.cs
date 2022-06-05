using System;
using System.Windows.Forms;

namespace BeSpoked_Bikes
{
    public partial class BeSpoked : Form
    {
        public BeSpoked()
        {
            InitializeComponent();
            
        }

        private void Products_button_Click(object sender, EventArgs e)
        {
            Products_Form Prod_fm = new Products_Form();
            
            Prod_fm.ShowDialog();
        }

       
        private void SalesPersons_Button_Click(object sender, EventArgs e)
        {
            SalesPerson_Form SalesPersons_fm = new SalesPerson_Form();
            SalesPersons_fm.ShowDialog();
        }

        private void Customers_button_Click(object sender, EventArgs e)
        {
            Customer_Form Customers_fm = new Customer_Form();
            Customers_fm.ShowDialog();
        }

        private void Sale_button_Click(object sender, EventArgs e)
        {
            Sales_Form Sales_fm = new Sales_Form();
            Sales_fm.ShowDialog();
        }

        private void Qrt_Sale_Report_Button_Click(object sender, EventArgs e)
        {

            Qrt_Sale_Report_Form Qrt_Report_fm = new Qrt_Sale_Report_Form();
            Qrt_Report_fm.ShowDialog();
        }

        private void New_Sale_Button_Click(object sender, EventArgs e)
        {
            NewSaleForm SalesPersons_fm = new NewSaleForm();
            SalesPersons_fm.ShowDialog();
        }
    }
}
