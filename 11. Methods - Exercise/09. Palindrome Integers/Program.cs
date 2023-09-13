namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PalindromeChecker(input);
        }

        static void PalindromeChecker(string inputCommand)
        {
            while (inputCommand != "END")
            {
                char[] numberArray = inputCommand.ToCharArray();

                if (inputCommand.Length == 1)
                {
                    Console.WriteLine("true");
                }
                else if (inputCommand.Length % 2 == 0)
                {
                    int[] numbersFirstHalf = new int[inputCommand.Length / 2];
                    int[] numbersSecondHalf = new int[inputCommand.Length / 2];

                    for (int i = 0; i <= inputCommand.Length / 2 - 1; i++)
                    {
                        numbersFirstHalf[i] = numberArray[i];
                    }

                    for (int j = inputCommand.Length / 2 - 1; j >= 0; j--)
                    {
                        numbersSecondHalf[j] = numberArray[inputCommand.Length - 1 - j];
                    }

                    bool isEqual = false;

                    for (int k = 0; k < numbersFirstHalf.Length; k++)
                    {
                        if (numbersFirstHalf[k] == numbersSecondHalf[k])
                        {
                            isEqual = true;
                        }
                        else
                        {
                            isEqual = false;
                            break;
                        }
                    }

                    if (isEqual)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                else
                {
                    int[] numbersFirstHalf = new int[inputCommand.Length / 2];
                    int[] numbersSecondHalf = new int[inputCommand.Length / 2];

                    for (int i = 0; i < inputCommand.Length / 2; i++)
                    {
                        numbersFirstHalf[i] = numberArray[i];
                    }

                    for (int j = 0; j < inputCommand.Length / 2; j++)
                    {
                        numbersSecondHalf[j] = numberArray[inputCommand.Length - 1 - j];
                    }

                    bool isEqual = false;

                    for (int k = 0; k < numbersFirstHalf.Length; k++)
                    {
                        if (numbersFirstHalf[k] == numbersSecondHalf[k])
                        {
                            isEqual = true;
                        }
                        else
                        {
                            isEqual = false;
                            break;
                        }
                    }

                    if (isEqual)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }

                inputCommand = Console.ReadLine();
            }

            return;
        }
    }
}