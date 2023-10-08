using System.Text;

StringBuilder message = new StringBuilder(Console.ReadLine());

string command = string.Empty;

while ((command = Console.ReadLine()) != "Reveal")
{
    string[] commandArray = command.Split(":|:");

    if (command.Contains("InsertSpace"))
    {
        int index = int.Parse(commandArray[1]);
        message.Insert(index, " ");

        Console.WriteLine(message);
    }
    else if (command.Contains("Reverse"))
    {
        string givenSubstring = commandArray[1];

        string messageString = message.ToString();
        int index = messageString.IndexOf(givenSubstring);

        if (messageString.Contains(givenSubstring))
        {
            message.Remove(index, givenSubstring.Length);

            char[] stringArray = givenSubstring.ToCharArray();
            Array.Reverse(stringArray);
            string reversedString = new string(stringArray);
            message.Append(reversedString);

            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (command.Contains("ChangeAll"))
    {
        string givenSubstring = commandArray[1];
        string replacement = commandArray[2];

        for (int i = 0; i < message.Length; i++)
        {
            message.Replace(givenSubstring, replacement);
        }

        Console.WriteLine(message);
    }
}

Console.WriteLine($"You have a new text message: {message}");