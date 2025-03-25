using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (title == null) throw new ArgumentNullException("Judul video tidak boleh null.");
        if (title.Length > 200) throw new ArgumentException("Judul video tidak boleh lebih dari 200 karakter.");

        this.id = new Random().Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0) throw new ArgumentException("Play count tidak boleh negatif.");
        if (count > 25000000) throw new ArgumentException("Play count maksimal per penambahan adalah 25.000.000.");

        checked 
        {
            playCount += count;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    public int GetPlayCount()
    {
        return playCount;
    }

}
