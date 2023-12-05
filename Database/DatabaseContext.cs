using FreightTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FreightTracker.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TruckModel> TruckModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=E:\Portfolio\FullStack\FreightTracker\Database\FreightTrackerDatabase.db;");
        }
    }
}
