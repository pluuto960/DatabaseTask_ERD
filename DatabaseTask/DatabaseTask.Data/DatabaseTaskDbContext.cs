using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<ItemGroup> ItemGroups { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ShipnoteLine> ShipnoteLines { get; set; }
        public DbSet<Shipnote> Shipnotes { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fix cascade delete conflicts
            modelBuilder.Entity<Shipnote>()
                .HasOne(s => s.Supplier)
                .WithMany(sup => sup.Shipnotes)
                .HasForeignKey(s => s.SupplierID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Shipnote>()
                .HasOne(s => s.Staff)
                .WithMany(st => st.Shipnotes)
                .HasForeignKey(s => s.StaffID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Item>()
                .HasOne(i => i.Supplier)
                .WithMany(s => s.Items)
                .HasForeignKey(i => i.SupplierID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
