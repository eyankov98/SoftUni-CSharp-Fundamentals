string[] stringsInput = Console.ReadLine().Split();
string stringOne = stringsInput[0];
string stringTwo = stringsInput[1];

Console.WriteLine(CharacterMultiplier(stringOne, stringTwo));

static int CharacterMultiplier(string stringOne, string stringTwo)
{
    int multiplicationLength = 0;
    bool areEqual = false;

    if (stringOne.Length >= stringTwo.Length)
    {
        multiplicationLength = stringTwo.Length;

        if (stringOne.Length == stringTwo.Length)
        {
            areEqual = true;
        }
    }
    else
    {
        multiplicationLength = stringOne.Length;
    }

    int sum = 0;
    char[] stringOneCharArr = stringOne.ToCharArray();
    char[] stringTwoCharArr = stringTwo.ToCharArray();

    for (int i = 0; i < multiplicationLength; i++)
    {
        sum += stringOneCharArr[i] * stringTwoCharArr[i];
    }

    if (!areEqual)
    {
        if (stringOne.Length > stringTwo.Length)
        {
            multiplicationLength = stringOne.Length - stringTwo.Length;
            for (int i = stringOne.Length - multiplicationLength; i < stringOne.Length; i++)
            {
                sum += stringOneCharArr[i];
            }
        }
        else
        {
            multiplicationLength = stringTwo.Length - stringOne.Length;
            for (int i = stringTwo.Length - multiplicationLength; i < stringTwo.Length; i++)
            {
                sum += stringTwoCharArr[i];
            }
        }
    }

    return sum;
}