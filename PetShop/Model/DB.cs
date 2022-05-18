using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PetShop.Model
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Animals> Animals { get; set; }
        public virtual DbSet<RegularCustomers> RegularCustomers { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Supplies> Supplies { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animals>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Animals>()
                .Property(e => e.PurchasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Animals>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Animals)
                .HasForeignKey(e => e.AnimalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Animals>()
                .HasMany(e => e.Supplies)
                .WithRequired(e => e.Animals)
                .HasForeignKey(e => e.AnimalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegularCustomers>()
                .Property(e => e.NumberPhone)
                .IsFixedLength();

            modelBuilder.Entity<RegularCustomers>()
                .Property(e => e.PurchaseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RegularCustomers>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.RegularCustomers)
                .HasForeignKey(e => e.AnimalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Staff>()
                .Property(e => e.NumberPhone)
                .IsFixedLength();

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suppliers>()
                .HasMany(e => e.Supplies)
                .WithRequired(e => e.Suppliers)
                .WillCascadeOnDelete(false);
        }
    }
}
