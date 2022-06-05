using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeSpoked_Bikes
{
    public partial class Sales_Form : Form
    {
        public Sales_Form()
        {
            InitializeComponent();
            LoadSales();
        }

        private void LoadSales (bool useDateRange = false)
        {

            try
            {
                using (var db = new BeSpokedModelContext())
                {
                    List<Sales> Sales = null;

                    if (useDateRange)
                    {
                        DateTime fromdate = From_dateTimePicker.Value.ToUniversalTime();
                        DateTime todate = To_dateTimePicker.Value.ToUniversalTime();
                        Sales = db.GetSalesByDateRange(fromdate, todate);

                    }
                    else
                    {
                        Sales = db.GetSales();
                    }

                    List<SalesInfo> myList = new List<SalesInfo>();

                    foreach (var aSale in Sales)
                    {
                        SalesInfo saleinfoObj = new SalesInfo();
                        var product = db.GetProductsById(aSale.ProductId);
                        var customer = db.GetCustomersById(aSale.CustomerId);
                        var salespersons = db.GetSalesPersonsById(aSale.SalespersonId);

                        saleinfoObj.Salesperson = salespersons.First_Name + ", " + salespersons.Last_Name;
                        saleinfoObj.Product = product.Name;
                        saleinfoObj.Customer = customer.First_Name + ", " + customer.Last_Name;
                        saleinfoObj.Sales_Date = aSale.Sales_Date;
                        saleinfoObj.Sale_Price = aSale.Sale_Price;
                        saleinfoObj.Commission = aSale.Commission;

                        myList.Add(saleinfoObj);
                    }

                    Sales_dataGridView.DataSource = myList.Select(myClass => new { myClass.Product, myClass.Customer, myClass.Sales_Date, myClass.Sale_Price, myClass.Salesperson, myClass.Commission }).ToList();

                    Sales_dataGridView.AutoResizeColumn(0);
                    Sales_dataGridView.AutoResizeColumn(1);
                    Sales_dataGridView.AutoResizeColumn(2);
                    Sales_dataGridView.AutoResizeColumn(3);
                    Sales_dataGridView.AutoResizeColumn(4);
                    Sales_dataGridView.AutoResizeColumn(5);                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
             
                

        private void Reload_Sales_Click(object sender, EventArgs e)
        {
            if (DateFilter.Checked == true) 
                LoadSales(true);
            else
                LoadSales();
        }
    }
}
