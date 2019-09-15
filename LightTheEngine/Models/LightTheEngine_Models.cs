namespace LightTheEngine.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LightTheEngine_Models : DbContext
    {
        public LightTheEngine_Models()
            : base("name=LightTheEngine_Models")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);
        }
    }
}
