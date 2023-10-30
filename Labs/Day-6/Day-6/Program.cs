namespace Day_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            object b;
            b = a;//boxing
            Console.WriteLine(b);
            b = 2;
            a = (int)b; //un-boxing
            Console.WriteLine(a);
        }
    }
}