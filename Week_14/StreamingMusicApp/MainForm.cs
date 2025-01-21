using System;
using System.Linq;
using System.Windows.Forms;

namespace StreamingMusicApp
{
    public partial class MainForm : Form
    {
        private StreamingMusicService streamingMusicService;

        public MainForm()
        {
            InitializeComponent();
            streamingMusicService = new StreamingMusicService("YoMusicfy");
            InitializeGenreDropdown();
            UpdateSongList();
            UpdateUserList();
        }

        private void InitializeGenreDropdown()
        {
            cmbGenre.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDuration.Text, out int duration))
            {
                string artist = txtArtist.Text;
                string title = txtTitle.Text;
                Genre genre = (Genre)cmbGenre.SelectedItem;
                streamingMusicService.AddSong(artist, title, duration, genre);
                UpdateSongList();
            }
            else
            {
                MessageBox.Show("Please enter a valid duration.");
            }
        }

        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateSongList()
        {
            lstSongs.Items.Clear();
            foreach (var song in streamingMusicService.GetSongs())
            {
                lstSongs.Items.Add(song.GetInfo());
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userEmail = txtUserEmail.Text;
            streamingMusicService.AddUser(userName, userEmail);
            UpdateUserList();
        }

        private void UpdateUserList()
        {
            lstUsers.Items.Clear();
            foreach (var user in streamingMusicService.GetUsers())
            {
                lstUsers.Items.Add(user.GetName());
            }
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            string playlistName = txtPlaylistName.Text;
            if (lstUsers.SelectedItem != null)
            {
                User selectedUser = streamingMusicService.GetUser(lstUsers.SelectedItem.ToString());
                selectedUser.AddPlaylist(playlistName);
                UpdatePlaylistList(selectedUser);
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private void UpdatePlaylistList(User user)
        {
            lstPlaylists.Items.Clear();
            foreach (var playlist in user.GetPlaylistsInfo().Split('\n'))
            {
                lstPlaylists.Items.Add(playlist);
            }
        }
        private TextBox txtUserEmail;
    }
}
