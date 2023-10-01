using System.Text;

int namesCount = int.Parse(Console.ReadLine());

Dictionary<StringBuilder, StringBuilder> names = new Dictionary<StringBuilder, StringBuilder>();

for (int k = 0; k < namesCount; k++)
{
    string personInfo = Console.ReadLine();

    StringBuilder name = new StringBuilder();
    StringBuilder age = new StringBuilder();

    int startName = personInfo.IndexOf('@');
    int endName = personInfo.IndexOf('|');

    int startAge = personInfo.IndexOf('#');
    int endAge = personInfo.IndexOf('*');

    for (int i = startName + 1; i < endName; i++)
    {
        name.Append(personInfo[i]);
    }

    for (int j = startAge + 1; j < endAge; j++)
    {
        age.Append(personInfo[j]);
    }

    names.Add(name, age);
}

foreach (var person in names)
{
    Console.WriteLine($"{person.Key} is {person.Value} years old.");
}