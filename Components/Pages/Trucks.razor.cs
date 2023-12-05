using FreightTracker.Database;
using FreightTracker.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace FreightTracker.Components.Pages
{
    public partial class Trucks : ComponentBase
    {
        [Inject]
        private DatabaseRepository DatabaseRepository { get; set; }
        [Parameter]
        public List<TruckModel> TruckModels { get; set; }
        protected override async Task OnInitializedAsync()
        {
            var repository = DatabaseRepository;
            var trucks = await repository.GetTrucks();
            TruckModels = trucks;
        }
        private async Task AddTruckModel()
        {
            //no reason to reload the whole list. so if the add is successful we just append the item to the model list

            TruckModels.Add(new TruckModel { ID = 100, Name = "added", Description = "descadded" });
        }
    }
}
