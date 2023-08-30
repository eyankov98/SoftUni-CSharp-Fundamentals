string password = Console.ReadLine();

string passwordReverse = string.Empty;

int countWrongPassword = 0;

while (password != passwordReverse)
{
    passwordReverse = string.Empty;
    string passwordRepeat = Console.ReadLine();

    for (int i = passwordRepeat.Length - 1; i >= 0; i--)
    {
        passwordReverse = passwordReverse + passwordRepeat[i];
    }

    if (passwordReverse != password)
    {
        Console.WriteLine("Incorrect password. Try again.");

        countWrongPassword++;

        if (countWrongPassword == 3)
        {
            Console.WriteLine($"User {password} blocked!");
            return;
        }
    }
}

Console.WriteLine($"User {password} logged in.");