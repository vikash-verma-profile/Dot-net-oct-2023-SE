using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    //arraylist
    //HashTable
    //Queue and stack
    internal class Non_Gernics2cs
    {
        public static void Main()
        {
            ArrayList array= new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add("VIkash");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
