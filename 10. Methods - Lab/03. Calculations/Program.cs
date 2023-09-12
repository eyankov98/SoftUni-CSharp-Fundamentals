namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculationType = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Calculations(firstNumber, calculationType, secondNumber);
        }

        static void Calculations(double firstNum, string action, double secondNum)
        {
            if (action == "add")
            {
                Console.WriteLine(firstNum + secondNum);
            }
            else if (action == "multiply")
            {
                Console.WriteLine(firstNum * secondNum);
            }
            else if (action == "subtract")
            {
                Console.WriteLine(firstNum - secondNum);
            }
            else if (action == "divide")
            {
                Console.WriteLine(firstNum / secondNum);
            }
        }
    }
}
