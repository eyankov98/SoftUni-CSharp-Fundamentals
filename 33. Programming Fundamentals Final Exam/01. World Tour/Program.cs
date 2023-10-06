string worldTour = Console.ReadLine();

string input = Console.ReadLine();

while (input != "Travel")
{
    string[] command = input
        .Split(":", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string currentCommand = command[0];

    if (currentCommand == "Add Stop")
    {
        int index = int.Parse(command[1]);
        string stringОfCountry = command[2];

        if (index >= 0 && index <= worldTour.Length - 1)
        {
            worldTour = worldTour.Insert(index, stringОfCountry);
        }

        Console.WriteLine(worldTour);
    }
    else if (currentCommand == "Remove Stop")
    {
        int startIndex = int.Parse(command[1]);
        int endIndex = int.Parse(command[2]);

        if (startIndex >= 0 && startIndex <= worldTour.Length - 1 && endIndex >= 0 && endIndex <= worldTour.Length - 1)
        {
            //worldTour = worldTour.Substring(0, startIndex) + worldTour.Substring(endIndex + 1);
            worldTour = worldTour.Remove(startIndex, endIndex + 1 - startIndex);
        }

        Console.WriteLine(worldTour);
    }
    else if (currentCommand == "Switch")
    {
        string oldString = command[1];
        string newString = command[2];

        if (worldTour.Contains(oldString))
        {
            worldTour = worldTour.Replace(oldString, newString);
        }

        Console.WriteLine(worldTour);
    }

    input = Console.ReadLine();
}

Console.WriteLine($"Ready for world tour! Planned stops: {worldTour}");