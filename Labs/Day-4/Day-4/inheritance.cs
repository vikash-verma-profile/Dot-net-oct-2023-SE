using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    //parent or base class
    class Vechicle
    {
        protected string vehicleModel;
        string vehicleType;
       public Vechicle()
        {
            Console.WriteLine("I am being called here from Vechicle ");
        }
    }
    class Car : Vechicle
    {
        public Car()
        {
            Console.WriteLine("I am being called here from Car ");
        }
        public void Print()
        {
            Console.WriteLine("Vehicle model"+ vehicleModel);
        }
    }
    class Audi : Car
    {

    }
    internal class inheritance
    {
        public static void Main()
        {
            Car c=new Car();
        }
    }
}
