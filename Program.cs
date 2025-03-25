using System;

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Bagus Hardiyanto");

            for (int i = 1; i <= 10; i++)
            {
                SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Bagus Hardiyanto");
                video.IncreasePlayCount(100000);
                user.AddVideo(video);
            }

            user.PrintAllVideoPlaycount();
            Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

}
