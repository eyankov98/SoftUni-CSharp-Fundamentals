namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int d = Sum(a, b);
            int result = Subtract(d, c);

            Console.WriteLine(result);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int d, int c)
        {
            return d - c;
        }
    }
}