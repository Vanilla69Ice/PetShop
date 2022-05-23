namespace PetShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RegularCustomers
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string FullName { get; set; }

        [Required]
        [StringLength(10)]
        public string NumberPhone { get; set; }

        [Column(TypeName = "money")]
        public decimal PurchaseAmount { get; set; }
    }
}
