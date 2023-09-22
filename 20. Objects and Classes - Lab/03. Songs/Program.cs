int n = int.Parse(Console.ReadLine());

List<Song> songs = new List<Song>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split("_")
        .ToArray();

    string typeList = input[0];
    string songName = input[1];
    string duration = input[2];

    Song song = new Song
    {
        TypeList = typeList,
        Name = songName,
        Time = duration
    };

    songs.Add(song);
}

string searchForTypeList = Console.ReadLine();

if (searchForTypeList == "all")
{
    // var searchSongs = songs.Select(x => x.Name);
    // Console.WriteLine(string.Join(" ", searchSongs));
    foreach (var song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    // var searchSongs = songs.where(x => x.TypeList == searchForTypeList).Select(x => x.Name);
    // Console.WriteLine(string.Join(" ", searchSongs));
    foreach (var song in songs)
    {
        if (song.TypeList == searchForTypeList)
        {
            Console.WriteLine(song.Name);
        }
    }
}
public class Song
{
    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}