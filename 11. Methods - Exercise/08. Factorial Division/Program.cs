namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstNumFactorial = (double)(NumberFactorial(firstNumber));
            double secondNumFactorial = (double)NumberFactorial(secondNumber);

            Console.WriteLine($"{firstNumFactorial / secondNumFactorial:f2}");
        }

        static double NumberFactorial(int number)
        {
            double result = 1.00;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}