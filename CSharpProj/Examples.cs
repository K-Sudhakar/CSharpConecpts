using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProj
{
    class SampleIndexer
    {
        // Declare an array to store the data elements.
        private string[] arr = new string[100];
         
        // Define the indexer to allow client code to use [] notation.
        public string this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base Cons");
        }
        static BaseClass()
        {
            Console.WriteLine("Base Static Cons");
        }

    }
    public class SubClass:BaseClass
    {
        public SubClass()
        {
            Console.WriteLine("Sub Cons");
        }
        static SubClass()
        {
            Console.WriteLine("Sub Static Cons");
        }
    }


    public class Glb
    {
        public Glb()
        {
            Console.WriteLine("Glb Cons");
        }
        static Glb()
        {
            Console.WriteLine("GlbStatic Cons");
        }

        public void CallInfo()
        {
            Console.WriteLine("Glb Call Info");
        }

    }
    public interface IA
    {
        void call1();
        void call2();
    }
    public interface IB
    {
        void call1();
    }
    public class Test : IA, IB
    {
        void IA.call1()
        {
            Console.WriteLine("IA Call");
        }
        void IA.call2()
        {
            Console.WriteLine("IA Call2");
        }
        void IB.call1()
        {
            Console.WriteLine("IB Call");
        }
    }

    public class Test1 : IA
    {
        void IA.call1()
        {
            Console.WriteLine("IA Call");
        }
        void IA.call2()
        {
           
            Console.WriteLine("IA Call2");
        }
        public void call2()
        {
            //call2();
            IA obj1 = (IA)new Test1();
            obj1.call2();
            Console.WriteLine("Test Call2");
        }
    }
    public sealed partial class Part1
    {
        public void Run()
        {

        }
    }


    public class Examples
    {
        public void RefOutTest(ref int refVal, out int outVal, in int inVal)
        {
            outVal = 1;
            int testVal;
            int.TryParse("S", out testVal);
            StringBuilder objBuilder = new StringBuilder();
            Part1 objPar1 = new Part1();


        }
        public Examples()
        {
            BaseClass objBase = new BaseClass();
            SubClass objSub = new SubClass();
            BaseClass objBase2=new SubClass();
           // SubClass objSub2 = new BaseClass();

            StaticPloyDerived Spd = new StaticPloyDerived();
            Spd.Display(5, 10);
            StaticPloyBase spBase = new StaticPloyDerived();
            spBase.Display(5);

            DynamicPloyDerived objDyn = new DynamicPloyDerived();
            objDyn.Display(5);
            DynamicPloyBase objDynBase = new DynamicPloyDerived();
            objDynBase.Display(5);

            int tesOutVal, valTest = 1, refVal = 1;
            this.RefOutTest(ref refVal, out tesOutVal, in valTest);
            Test objTe = new Test();
            Test1 objTe1 = new Test1();
            
            objTe1.call2();
            Glb objG = new Glb();
            Glb objG2 = new Glb();

            //objG.CallInfo();

        }
        public async Task<int> GetData()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 50)
                        Task.Delay(10000).Wait();

                    Console.WriteLine(" GetData 1");
                    count += 1;
                }
            });
            return count;
        }

        public async Task<int> GetData2()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 70)
                        Task.Delay(10000).Wait();

                    Console.WriteLine(" GetData 2");
                    count += 1;
                }
            });
            return count;
        }
    }

    public class StaticPloyBase
    {
        public void Display(int x)
        {
            Console.WriteLine("Area of a Square from StaticPloyBase:" + x * x);
        }


    }
    public class StaticPloyDerived : StaticPloyBase
    {

        public void Display(int x, int y)
        {
            Console.WriteLine("Area of a Square from StaticPloyDerived:" + (x * y));
        }

    }
    public class DynamicPloyBase
    {
        public void Display(int x)
        {
            Console.WriteLine("Area of a Square from Dynamic Base:" + x * x);
        }


    }
    public class DynamicPloyDerived : DynamicPloyBase
    {

        public void Display(int x)
        {
            Console.WriteLine("Area of a Square From Dynamic Derived:" + (x * 2));
        }

    }
}
