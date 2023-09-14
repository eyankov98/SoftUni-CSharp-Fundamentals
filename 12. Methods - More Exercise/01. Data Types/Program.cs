namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string inputType = Console.ReadLine();

                if (inputType == "int")
                {
                    int input = int.Parse(Console.ReadLine());
                    Integers(input);
                }
                else if (inputType == "real")
                {
                    double input = double.Parse(Console.ReadLine());
                    RealNums(input);
                }
                else if (inputType == "string")
                {
                    string input = Console.ReadLine();
                    Strings(input);
                }
            }

            static void Integers(int input)
            {
                Console.WriteLine(input * 2);
            }
            static void RealNums(double input)
            {
                Console.WriteLine($"{(input * 1.5):f2}");
            }
            static void Strings(string input)
            {
                Console.WriteLine($"${input}$");
            }
        }
    }
}