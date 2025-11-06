using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<StaffPosition> StaffPositions { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SupplierDocuments> SupplierDocumentss { get; set; }
        public DbSet<Workers> Workerss { get; set; }
        public DbSet<Machines> Machiness { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    
    }
}
