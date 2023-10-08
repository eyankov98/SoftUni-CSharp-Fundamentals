using System.Text;

string password = Console.ReadLine();

string input = Console.ReadLine();

StringBuilder updatePassword = new StringBuilder();

while (input != "Done")
{
    string[] command = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string currentCommand = command[0];

    if (currentCommand == "TakeOdd")
    {
        for (int i = 0; i < password.Length; i++)
        {
            if (i % 2 != 0)
            {
                updatePassword.Append(password[i]);
            }
        }
        password = updatePassword.ToString();
        Console.WriteLine(password);
    }
    else if (currentCommand == "Cut")
    {
        int index = int.Parse(command[1]);
        int length = int.Parse(command[2]);

        password = (password.Substring(0, index) + password.Substring(index + length));

        Console.WriteLine(password);
    }
    else if (currentCommand == "Substitute")
    {
        string substring = command[1];
        string substitute = command[2];

        if (password.Contains(substring))
        {
            password = password.Replace(substring, substitute);

            Console.WriteLine(password);
        }
        else
        {
            Console.WriteLine($"Nothing to replace!");
        }
    }

    input = Console.ReadLine();
}

Console.WriteLine($"Your password is: {password}");