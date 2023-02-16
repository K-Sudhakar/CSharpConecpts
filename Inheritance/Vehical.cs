namespace Inheritance
{
    public class Vehical
    {
        private readonly string _name;
         public Vehical(string name) { 
        _name = name;
            Console.WriteLine("Vehical Initial {0}", name);
        }
    }
}