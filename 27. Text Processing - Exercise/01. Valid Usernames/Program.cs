string[] inputArray = Console.ReadLine().Split(", ");

List<string> validUsenames = new List<string>();

for (int i = 0; i < inputArray.Length; i++)
{
    bool isValid = false;
    if (inputArray[i].Length > 2 && inputArray[i].Length < 17)
    {
        char[] currentUsernameChars = inputArray[i].ToCharArray();

        for (int j = 0; j < currentUsernameChars.Length; j++)
        {
            if (Char.IsLetter(currentUsernameChars[j]))
            {
                isValid = true;
            }
            else if (Char.IsDigit(currentUsernameChars[j]))
            {
                isValid = true;
            }
            else if (currentUsernameChars[j] == 45)
            {
                isValid = true;
            }
            else if (currentUsernameChars[j] == 95)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
                break;
            }
        }
    }

    if (isValid)
    {
        validUsenames.Add(inputArray[i]);
    }
}

foreach (var username in validUsenames)
{
    Console.WriteLine(username);
}