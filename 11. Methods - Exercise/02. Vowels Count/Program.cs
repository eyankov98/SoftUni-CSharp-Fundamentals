namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(VowelsCount(input));
        }

        static int VowelsCount(string input)
        {
            char[] inputArray = input.ToCharArray();
            int vowelsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (inputArray[i] == 'A' || inputArray[i] == 'E' || inputArray[i] == 'I'
                    || inputArray[i] == 'O' || inputArray[i] == 'U' || inputArray[i] == 'a'
                    || inputArray[i] == 'e' || inputArray[i] == 'i' || inputArray[i] == 'o'
                    || inputArray[i] == 'u')
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}