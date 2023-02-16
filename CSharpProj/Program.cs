// See https://aka.ms/new-console-template for more information
using AbstractClasses;
using Casting;
using CSharpProj;
using Inheritance;
using Interfaces;
using Overriding;
//Interfaces Demo
InterfaceDemo interfaceDemo = new InterfaceDemo();
interfaceDemo.DoJob();
//Abstract Demo
AbstractDemo objAbs=new AbstractDemo();
objAbs.Demo();

//Ovverriding
OvverideExample objOver=new OvverideExample();
objOver.DoJob();
//Casting 
/*Circle circle= new Circle();
Shape shape= circle;//Upcasting
Shape shapeD =new Shape();
Circle circle1 = (Circle)shapeD;//DownCasting*/

//Constructors
var car = new Car("Test Car");
Console.WriteLine("Hello, World!");
//Composition Example
Composition composition= new Composition();
composition.DoJOB();
//Indexer Example
SampleIndexer objInd = new SampleIndexer();
objInd[0] = "Test";
Console.WriteLine("Indexer Eample:{0}", objInd[0]);
Child obj = new Child();
//C obj1 = new C();
Examples obj2 = new Examples();
//var data1 = await obj2.GetData();
//Console.WriteLine(" Final Count:{0}", data1);
//var data2 = await obj2.GetData2();
//Console.WriteLine(" Final Count:{0}", data2);

string strInput = "jitendra";

strInput=string.Join(",", strInput.ToCharArray());
Console.WriteLine(strInput);
strInput = "jitendra";
string result = "";
int i = 0;
IList<string> strList = new List<string>() { 
                                            "One", 
                                            "Two", 
                                            "Three", 
                                            "Four", 
                                            "Five", 
                                            "Six"  };

var resultList = strList.TakeWhile((s, i) => s.Length > i);

foreach(string str in resultList)
        Console.WriteLine(str);
foreach (char ch in strInput.ToCharArray())
{
    if (i>0&&i%2==0)
    {
        result += ",";
       
    }
    result += ch;
    i++;
}
Console.WriteLine(result);

