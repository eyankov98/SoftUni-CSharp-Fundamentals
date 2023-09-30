using System.Text;

StringBuilder currentString = new StringBuilder();
currentString.Append(Console.ReadLine());

int power = 0;

for (int i = 0; i < currentString.Length; i++)
{
    if (power == 0)
    {
        if (currentString[i] == '>')
        {
            power += int.Parse(currentString[i + 1].ToString());
        }
    }
    else
    {
        if (currentString[i] == '>')
        {
            power += int.Parse(currentString[i + 1].ToString());
        }
        else
        {
            currentString.Remove(i, 1);
            i--;
            power--;
        }
    }
}

Console.WriteLine(currentString);