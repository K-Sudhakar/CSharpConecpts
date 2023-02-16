using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class OvverideExample
    {
        public OvverideExample() { }
        public void DoJob()
        {
            List<Shape> shapes = new List<Shape> { new Circle(),new Rectangle() };
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
              
        }
    }
}
