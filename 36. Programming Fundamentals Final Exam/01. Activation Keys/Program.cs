string activationKey = Console.ReadLine();

string input = Console.ReadLine();

while (input != "Generate")
{
    string[] command = input
        .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string currentCommand = command[0];

    if (currentCommand == "Contains")
    {
        string substring = command[1];

        if (activationKey.Contains(substring))
        {
            Console.WriteLine($"{activationKey} contains {substring}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    else if (currentCommand == "Flip")
    {
        string upperOrLower = command[1];
        int startIndex = int.Parse(command[2]);
        int endIndex = int.Parse(command[3]);

        if (upperOrLower == "Upper")
        {
            activationKey = activationKey.Substring(0, startIndex) + activationKey.Substring(startIndex, endIndex - startIndex).ToUpper() + activationKey.Substring(endIndex);

            Console.WriteLine(activationKey);
        }
        else if (upperOrLower == "Lower")
        {
            activationKey = activationKey.Substring(0, startIndex) + activationKey.Substring(startIndex, endIndex - startIndex).ToLower() + activationKey.Substring(endIndex);

            Console.WriteLine(activationKey);
        }
    }
    else if (currentCommand == "Slice")
    {
        int startIndex = int.Parse(command[1]);
        int endIndex = int.Parse(command[2]);

        //activationKey = activationKey.Substring(0, startIndex) + activationKey.Substring(endIndex);
        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

        Console.WriteLine(activationKey);
    }

    input = Console.ReadLine();
}

Console.WriteLine($"Your activation key is: {activationKey}");