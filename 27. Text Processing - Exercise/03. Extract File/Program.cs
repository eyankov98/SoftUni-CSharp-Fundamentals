string[] fileLocation = Console.ReadLine().Split(@"\");

string[] nameAndExtension = fileLocation[fileLocation.Length - 1].Split(".");
string fileName = nameAndExtension[0];
string fileExtension = nameAndExtension[1];

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");