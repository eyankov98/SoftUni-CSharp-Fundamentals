List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string text = Console.ReadLine();

List<int> numbersDigitsSums = new List<int>();

for (int i = 0; i < numbers.Count; i++)
{
    int currentNumSum = 0;
    string currentNumString = Convert.ToString(numbers[i]);

    for (int j = 0; j < currentNumString.Length; j++)
    {
        int currentNumInt = Convert.ToInt32(currentNumString[j].ToString());
        currentNumSum += currentNumInt;
    }

    numbersDigitsSums.Add(currentNumSum);
}

List<string> textString = text.Select(x => x.ToString()).ToList();

for (int k = 0; k < numbersDigitsSums.Count; k++)
{
    while (numbersDigitsSums[k] > textString.Count)
    {
        numbersDigitsSums[k] -= textString.Count;
    }

    Console.Write(textString[numbersDigitsSums[k]]);

    textString.RemoveAt(numbersDigitsSums[k]);
}