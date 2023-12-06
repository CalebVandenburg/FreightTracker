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
        public async Task<TruckModel> GetTruckByID(int ID)
        {
            var truck = await databaseContext.TruckModels.Where(x=>x.ID == ID).FirstOrDefaultAsync();
            databaseContext.ChangeTracker.Clear();
            return truck;
        }
        public async Task<TruckModel> UpdateTruck(TruckModel editedTruck)
        {
            var truck = await databaseContext.TruckModels.Where(x => x.ID == editedTruck.ID).FirstOrDefaultAsync();
            truck.Name = editedTruck.Name;
            truck.Description = editedTruck.Description;
            await databaseContext.SaveChangesAsync();
            databaseContext.ChangeTracker.Clear();
            return truck;
        }
    }
}
