namespace FreightTracker.Models
{
    public class TruckModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double StorageCapactiy { get; set; }
        public double FuelCapacity { get; set; }
        public double AverageMPG {  get; set; }
        public bool Availability { get; set; }
        public TruckType TruckType { get; set; }
    }
    public enum TruckType
    {
        Truck,
        Flatbed
    }
}
