using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class Circle : Shape
    {
        public Circle() { }
        public sealed override void Draw()
        {
            Console.WriteLine("sealed Circle Draw");
        } 
    }
    public class Cir :Circle
    {
        public Cir() { }

    }

} 
