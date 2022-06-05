
namespace BeSpoked_Bikes
{
    public class QuarterlySalesmanReport
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public long Total_Items_Sold { get; set; }

        public string Product_Name { get; set; }
        public long ProductId { get; set; }
        public long SalePersonId { get; set; }

        public double SalePaerson_Commission { get; set; }

    }
}
