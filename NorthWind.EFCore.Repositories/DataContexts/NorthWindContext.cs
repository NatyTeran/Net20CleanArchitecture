
//Add-Migration InitialCreate -p NorthWind.EFCore.Repositories -s NorthWind.EFCore.Repositories -C NorthWindContext
// Update-Database -p NorthWind.EFCore.Repositories -s NorthWind.EFCore.Repositories -context NorthWindContext
namespace NorthWind.EFCore.Repositories.DataContexts
{
    // Se utiliza únicamente en tiempo de diseño: Cuando se ejecuten las migraciones
    internal class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NorthWindNET20");
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
