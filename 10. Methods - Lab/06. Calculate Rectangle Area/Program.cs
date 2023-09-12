namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumberOne = int.Parse(Console.ReadLine());
            int inputNumberTwo = int.Parse(Console.ReadLine());

            AreaCalculation(inputNumberOne, inputNumberTwo);
        }

        static void AreaCalculation(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
    }
}
