using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FreightTracker.Models;

namespace FreightTracker.Database
{
    public class DatabaseRepository
    {
        private DatabaseContext databaseContext { get; set; }
        public DatabaseRepository() {
            databaseContext = new DatabaseContext();
        }
        public async Task<List<TruckModel>> GetTrucks()
        {
            var trucks = await databaseContext.TruckModels.ToListAsync();
            databaseContext.ChangeTracker.Clear();
            return trucks;
        }
    }
}
