﻿List<int> inputList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "end")
{
    if (command.Contains("Delete"))
    {
        string[] commandArray = command.Split();
        int numberForDelete = Convert.ToInt32(commandArray[1].ToString());

        for (int i = inputList.Count - 1; i >= 0; i--)
        {
            if (inputList[i] == numberForDelete)
            {
                inputList.Remove(inputList[i]);
            }
        }
    }
    else if (command.Contains("Insert"))
    {
        string[] commandArray = command.Split();
        int element = int.Parse(commandArray[1].ToString());
        int index = int.Parse(commandArray[2].ToString());

        inputList.Insert(index, element);
    }
}

Console.WriteLine(string.Join(" ", inputList));