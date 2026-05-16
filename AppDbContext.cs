using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalLegaspi
{
    public class Rental
    {
        public int Id { get; set; }          // EF Core automatically makes 'Id' the Primary Key
        public string Customer { get; set; } = string.Empty;
        public string Car { get; set; }
        public int Days { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public string Action { get; set; }
    }
    public class Car
    {
        public int Id { get; set; }          // EF Core automatically makes 'Id' the Primary Key
        public string CarName { get; set; } = string.Empty;
        public string Type { get; set; }
        public int PlateNum { get; set; }
        public string Status { get; set; }
        public decimal RatePerDay { get; set; }
    }
    public class Reports
    {
        public int Id { get; set; }          // EF Core automatically makes 'Id' the Primary Key
        public string Customer { get; set; } = string.Empty;
        public string Car { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
    }
    public class User
    {
        public int Id { get; set; }          // EF Core automatically makes 'Id' the Primary Key
        public string Customer { get; set; } = string.Empty;
        public string Password { get; set; } 
        public string Role { get; set; } = string.Empty;
        public decimal Action { get; set; }
    }
   
    

    public class AppDbContext : DbContext
    {
        // This represents the "Products" table in SQL Server
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }

        // Configure the connection string pointing to your local SQL Server Express
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=CarRentalDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
