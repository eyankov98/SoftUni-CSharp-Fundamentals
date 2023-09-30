char[] text = Console.ReadLine().ToCharArray();

List<char> encryptedText = new List<char>();

for (int i = 0; i < text.Length; i++)
{
    int currEncryptedCharValue = text[i] + 3;
    encryptedText.Add((char)currEncryptedCharValue);

    Console.Write(encryptedText[i]);
}