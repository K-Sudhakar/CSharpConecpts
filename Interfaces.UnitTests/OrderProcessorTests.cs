using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace Interfaces.UnitTests
{
    public class OrderProcessorTests
    {
        [Fact]
         public void Process_OrderIsAlreadyShipped_ThrowsAnExpection()
        {
            var orderPr = new OrderProcessor(new FakeShippingCalculator());
            
            Assert.Throws<InvalidOperationException>(()=> orderPr.Process(new Order { shipment = new Shipment() }));
        }
        [Fact]
        public void Process_OrderIsNotShipped_ShouldNotSetTheShipmentPropertyOfTheOrder()
        {
            var orderPr = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderPr.Process(order);
            Assert.True(order.IsShipped);
            Assert.Equal(DateTime.Today.AddDays(1), order.shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}