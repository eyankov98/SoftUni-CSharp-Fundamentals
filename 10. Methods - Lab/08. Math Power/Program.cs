namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());

            MathPower(baseNumber, powerNumber);
        }

        static void MathPower(double baseNum, double powerNum)
        {
            Console.WriteLine(Math.Pow(baseNum, powerNum));
        }
    }
}