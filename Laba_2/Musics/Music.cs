namespace Laba_2;

public class Music
{
    public string authorName { get; set; }
    public string compositionName { get; set; }

    public Music()
    {
        Console.WriteLine("Введите имя автора:");
        authorName = Console.ReadLine();
        Console.WriteLine("Введите название композиции:");
        compositionName = Console.ReadLine();
    }
    public Music(string authorName, string compositionName)
    {
        this.authorName = authorName;
        this.compositionName = compositionName;
    }
    public string getMusic()
    {
        return $"{authorName} - {compositionName}";
    }
}
