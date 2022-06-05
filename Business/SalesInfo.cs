using System;

namespace BeSpoked_Bikes
{
    internal class SalesInfo
    {
        public long Id { get; set; }
                
        public string Product { get; set; }
        
        public string Salesperson { get; set; }
        
        public string Customer { get; set; }

        
        public DateTime Sales_Date { get; set; }

        public double? Commission { get; set; }


        public double Sale_Price { get; set; }
    }
}
