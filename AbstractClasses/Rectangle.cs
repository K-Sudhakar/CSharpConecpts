using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Rectangle : Shape
    {
        public Rectangle(string pa):base(pa) {
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }
}
