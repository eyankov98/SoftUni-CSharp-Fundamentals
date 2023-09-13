namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputInteger = int.Parse(Console.ReadLine());

            Matrix(inputInteger);
        }

        static void Matrix(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}