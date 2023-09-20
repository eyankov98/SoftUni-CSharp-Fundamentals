namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] inputArray = input.Split()
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;

            int[] inputArrayCopy = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArrayCopy[i] = inputArray[i];
            }

            Modifier(inputArray, inputArrayCopy, command);

            static void Modifier(int[] inputArray, int[] inputArrayCopy, string command)
            {
                int[] outputArray = inputArray;

                while ((command = Console.ReadLine()) != "end")
                {
                    if (command.Contains("swap") == true)
                    {
                        string[] commandNumbers = command.Split();
                        int[] numbers = new int[2];

                        numbers[0] = int.Parse(commandNumbers[1]);
                        numbers[1] = int.Parse(commandNumbers[2]);

                        outputArray[numbers[0]] = inputArrayCopy[numbers[1]];
                        outputArray[numbers[1]] = inputArrayCopy[numbers[0]];
                    }
                    else if (command.Contains("multiply") == true)
                    {
                        string[] commandNumbers = command.Split();
                        int[] numbers = new int[2];

                        numbers[0] = int.Parse(commandNumbers[1]);
                        numbers[1] = int.Parse(commandNumbers[2]);

                        outputArray[numbers[0]] *= inputArray[numbers[1]];
                    }
                    else if (command.Contains("decrease") == true)
                    {
                        for (int i = 0; i < outputArray.Length; i++)
                        {
                            outputArray[i] -= 1;
                        }
                    }

                    for (int j = 0; j < outputArray.Length; j++)
                    {
                        inputArrayCopy[j] = outputArray[j];
                    }
                }

                Console.WriteLine(String.Join(", ", outputArray));
            }
        }
    }
}