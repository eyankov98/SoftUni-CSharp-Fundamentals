string username = Console.ReadLine();

char[] cArray = username.ToCharArray();
string reverseUsername = String.Empty;
for (int i = cArray.Length - 1; i > -1; i--)
{
    reverseUsername += cArray[i];
}

Console.WriteLine(reverseUsername);