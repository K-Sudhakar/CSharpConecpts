namespace Interfaces
{
    public class Order
    {
        public Shipment shipment { get; set; }
        public bool IsShipped { get { return shipment != null; } }
        public float  TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }
    }

 
}