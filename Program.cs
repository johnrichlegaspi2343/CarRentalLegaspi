using System;
using System.Linq; // Required for database sorting/searching
namespace CarRentalLegaspi
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            // 1. AUTOMATIC CREATION: Run this once before the app UI loads
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }
            Application.Run(new LoginForm());
        }
    }
}