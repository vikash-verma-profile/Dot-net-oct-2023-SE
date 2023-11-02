using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    //Generic class
    public class Sample<T>
    {
        public T Id;
    }
    public class SampleMethod
    {
        public void Display<Typeofvalue>(string msg, Typeofvalue value)
        {
            Console.WriteLine("{0} : {1}",msg,value);
        }
    }
    internal class GenricClass2
    {
        public static void Main2()
        {
            Sample<int> ObjSample=new Sample<int>();
            ObjSample.Id = 1;
            Console.WriteLine(ObjSample.Id);

            Sample<string> ObjSample1 = new Sample<string>();
            ObjSample1.Id = "I am string value";
            Console.WriteLine(ObjSample1.Id);

            SampleMethod s = new SampleMethod();
            s.Display<int>("Integer",123);
            s.Display<string>("String", "VIkash");
            s.Display<double>("Decimal ", 12.43);
        }
    }
}
