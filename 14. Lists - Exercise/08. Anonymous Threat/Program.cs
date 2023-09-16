List<string> list = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "3:1")
{
    string[] commandArray = command.Split().ToArray();

    if (command.Contains("merge"))
    {
        int startIndex = Convert.ToInt32(commandArray[1]);
        int endIndex = Convert.ToInt32(commandArray[2]);

        if (list.Count > 1)
        {
            while (startIndex < 0 || startIndex >= list.Count - 1)
            {
                if (startIndex < 0)
                {
                    startIndex++;
                }
                else if (startIndex >= list.Count - 1)
                {
                    startIndex--;
                }
            }
            while (endIndex >= list.Count || endIndex < 1)
            {
                if (endIndex < 1)
                {
                    endIndex++;
                }
                else if (endIndex >= list.Count)
                {
                    endIndex--;
                }
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                list[startIndex] += $"{list[i + 1]}";
            }

            for (int j = 0; j < endIndex - startIndex; j++)
            {
                list.RemoveAt(startIndex + 1);
            }
        }
    }
    else if (command.Contains("divide"))
    {
        int index = Convert.ToInt32(commandArray[1]);
        int partitions = Convert.ToInt32(commandArray[2]);

        string textForDivision = list[index];
        List<string> textList = new List<string>();

        for (int i = 0; i < textForDivision.Length; i++)
        {
            textList.Add(textForDivision[i].ToString());
        }

        string currentString = string.Empty;
        list.RemoveAt(index);

        if (textList.Count % partitions == 0)
        {
            int lengthOfOneIndex = textList.Count / partitions;

            for (int i = partitions; i > 0; i--)
            {
                for (int j = textList.Count - lengthOfOneIndex; j < textList.Count; j++)
                {
                    currentString += $"{textList[j]}";
                    textList.RemoveAt(j);
                    j--;
                }

                list.Insert(index, currentString);
                currentString = string.Empty;
            }
        }
        else
        {
            int textListCount = textList.Count;
            int numbersRemovedCounter = 0;
            for (int i = textListCount - (textListCount % partitions); i < textListCount; i++)
            {
                textList.RemoveAt(textListCount - (textListCount % partitions));
                numbersRemovedCounter++;
            }

            int lengthOfOneIndex = textList.Count / partitions;

            for (int i = partitions; i > 0; i--)
            {
                for (int j = textList.Count - lengthOfOneIndex; j < textList.Count; j++)
                {
                    currentString += $"{textList[j]}";
                    textList.RemoveAt(j);
                    j--;
                }
                if (i == partitions)
                {
                    for (int j = 0; j < numbersRemovedCounter; j++)
                    {
                        currentString += $"{textForDivision[textForDivision.Length - numbersRemovedCounter + j]}";
                    }
                }

                list.Insert(index, currentString);
                currentString = string.Empty;
            }
        }
    }
}

Console.WriteLine(String.Join(" ", list));