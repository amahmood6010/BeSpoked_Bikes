using System;
using System.ComponentModel.DataAnnotations;

namespace BeSpoked_Bikes
{
    public class Sales
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sales()
        {
        }
        public long Id { get; set; }

        [Required]
        public long ProductId { get; set; }
        [Required]
        public long SalespersonId { get; set; }
        [Required]
        public long CustomerId { get; set; }

        [Required]
        public DateTime Sales_Date { get; set; }

        [Required]
        public double Sale_Price { get; set; }

        [Required]
        public double? Commission { get; set; }

        [Required]
        public int Qty_Sold { get; set; }
        

    }

    
}
