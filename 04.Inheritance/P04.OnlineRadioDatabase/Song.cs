using System;
using System.Collections.Generic;
using System.Text;

public class Song
{
    private const int MaxSongLengthSeconds = 899;

    private string artistName;
    private string songName;
    private int seconds;
    private int minutes;

    public Song(string artistName, string sondName, int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = artistName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }

    public string ArtistName
    {
        get { return artistName; }
        set
        {
            if (value.Length > 20 || value.Length < 3)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            artistName = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length > 30 || value.Length < 3)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            songName = value;
        }
    }

    public int Minutes
    {
        get { return this.minutes; }
        set
        {
            //if (value * 60 + this.Seconds < 0 || value * 60 + Seconds > MaxSongLengthSeconds)
            //{
            //    throw new ArgumentException("Invalid song length.");
            //}
            if (value < 0 || value > 14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            this.minutes = value;
        }
    }

    public int Seconds
    {
        get { return this.seconds; }
        set
        {
            //if (Minutes * 60 + value < 0 || Minutes * 60 + value > MaxSongLengthSeconds)
            //{
            //    throw new ArgumentException("Invalid song length.");
            //}
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }
            this.seconds = value;
        }
    }


    

}

