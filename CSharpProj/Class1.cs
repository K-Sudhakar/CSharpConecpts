using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProj
{
    public sealed partial class Part1
    {
        public void Run2()
        {

        }
        
    }
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent");
        }
    }
    public class Child:Parent
    {
       public Child() {
            Console.WriteLine("Child");

        }
    }
   public static class C
    {
         static C() { }
    }
   /* class C :IA,Child
    {
        public C() { }
    }*/
    public interface IA3
    {
        public void call();
    }
}
