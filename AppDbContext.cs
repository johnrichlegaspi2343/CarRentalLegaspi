using Microsoft.EntityFrameworkCore;

namespace CarRentalLegaspi
{
    public class Rental
    {
        public int Id { get; set; }
        public string Customer { get; set; } = string.Empty;
        public string Car { get; set; } = string.Empty;
        public int Days { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
        public DateTime RentalDate { get; set; } = DateTime.Today;
    }

    public class Car
    {
        public int Id { get; set; }
        public string CarName { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string PlateNum { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public decimal RatePerDay { get; set; }
    }

    public class Reports
    {
        public int Id { get; set; }
        public string Customer { get; set; } = string.Empty;
        public string Car { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public string Status { get; set; } = string.Empty;
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public decimal Action { get; set; }  // kept to match existing DB column
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder o)
            => o.UseSqlServer(
                "Server=localhost;Database=CarRentalDB;" +
                "Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map C# "Username" → existing DB column "Customer"
            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .HasColumnName("Customer");

            // Ensure PlateNum stored as nvarchar(50)
            modelBuilder.Entity<Car>()
                .Property(c => c.PlateNum)
                .HasColumnName("PlateNum")
                .HasColumnType("nvarchar(50)");

            modelBuilder.Entity<Rental>()
               .Property(r => r.RentalDate)
               .HasDefaultValueSql("GETDATE()");
        }
    }
}