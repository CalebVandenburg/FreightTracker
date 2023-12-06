using FreightTracker.Database;
using FreightTracker.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace FreightTracker.Components.Pages
{
    public partial class TruckDetail : ComponentBase
    {
        [Inject]
        private DatabaseRepository DatabaseRepository { get; set; }
        [Parameter]
        public int ID { get; set; }
        [Parameter]
        public TruckModel TruckModel { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if(ID >= 1)
            {
                var repository = DatabaseRepository;
                TruckModel = await repository.GetTruckByID(ID);
            }
        }
        async void FormSubmitted()        
        {
            //validation of edited truck model

            //
            var repository = DatabaseRepository;
            TruckModel = await repository.UpdateTruck(TruckModel);

        }
    }
}
