using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class AbstractDemo
    {
      public void Demo()
        {
           var circle=new Circle();
            circle.Draw();
            var rect=new Rectangle("Test");
            rect.Draw();
        }
    }
}
