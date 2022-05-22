namespace PetShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplies
    {
        public int Id { get; set; }

        public int AnimalId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateSuplies { get; set; }

        public int SuppliersId { get; set; }

        public virtual Animals Animals { get; set; }

        public virtual Suppliers Suppliers { get; set; }
    }
}
