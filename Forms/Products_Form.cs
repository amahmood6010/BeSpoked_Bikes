using System;
using System.Windows.Forms;

namespace BeSpoked_Bikes
{

    public partial class Products_Form : Form
    {
        public Products_Form()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void ClearFields()
        {
            
            Id_textBox.Text = "";
            Name_TextBox.Text = "";
            Manufacture_textBox.Text = "";
            Style_textBox.Text = "";
            Purchase_Price_textBox.Text = "";
            Sale_Price_textBox.Text = "";
            Qty_On_Hand_textBox.Text = "";
            Commision_Percentage.Text = "";
        }

        private void LoadProducts()
        {

            using (var db = new BeSpokedModelContext())
            {
                var products = db.GetProducts();
                Product_dataGridView.DataSource = products;

                Product_dataGridView.AutoResizeColumn(0);
                Product_dataGridView.AutoResizeColumn(1);
                Product_dataGridView.AutoResizeColumn(2);
                Product_dataGridView.AutoResizeColumn(3);
                Product_dataGridView.AutoResizeColumn(4);
                Product_dataGridView.AutoResizeColumn(5);
                Product_dataGridView.AutoResizeColumn(6);
                Product_dataGridView.AutoResizeColumn(7);
                
            }

        }

        private void Product_Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
               
        private void Update_button_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty (Id_textBox.Text))
            {
                MessageBox.Show("Please select product to update");
            }
            
            try
            {
                    using (var db = new BeSpokedModelContext())
                    {

                        long Id = Convert.ToInt64(Id_textBox.Text);
                        string Name = Name_TextBox.Text;
                        string Manufacturer = Manufacture_textBox.Text;
                        string Style = Style_textBox.Text;
                        double Purchase_Price = Convert.ToDouble(Purchase_Price_textBox.Text);
                        double Sale_Price = Convert.ToDouble(Sale_Price_textBox.Text);
                        int? Qty_On_Hand = Convert.ToInt32(Qty_On_Hand_textBox.Text);
                        double? Commission_Percentage = Convert.ToDouble(Commision_Percentage.Text);

                        var ProductItem = db.GetProductsById(Convert.ToInt64(Id));
                        ProductItem.Name = Name.TrimEnd();
                        ProductItem.Manufacturer = Manufacturer.TrimEnd();
                        ProductItem.Style = Style.TrimEnd();
                        ProductItem.Purchase_Price = Purchase_Price;
                        ProductItem.Sale_Price = Sale_Price;
                        ProductItem.Qty_On_Hand = Qty_On_Hand;
                        ProductItem.Commission_Percentage = Commission_Percentage;

                        db.SaveChanges();                       
           
                    }

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void Product_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int nRowCount = Product_dataGridView.RowCount;
            if (nRowCount > 0)
            {
                Id_textBox.Text = Product_dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString().TrimEnd();
                Name_TextBox.Text = Product_dataGridView.Rows[e.RowIndex].Cells["Name"].Value as string;
                Name_TextBox.Text = Name_TextBox.Text.TrimEnd();
                Manufacture_textBox.Text = Product_dataGridView.Rows[e.RowIndex].Cells["Manufacturer"].Value as string;
                Manufacture_textBox.Text = Manufacture_textBox.Text.TrimEnd();
                Style_textBox.Text= Product_dataGridView.Rows[e.RowIndex].Cells["Style"].Value as string;
                Style_textBox.Text = Style_textBox.Text.TrimEnd();
                Purchase_Price_textBox.Text = Product_dataGridView.Rows[e.RowIndex].Cells["Purchase_Price"].Value.ToString();
                Sale_Price_textBox.Text = Product_dataGridView.Rows[e.RowIndex].Cells["Sale_Price"].Value.ToString();
                Qty_On_Hand_textBox.Text = Product_dataGridView.Rows[e.RowIndex].Cells["Qty_On_Hand"].Value.ToString();
                Commision_Percentage.Text = Product_dataGridView.Rows[e.RowIndex].Cells["Commission_Percentage"].Value.ToString();
            }
        }

        private void Reload_button_Click(object sender, EventArgs e)
        {
            LoadProducts();
            ClearFields();            
        }
    }
}
