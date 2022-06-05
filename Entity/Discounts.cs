using System;
using System.ComponentModel.DataAnnotations;

namespace BeSpoked_Bikes
{
    public class Discounts
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Discounts()
        {
        }
        public long Id { get; set; }

        [Required]
        public long ProductId { get; set; }

        [Required]
        public DateTime Begin_Date { get; set; }
        [Required]
        public DateTime End_Date { get; set; }

        [Required]
        public double Discount_Percentage { get; set; }
    }
}
