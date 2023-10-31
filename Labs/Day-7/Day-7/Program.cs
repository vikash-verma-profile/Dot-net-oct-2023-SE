namespace Day_7
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            try
            {
                int Number1, Number2;
                Number1 = 4;
                Number2 = 2;
                decimal result = Number1 / Number2;
               
                Console.WriteLine(result);
                throw new Exception();

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Some error have occured");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Some error have occured");
            }
            catch(Exception ex) {
                Console.WriteLine("Hi i am coming from throw keyword");
            }
            finally{
                Console.WriteLine("Hi I am in finally block");
            }

        }
    }
}