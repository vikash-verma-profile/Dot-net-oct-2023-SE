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
    internal class Indexers5
    {
        public static void Main()
        {
            Dummy d=new Dummy();
            d.id = 1;
        }
    }
}
