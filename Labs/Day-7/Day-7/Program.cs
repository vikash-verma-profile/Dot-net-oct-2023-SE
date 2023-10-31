namespace Day_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Number1, Number2;
                Number1 = 4;
                Number2 = 0;
                decimal result = Number1 / Number2;
                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Some error have occured");
            }
            
        }
    }
}