namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            TopNumbers(inputNumber);
        }

        static void TopNumbers(int endNumber)
        {
            for (int i = 1; i <= endNumber; i++)
            {
                bool digitsSumDivisibleByEight = false;
                bool atLeastOneOddDigit = false;

                string iString = Convert.ToString(i);
                char[] currentNumber = new char[iString.Length];

                int digitsSum = 0;
                for (int j = 0; j < iString.Length; j++)
                {
                    currentNumber[j] = iString[j];
                    digitsSum += currentNumber[j];

                    if (currentNumber[j] % 2 == 1)
                    {
                        atLeastOneOddDigit = true;
                    }
                }

                if (digitsSum % 8 == 0)
                {
                    digitsSumDivisibleByEight = true;
                }

                if (digitsSumDivisibleByEight == true && atLeastOneOddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}