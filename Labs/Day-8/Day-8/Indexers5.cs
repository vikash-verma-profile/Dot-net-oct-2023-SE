using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class Dummy
    {
        //fields
        //abstraction or fields hiding
       private int _id;//==> fields
       public int id // property
        {
            get { return _id; } //get method
            set { _id = value;} //set method
        }

        //automatic properties
        public string Name { get; set; }
    }
    class IndexerCreation
    {
        private string[] val = new string[4];
        public string this[int index]
        { get { return val[index]; }
          set { val[index] = value; }
        }
    }
    internal class Indexers5
    {
        public static void Main()
        {
            Dummy d=new Dummy();
            d.id = 1;
            Console.WriteLine(d.id);

            IndexerCreation c=new IndexerCreation();
            c[0] = "C";
            c[1] = "C++";
            c[2] = "C#";
            c[3] = "java";

            Console.WriteLine(c[0]);
            Console.WriteLine(c[1]);
            Console.WriteLine(c[2]);
            Console.WriteLine(c[3]);
        }
    }
}
