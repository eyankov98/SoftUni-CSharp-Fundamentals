namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string calculator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            if (calculator == "+")
            {
                Console.WriteLine(Addition(firstNumber, secondNumber));
            }
            else if (calculator == "*")
            {
                Console.WriteLine(Multiplication(firstNumber, secondNumber));
            }
            else if (calculator == "-")
            {
                Console.WriteLine(Subtraction(firstNumber, secondNumber));
            }
            else if (calculator == "/")
            {
                Console.WriteLine(Division(firstNumber, secondNumber));
            }
        }

        static double Addition(double n1, double n2)
        {
            return n1 + n2;
        }
        static double Subtraction(double n1, double n2)
        {
            return n1 - n2;
        }
        static double Multiplication(double n1, double n2)
        {
            return n1 * n2;
        }
        static double Division(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}