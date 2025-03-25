using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username { get; private set; }

    public SayaTubeUser(string username)
    {
        if (username == null) throw new ArgumentNullException("Username tidak boleh null.");
        if (username.Length > 100) throw new ArgumentException("Username tidak boleh lebih dari 100 karakter.");

        this.id = new Random().Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null) throw new ArgumentNullException("Video yang ditambahkan tidak boleh null.");
        if (video.GetPlayCount() > int.MaxValue) throw new OverflowException("Play count melebihi batas integer.");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < Math.Min(uploadedVideos.Count, 8); i++) 
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetPlayCount()}");
        }
    }

}
