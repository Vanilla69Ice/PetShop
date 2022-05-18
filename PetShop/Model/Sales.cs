namespace PetShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sales
    {
        public int Id { get; set; }

        public int QuantityProduct { get; set; }

        public DateTime DateOfSale { get; set; }

        public int AnimalId { get; set; }

        public int CustomerId { get; set; }

        public int StaffId { get; set; }

        public virtual Animals Animals { get; set; }

        public virtual RegularCustomers RegularCustomers { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
