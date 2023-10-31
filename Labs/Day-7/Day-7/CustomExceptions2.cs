using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    class DivNumers
    {
        int Result;

        public DivNumers()
        {
            Result = 0;
        }
        public void division(int Num1, int Num2)
        {

            try
            {
                if (Num2 == 0)
                {
                    throw (new NumberIsZeroException("Value of Number is 0"));
                }
                Result = Num1 / Num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Excepion caught : {0}", e);
            }
            catch (NumberIsZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Result : {0}", Result);
            }
        }
    }
    public class NumberIsZeroException : Exception
    {
        public NumberIsZeroException(string message) : base(message)
        {

        }
    }
    internal class CustomExceptions2
    {
        public static void Main()
        {
            DivNumers d = new DivNumers();
            d.division(3, 0);
        }
    }
}
