int n = int.Parse(Console.ReadLine());

int[] outputArray = new int[n];

for (int i = 0; i < n; i++)
{
    string inputString = Console.ReadLine();
    char[] inputArrayChar = new char[inputString.Length];

    int vowelsSum = 0;
    int constantsSum = 0;
    int allLettersSum = 0;

    for (int k = 0; k < inputString.Length; k++)
    {
        inputArrayChar[k] = inputString[k];
    }

    for (int j = 0; j < inputString.Length; j++)
    {
        if (inputArrayChar[j] == 'a' || inputArrayChar[j] == 'e' || inputArrayChar[j] == 'i' || inputArrayChar[j] == 'o' || inputArrayChar[j] == 'u' || inputArrayChar[j] == 'A' || inputArrayChar[j] == 'E' || inputArrayChar[j] == 'I' || inputArrayChar[j] == 'O' || inputArrayChar[j] == 'U')
        {
            vowelsSum += inputArrayChar[j] * inputArrayChar.Length;
        }
        else
        {
            constantsSum += inputArrayChar[j] / inputArrayChar.Length;
        }
    }

    allLettersSum = vowelsSum + constantsSum;
    outputArray[i] = allLettersSum;
}

Array.Sort(outputArray);
for (int o = 0; o < n; o++)
{
    Console.WriteLine(outputArray[o]);
}