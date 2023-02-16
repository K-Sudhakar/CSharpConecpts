using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car:Vehical
    {
        public Car(string name):base(name) {
            Console.WriteLine("Car Init {0}", name);
        }
    }
}
