namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(firstNumber, secondNumber, thirdNumber));
        }

        static int SmallestNumber(int n1, int n2, int n3)
        {
            int smallestNumber = int.MaxValue;

            if (n1 < smallestNumber)
            {
                smallestNumber = n1;
            }
            if (n2 < smallestNumber)
            {
                smallestNumber = n2;
            }
            if (n3 < smallestNumber)
            {
                smallestNumber = n3;
            }

            return smallestNumber;
        }
    }
}