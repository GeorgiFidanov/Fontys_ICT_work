using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace StreamingMusicApp
{
    public class User
    {
        private const int MAX_SONGS_IN_FAVORITES = 50;
        private string name;
        private string email;
        private string address;
        private List<Song> favoriteSongs;
        private List<Playlist> playlists;

        public User(string name, string email)
        {
            this.name = name;
            this.email = email;
            this.favoriteSongs = new List<Song>();
            this.playlists = new List<Playlist>();
        }

        public User(string name, string email, string address)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            this.favoriteSongs = new List<Song>();
            this.playlists = new List<Playlist>();
        }


        public string GetName() => name;

        public void AddSongToFavorites(Song song)
        {
            if (favoriteSongs.Count < MAX_SONGS_IN_FAVORITES)
            {
                favoriteSongs.Add(song);
            }
        }

        public void RemoveSongFromFavorites(Song song)
        {
            favoriteSongs.Remove(song);
        }

        public string GetFavoriteSongs()
        {
            if (favoriteSongs.Count == 0)
            {
                return $"{name} has no favorite songs";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Favorite songs of {name}:");
            foreach (var song in favoriteSongs)
            {
                sb.AppendLine($"- ID {song.GetId():D2}: {song.GetInfo()}");
            }
            return sb.ToString();
        }

        public void AddPlaylist(Playlist playlist)
        {
            playlists.Add(playlist);
        }

        public Playlist GetPlaylist(string playlistName)
        {
            return playlists.FirstOrDefault(p => p.GetName() == playlistName);
        }

        public string GetPlaylistsInfo()
        {
            if (playlists.Count == 0)
            {
                return $"{name} has no playlists";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Playlists of {name}:");
            foreach (var playlist in playlists)
            {
                sb.AppendLine(playlist.GetPlaylistInfo());
            }
            return sb.ToString();
        }
    }
}
