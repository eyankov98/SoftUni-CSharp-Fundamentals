namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int numOne = int.Parse(Console.ReadLine());
                int numTwo = int.Parse(Console.ReadLine());
                int numThree = int.Parse(Console.ReadLine());

                Console.WriteLine(PositiveOrNegative(numOne, numTwo, numThree));
            }

            static string PositiveOrNegative(int numOne, int numTwo, int numThree)
            {
                int negativeNumsCnt = 0;

                if (numThree == 0 || numTwo == 0 || numThree == 0)
                {
                    return "zero";
                }

                if (numOne < 0)
                {
                    negativeNumsCnt++;
                }

                if (numTwo < 0)
                {
                    negativeNumsCnt++;
                }

                if (numThree < 0)
                {
                    negativeNumsCnt++;
                }

                if (negativeNumsCnt % 2 == 0)
                {
                    return "positive";
                }
                else
                {
                    return "negative";
                }
            }
        }
    }
}