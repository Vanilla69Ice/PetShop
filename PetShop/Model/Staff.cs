namespace PetShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Sales = new HashSet<Sales>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string FullName { get; set; }

        public string Address { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        [Required]
        [StringLength(10)]
        public string NumberPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
