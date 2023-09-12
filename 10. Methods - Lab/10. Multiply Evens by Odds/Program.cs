namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumberString = Console.ReadLine();
            int inputNumber = int.Parse(inputNumberString);

            int inputNumberAbs = (Math.Abs(inputNumber));
            int inputNumberLength = inputNumberString.Length;

            int evensSum = GetSumOfEvenDigits(inputNumberAbs, inputNumberLength);
            int oddsSum = GetSumOfOddDigits(inputNumberAbs, inputNumberLength);
            int evensMultipleOdds = GetMultipleOfEvenAndOdds(evensSum, oddsSum);

            Console.WriteLine(evensMultipleOdds);
        }

        static int GetMultipleOfEvenAndOdds(int evensSum, int oddsSum)
        {
            return evensSum * oddsSum;
        }

        static int GetSumOfEvenDigits(int number, int length)
        {
            int evenDigitsSum = 0;

            for (int i = length; i > 0; i--)
            {
                int lastDigit = number % 10;
                number = (number - lastDigit) / 10;

                if (lastDigit % 2 == 0)
                {
                    evenDigitsSum += lastDigit;
                }
            }

            return evenDigitsSum;
        }

        static int GetSumOfOddDigits(int number, int length)
        {
            int oddDigitsSum = 0;

            for (int i = length; i > 0; i--)
            {
                int lastDigit = number % 10;
                number = (number - lastDigit) / 10;

                if (lastDigit % 2 == 1)
                {
                    oddDigitsSum += lastDigit;
                }
            }

            return oddDigitsSum;
        }
    }
}