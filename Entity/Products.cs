using System.ComponentModel.DataAnnotations;

namespace BeSpoked_Bikes
{
    public class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]    
        public Products ()
        {   
        }
        public long Id { get; set; }

        [Required]
        [StringLength(56)]
        public string Name { get; set; }

        [Required]
        [StringLength(56)]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(56)]
        public string Style { get; set; }

        [Required]
        public double Purchase_Price { get; set; }
        [Required]
        public double Sale_Price { get; set; }

        public int? Qty_On_Hand { get; set; }
        public double? Commission_Percentage { get; set; }

    }
}
