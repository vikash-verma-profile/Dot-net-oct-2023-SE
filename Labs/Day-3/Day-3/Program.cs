namespace Day_3
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int[,] matrix = new int[2, 2];
            Console.WriteLine("Please enter values");
            for (int row = 0; row < 2; row++)
            {

                for (int col = 0; col < 2; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your matrix is");
            for (int row = 0; row < 2; row++)
            {

                for (int col = 0; col < 2; col++)
                {
                    Console.Write(matrix[row, col]+"\t");
                }
                Console.WriteLine();
            }
            //Console.WriteLine("Hello, World!");

            //Console.Write("Hello"+"\n");
            //Console.Write("Hello" + "\n");
        }
    }
}