using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class Playlist
    {
        private string name;
        private List<Song> songs;

        public Playlist(string name)
        {
            this.name = name;
            this.songs = new List<Song>();
        }

        public string GetName() => name;

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            songs.Remove(song);
        }

        public string GetPlaylistInfo()
        {
            if (songs.Count == 0)
            {
                return $"{name} has no songs";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Playlist: {name}");
            foreach (var song in songs)
            {
                sb.AppendLine($"- ID {song.GetId():D2}: {song.GetInfo()}");
            }
            return sb.ToString();
        }
    }
}
