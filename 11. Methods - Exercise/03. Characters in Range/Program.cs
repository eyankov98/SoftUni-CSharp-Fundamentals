namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char firstCharCopy = firstChar;
            char secondChar = char.Parse(Console.ReadLine());

            if (firstChar > secondChar)
            {
                firstChar = secondChar;
                secondChar = firstCharCopy;
            }

            int charsDistance = Math.Abs(firstChar - secondChar);

            CharactersInRange(firstChar, secondChar, charsDistance);
        }

        static void CharactersInRange(char firstChar, char secondChar, int distance)
        {
            char[] charArray = new char[distance - 1];
            int k = 0;

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                charArray[k] = (char)i;
                k++;
            }

            for (int j = 0; j < distance - 1; j++)
            {
                if (j != distance - 2)
                {
                    Console.Write(charArray[j] + " ");
                }
                else
                {
                    Console.Write(charArray[j]);
                }
            }
        }
    }
}