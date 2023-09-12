namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            Repeat(inputString, repeatCount);
        }

        static void Repeat(string inputString, int repeatCount)
        {
            for (int i = 1; i <= repeatCount; i++)
            {
                Console.Write(inputString);
            }
        }
    }
}
