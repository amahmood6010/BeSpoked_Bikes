using System;
using System.ComponentModel.DataAnnotations;


namespace BeSpoked_Bikes
{
    public class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
        }
        public long Id { get; set; }

        [Required]
        [StringLength(56)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(56)]
        public string Last_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(56)]
        public string Phone { get; set; }

        [Required]        
        public DateTime Start_Date { get; set; }

    }
}
