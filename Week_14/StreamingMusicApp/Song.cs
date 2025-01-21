using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class Song
    {
        private int id;
        private string artist;
        private string title;        
        private int durationInSeconds;
        private Genre genre;

        public Song(int id, string artist, string title, int durationInSeconds, Genre genre)
        {
            this.id = id;
            this.artist = artist;
            this.title = title;
            this.durationInSeconds = durationInSeconds;
            this.genre = genre;
        }

        public int GetId() => id;
        public string GetArtist() => artist;
        public string GetInfo()
        {
            int minutes = durationInSeconds / 60;
            int seconds = durationInSeconds % 60;
            return $"{artist} - {title} ({minutes}:{seconds:D2})";
        }
        public Genre GetGenre() => genre;
    }
}
