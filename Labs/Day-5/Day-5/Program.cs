namespace Day_5
{
    internal class Program
    {

        public static void sum()
        {
            Console.WriteLine(1 + 2);
        }
        public static void sum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public  static void sum(string a, string b)
        {
            Console.WriteLine(a + b);
        }
        public static void sum(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }
        static void Main1(string[] args)
        {
           sum();
           sum(1, 2);
            sum("Vikash ", "Verma");
            sum(1, 2, 3);
        }
    }
}