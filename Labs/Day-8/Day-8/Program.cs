using System.Text.RegularExpressions;

namespace Day_8
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            string str = "8882057008";
            string PatternToBematched = "^[0-9]{10}$";
            Regex rx = new Regex(PatternToBematched);
            if (rx.IsMatch(str))
            {
                Console.WriteLine("Your number is valid");
            }
            else
            {
                Console.WriteLine("Your number is Invalid");
            }
            Console.WriteLine("Hello, World!");
        }
    }
}