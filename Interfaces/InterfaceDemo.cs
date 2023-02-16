using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class InterfaceDemo
    {
        public void DoJob()
        {
            var orderPr = new OrderProcessor(new ShippingCalculator());
            orderPr.Process(new Order { DatePlaced=DateTime.Now,TotalPrice=100f}); 
        }
    }
}
