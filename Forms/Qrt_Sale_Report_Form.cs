using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeSpoked_Bikes
{
    public partial class Qrt_Sale_Report_Form : Form
    {
        public Qrt_Sale_Report_Form()
        {
            InitializeComponent();
            
        }


        private void LoadQuarterlyReports(DateTime startDt, DateTime endDt)
        {
            try
            {
                using (var db = new BeSpokedModelContext())
                {
                    var SalePerson = db.GetSalesPersons();
                    List<QuarterlySalesmanReport> qrtReportList = new List<QuarterlySalesmanReport>();

                    foreach (var eachPerson in SalePerson)
                    {

                        var productSoldByPerson = db.GetSalesBySalesPersonIdAndDateRange(eachPerson.Id, startDt, endDt);
                        foreach (var aSale in productSoldByPerson)
                        {
                            
                            var product = db.GetProductsById(aSale.ProductId);
                            

                            QuarterlySalesmanReport Qrt_Report = new QuarterlySalesmanReport();
                            Qrt_Report.ProductId = aSale.ProductId;
                            Qrt_Report.SalePersonId = aSale.SalespersonId;
                            Qrt_Report.Product_Name = product.Name;
                            Qrt_Report.First_Name = eachPerson.First_Name;
                            Qrt_Report.Last_Name = eachPerson.Last_Name;
                            Qrt_Report.Total_Items_Sold = aSale.Qty_Sold;
                            Qrt_Report.SalePaerson_Commission = (double)aSale.Commission;

                            qrtReportList.Add(Qrt_Report);

                        }

                    }

                    Quarterly_Sale_dataGridView.DataSource = qrtReportList.Select(myRow => new { myRow.First_Name, myRow.Last_Name, myRow.Product_Name, myRow.Total_Items_Sold, myRow.SalePaerson_Commission }).ToList();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
       

        private void Customer_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Generate_Report_button_Click(object sender, EventArgs e)
        {

            if (Quarter_comboBox.SelectedItem != null && Year_comboBox.SelectedItem != null)
            {
                

                string yearPicked = Year_comboBox.SelectedItem.ToString();
                string QuarterPicked = Quarter_comboBox.SelectedItem.ToString();

                if (QuarterPicked.CompareTo("First") == 0)
                {                    
                    var stratdt = DateTime.ParseExact(yearPicked + "-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    var Enddt = DateTime.ParseExact(yearPicked + "-03-31", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    LoadQuarterlyReports(stratdt, Enddt);

                }
                if (QuarterPicked.CompareTo("Second") == 0)
                {
                    var stratdt = DateTime.ParseExact(yearPicked + "-04-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    var Enddt = DateTime.ParseExact(yearPicked + "-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    LoadQuarterlyReports(stratdt, Enddt);
                }
                if (QuarterPicked.CompareTo("Third") == 0)
                {
                    var stratdt = DateTime.ParseExact(yearPicked + "-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    var Enddt = DateTime.ParseExact(yearPicked + "-09-30", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    LoadQuarterlyReports(stratdt, Enddt);
                }
                if (QuarterPicked.CompareTo("Fourth") == 0)
                {
                    var stratdt = DateTime.ParseExact(yearPicked + "-10-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    var Enddt = DateTime.ParseExact(yearPicked + "-12-31", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    LoadQuarterlyReports(stratdt, Enddt);
                }
                
            }    
            
        }
    }
}
