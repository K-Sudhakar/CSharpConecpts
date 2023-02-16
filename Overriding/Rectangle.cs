using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class Rectangle : Shape
    {
        public Rectangle() { }
        public override void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }
}
