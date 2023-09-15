﻿List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string command = string.Empty;
while ((command = Console.ReadLine()) != "end")
{
    if (command.Contains("Add") == true)
    {
        string[] commandArray = command.Split();
        int value = int.Parse(commandArray[1]);

        numbers.Add(value);
    }
    else if (command.Contains("RemoveAt") == true)
    {
        string[] commandArray = command.Split();
        int index = int.Parse(commandArray[1]);

        numbers.RemoveAt(index);
    }
    else if (command.Contains("Remove") == true)
    {
        string[] commandArray = command.Split();
        int value = int.Parse(commandArray[1]);

        numbers.Remove(value);
    }
    else if (command.Contains("Insert") == true)
    {
        string[] commandArray = command.Split();
        int value = int.Parse(commandArray[1]);
        int index = int.Parse(commandArray[2]);

        numbers.Insert(index, value);
    }
}

Console.WriteLine(String.Join(" ", numbers));