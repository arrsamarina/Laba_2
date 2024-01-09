using Laba_2;
using Laba_2.View;

public class Program
{
    public static void Main(String[] args)
    {
        View v = new View(new MusicCatalog());
        v.start();
    }
}