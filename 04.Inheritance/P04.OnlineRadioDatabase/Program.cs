using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private const int MaxSongLengthSeconds = 899;

    static void Main() //87/100
    {
        var songs = new List<Song>();

        int numberSongs = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberSongs; i++)
        {
            var input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            if (input.Length != 3 && input[2].Split(':').Length != 2)
            {
                Console.WriteLine("Invalid song.");
                continue;
            }
                       
            try
            {
                string artistName = input[0];
                string songName = input[1];
                string[] songLength = input[2].Split(':');

                int minutes;
                int seconds;
                if (int.TryParse(songLength[0], out minutes) && int.TryParse(songLength[1], out seconds))
                {
                    var song = new Song(artistName, songName, minutes, seconds);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                else
                {
                    Console.WriteLine("Invalid song length."); 
                    continue;
                    
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine($"Songs added: {songs.Count}");
       
        var totalTimeInSeconds = songs.Sum(s => s.Seconds) + songs.Sum(s => s.Minutes) * 60;
        int totalMinutes = totalTimeInSeconds / 60;
        int totalSeconds = totalTimeInSeconds % 60;
        int totaHours = totalMinutes / 60;
        totalMinutes = totalMinutes % 60;

        Console.WriteLine($"Playlist length: {totaHours}h {totalMinutes}m {totalSeconds}s");
    }
}

