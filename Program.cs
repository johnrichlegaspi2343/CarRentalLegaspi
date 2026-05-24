using Microsoft.EntityFrameworkCore;

namespace CarRentalLegaspi
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
                FixSchema(db);
                SeedData(db);
            }

            Application.Run(new LoginForm());
        }

        // Applies one-time schema fixes to the existing database
        private static void FixSchema(AppDbContext db)
        {
            try
            {
                // If PlateNum is still an int in the database, alter it to nvarchar(50).
                // Using ALTER COLUMN is simpler and will convert existing int values to their string representations.
                db.Database.ExecuteSqlRaw(@"
                    IF EXISTS (
                        SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS
                        WHERE TABLE_NAME  = 'Cars'
                          AND COLUMN_NAME = 'PlateNum'
                          AND DATA_TYPE   = 'int'
                    )
                    BEGIN
                        ALTER TABLE Cars ALTER COLUMN PlateNum nvarchar(50) NOT NULL;
                    END");
            }
            catch { /* ignore if already nvarchar or cannot alter */ }
        }

        private static void SeedData(AppDbContext db)
        {
            if (!db.Users.Any())
            {
                db.Users.AddRange(
                    new User
                    {
                        Username = "admin",
                        Password = "admin123",
                        Role = "Admin"
                    },
                    new User
                    {
                        Username = "clerk01",
                        Password = "clerk123",
                        Role = "Clerk"
                    },
                    new User
                    {
                        Username = "customer",
                        Password = "1234",
                        Role = "Customer"
                    }
                );
                db.SaveChanges();
            }

            if (!db.Cars.Any())
            {
                db.Cars.AddRange(
                    new Car
                    {
                        CarName = "Toyota Vios",
                        Type = "Sedan",
                        PlateNum = "ABC-1234",
                        RatePerDay = 1500,
                        Status = "Available"
                    },
                    new Car
                    {
                        CarName = "Honda City",
                        Type = "Sedan",
                        PlateNum = "DEF-5678",
                        RatePerDay = 1800,
                        Status = "Available"
                    },
                    new Car
                    {
                        CarName = "Mitsubishi Montero",
                        Type = "SUV",
                        PlateNum = "GHI-0000",
                        RatePerDay = 3500,
                        Status = "Available"
                    },
                    new Car
                    {
                        CarName = "Toyota Fortuner",
                        Type = "SUV",
                        PlateNum = "GHI-9012",
                        RatePerDay = 4000,
                        Status = "Available"
                    },
                    new Car
                    {
                        CarName = "Toyota Hiace",
                        Type = "Van",
                        PlateNum = "JKL-3456",
                        RatePerDay = 4500,
                        Status = "Available"
                    },
                    new Car
                    {
                        CarName = "Ford Ranger",
                        Type = "Pickup Truck",
                        PlateNum = "MNO-7890",
                        RatePerDay = 3800,
                        Status = "Available"
                    }
                );
                db.SaveChanges();
            }
        }
    }
}