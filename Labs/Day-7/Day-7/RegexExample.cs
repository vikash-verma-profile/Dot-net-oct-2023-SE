using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_7
{
    internal class RegexExample
    {
        public static void Main()
        {
            Console.WriteLine("Please enter some value : ");
            String SampleValue = Console.ReadLine();
            string matchPattern = "^[0-9]{4}$";

            Regex re = new Regex(matchPattern);
            if (re.IsMatch(SampleValue))
            {
                Console.WriteLine("The value is valid");
            }
            else
            {
                Console.WriteLine("Not a Valid value");
            }
        }
    }
}
