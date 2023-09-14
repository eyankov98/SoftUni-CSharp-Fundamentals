namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int num = int.Parse(Console.ReadLine());
                int[] arrayNumbers = new int[num];

                Console.WriteLine(String.Join(" ", TribonacciSequence(num, arrayNumbers)));
            }

            static int[] TribonacciSequence(int num, int[] arrayNumbers)
            {
                arrayNumbers = new int[num];
                arrayNumbers[0] = 1;

                for (int i = 1; i < num; i++)
                {
                    if (i == 1)
                    {
                        arrayNumbers[i] = i;
                    }
                    else if (i == 2)
                    {
                        arrayNumbers[i] = i;
                    }
                    else
                    {
                        arrayNumbers[i] = arrayNumbers[i - 1] + arrayNumbers[i - 2] + arrayNumbers[i - 3];
                    }
                }

                return arrayNumbers;
            }
        }
    }
}