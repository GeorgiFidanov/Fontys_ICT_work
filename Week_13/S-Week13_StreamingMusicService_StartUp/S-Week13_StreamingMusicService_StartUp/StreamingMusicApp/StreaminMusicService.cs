using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class StreamingMusicService
    {
        private int songIdSeeder;
        private string name;
        private List<Song> songs;
        private List<User> users;

        public StreamingMusicService(string name)
        {
            this.songIdSeeder = 1;
            this.name = name;
            this.songs = new List<Song>();
            this.users = new List<User>();
        }

        public void AddSong(string artist, string title, int durationInSeconds, Genre genre)
        {
            this.songs.Add(new Song(this.songIdSeeder, artist, title, durationInSeconds, genre));
            this.songIdSeeder++;
        }

        public Song GetSong(int id)
        {
            return this.songs.FirstOrDefault(s => s.GetId() == id);
        }

        public Song[] GetSongs()
        {
            return this.songs.ToArray();
        }

        public Song[] GetSongs(string artist)
        {
            return this.songs.Where(s => s.GetArtist() == artist).ToArray();
        }

        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({this.songs.Count} songs & {this.users.Count} users)";
        }

        public void AddUser(string name, string email)
        {
            this.users.Add(new User(name, email));
        }

        public User GetUser(string name)
        {
            return this.users.FirstOrDefault(u => u.GetName() == name);
        }

        public User[] GetUsers()
        {
            return this.users.ToArray();
        }
    }
    public enum Genre
    {
        Pop,
        Rock,
        Jazz,
        Classical,
        HipHop,
        Country,
        Electronic,
        Other
    }
}
