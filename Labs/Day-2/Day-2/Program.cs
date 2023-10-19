namespace Day_2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int inputValue = 12;
            switch (inputValue)
            {
                case 0:
                    Console.WriteLine("Hi i am case 0");
                    break;
                case 2:
                    Console.WriteLine("Hi i am case 2");
                    break;
                case 4:
                    Console.WriteLine("Hi i am case 3");
                    break;
                default:
                    Console.WriteLine("This output is coming from default block");
                    break;
            }
        }
    }
}