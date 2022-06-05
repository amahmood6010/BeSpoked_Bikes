using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeSpoked_Bikes
{

    public partial class NewSaleForm : Form
    {
        public NewSaleForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadProducts();
            LoadSalesPerson();
        }

        private void LoadValues ()
        {
            LoadCustomers();
            LoadProducts();
            LoadSalesPerson();
        }

        private void ClearForm ()
        {

            SalePersons_ComboBox.SelectedItem = null;
            Customers_ComboBox.SelectedItem = null;
            Products_ComboBox.SelectedItem = null;
            Item_Count_Sale.Text = "";
            Display_Available.Text = "";
            SalePersons_ComboBox.Items.Clear();
            Customers_ComboBox.Items.Clear();
            Products_ComboBox.Items.Clear();
        }
        private void LoadSalesPerson()
        {

            using (var db = new BeSpokedModelContext())
            {
                List<Salespersons> saleparsonsList = db.GetSalesPersons();
                foreach (var sl in saleparsonsList)
                {

                    String SaleParson_Name = sl.First_Name.TrimEnd() + ", " + sl.Last_Name.TrimEnd();
                    SalePersons_ComboBox.Items.Add(new ComboboxValue(sl.Id, SaleParson_Name));

                }
            }
        }

        private void LoadCustomers()
        {

            using (var db = new BeSpokedModelContext())
            {
                List<Customers> CustomersList = db.GetCustomers();
                foreach (var cl in CustomersList)
                {
                    String Customer_Name = cl.First_Name.TrimEnd() + ", " + cl.Last_Name.TrimEnd();
                    Customers_ComboBox.Items.Add(new ComboboxValue(cl.Id, Customer_Name));
                }
            }
        }

        private void LoadProducts()
        {

            using (var db = new BeSpokedModelContext())
            {
                List<Products> ProductList = db.GetProducts();
                foreach (var pl in ProductList)
                {
                    String Product_Name = pl.Name.TrimEnd();
                    Products_ComboBox.Items.Add(new ComboboxValue(pl.Id, Product_Name,pl.Qty_On_Hand));
                }
            }
        }
        private double GetDiscountedSalePrice (BeSpokedModelContext db, Products ProductItem)
        {
            double discountedSalePrice = ProductItem.Sale_Price;

            var discount = db.GetRecentDiscountByProductId(ProductItem.Id);

            if (discount !=null)
            {
                if (discount.Discount_Percentage != 0)
                {
                    discountedSalePrice = ProductItem.Sale_Price - (ProductItem.Sale_Price * (discount.Discount_Percentage / 100));
                }
            }

            return discountedSalePrice;

        }
        private void New_Sale_Click(object sender, EventArgs e)
        {
            
            ComboboxValue SalePersonValue = (ComboboxValue)SalePersons_ComboBox.SelectedItem;
            ComboboxValue CustomerValue = (ComboboxValue)Customers_ComboBox.SelectedItem;
            ComboboxValue ProductValue = (ComboboxValue)Products_ComboBox.SelectedItem;

            
            if (SalePersonValue != null && CustomerValue != null && ProductValue != null && !String.IsNullOrEmpty(Item_Count_Sale.Text.ToString()))
            {

                try
                {
                    int? Qty_On_Hand = ProductValue.Qty_On_Hand;

                    if (Qty_On_Hand >= Convert.ToInt32(Item_Count_Sale.Text.ToString()))
                    {

                        using (var db = new BeSpokedModelContext())
                        {
                            Sales newSaleObj = new Sales();
                            newSaleObj.ProductId = ProductValue.HiddenId;
                            newSaleObj.CustomerId = CustomerValue.HiddenId;
                            newSaleObj.SalespersonId = SalePersonValue.HiddenId; 
                            newSaleObj.Sales_Date = DateTime.UtcNow;
                            newSaleObj.Qty_Sold = Convert.ToInt32(Item_Count_Sale.Text.ToString());

                            db.Sales.Add(newSaleObj);

                            var ProductItem = db.GetProductsById(newSaleObj.ProductId);
                            newSaleObj.Sale_Price =  GetDiscountedSalePrice(db, ProductItem) * newSaleObj.Qty_Sold;                            
                            newSaleObj.Commission = newSaleObj.Sale_Price * (ProductItem.Commission_Percentage / 100);
                            ProductItem.Qty_On_Hand = Qty_On_Hand - Convert.ToInt32(Item_Count_Sale.Text.ToString());

                            db.SaveChanges();
                            ClearForm();
                            LoadValues();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can't sale more items than inventory");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString());
                }
            }
        }

      
        private void Products_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxValue ProductValue = (ComboboxValue)Products_ComboBox.SelectedItem;
            if (ProductValue !=null)
            {
                Display_Available.Text = ProductValue.Qty_On_Hand.ToString();
            }
        }

        private void Customer_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reload_Sales_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadValues();
        }
    }
}
