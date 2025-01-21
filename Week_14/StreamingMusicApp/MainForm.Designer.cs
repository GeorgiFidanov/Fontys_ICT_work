namespace StreamingMusicApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSongs;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabPlaylists;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ListBox lstPlaylists;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.Label lblPlaylistName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new System.Windows.Forms.TabControl();
            tabSongs = new System.Windows.Forms.TabPage();
            lstSongs = new System.Windows.Forms.ListBox();
            btnAddSong = new System.Windows.Forms.Button();
            txtArtist = new System.Windows.Forms.TextBox();
            txtTitle = new System.Windows.Forms.TextBox();
            txtDuration = new System.Windows.Forms.TextBox();
            cmbGenre = new System.Windows.Forms.ComboBox();
            lblArtist = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblDuration = new System.Windows.Forms.Label();
            lblGenre = new System.Windows.Forms.Label();
            tabUsers = new System.Windows.Forms.TabPage();
            lblEmail = new System.Windows.Forms.Label();
            lstUsers = new System.Windows.Forms.ListBox();
            btnAddUser = new System.Windows.Forms.Button();
            txtUserName = new System.Windows.Forms.TextBox();
            txtUserEmail = new System.Windows.Forms.TextBox();
            lblUserName = new System.Windows.Forms.Label();
            tabPlaylists = new System.Windows.Forms.TabPage();
            lstPlaylists = new System.Windows.Forms.ListBox();
            btnAddPlaylist = new System.Windows.Forms.Button();
            txtPlaylistName = new System.Windows.Forms.TextBox();
            lblPlaylistName = new System.Windows.Forms.Label();
            tabControl.SuspendLayout();
            tabSongs.SuspendLayout();
            tabUsers.SuspendLayout();
            tabPlaylists.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabSongs);
            tabControl.Controls.Add(tabUsers);
            tabControl.Controls.Add(tabPlaylists);
            tabControl.Location = new System.Drawing.Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(465, 426);
            tabControl.TabIndex = 0;
            // 
            // tabSongs
            // 
            tabSongs.BackColor = System.Drawing.Color.MediumSeaGreen;
            tabSongs.Controls.Add(lstSongs);
            tabSongs.Controls.Add(btnAddSong);
            tabSongs.Controls.Add(txtArtist);
            tabSongs.Controls.Add(txtTitle);
            tabSongs.Controls.Add(txtDuration);
            tabSongs.Controls.Add(cmbGenre);
            tabSongs.Controls.Add(lblArtist);
            tabSongs.Controls.Add(lblTitle);
            tabSongs.Controls.Add(lblDuration);
            tabSongs.Controls.Add(lblGenre);
            tabSongs.Location = new System.Drawing.Point(4, 24);
            tabSongs.Name = "tabSongs";
            tabSongs.Padding = new System.Windows.Forms.Padding(3);
            tabSongs.Size = new System.Drawing.Size(457, 398);
            tabSongs.TabIndex = 0;
            tabSongs.Text = "Songs";
            // 
            // lstSongs
            // 
            lstSongs.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lstSongs.FormattingEnabled = true;
            lstSongs.ItemHeight = 15;
            lstSongs.Location = new System.Drawing.Point(6, 6);
            lstSongs.Name = "lstSongs";
            lstSongs.Size = new System.Drawing.Size(439, 199);
            lstSongs.TabIndex = 0;
            // 
            // btnAddSong
            // 
            btnAddSong.BackColor = System.Drawing.SystemColors.ButtonShadow;
            btnAddSong.Location = new System.Drawing.Point(370, 288);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new System.Drawing.Size(75, 23);
            btnAddSong.TabIndex = 1;
            btnAddSong.Text = "Add Song";
            btnAddSong.UseVisualStyleBackColor = false;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // txtArtist
            // 
            txtArtist.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtArtist.Location = new System.Drawing.Point(6, 234);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new System.Drawing.Size(100, 23);
            txtArtist.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtTitle.Location = new System.Drawing.Point(112, 234);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(100, 23);
            txtTitle.TabIndex = 3;
            // 
            // txtDuration
            // 
            txtDuration.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtDuration.Location = new System.Drawing.Point(218, 234);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new System.Drawing.Size(100, 23);
            txtDuration.TabIndex = 4;
            txtDuration.KeyPress += txtDuration_KeyPress;
            // 
            // cmbGenre
            // 
            cmbGenre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new System.Drawing.Point(324, 234);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new System.Drawing.Size(121, 23);
            cmbGenre.TabIndex = 5;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new System.Drawing.Point(6, 216);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new System.Drawing.Size(35, 15);
            lblArtist.TabIndex = 6;
            lblArtist.Text = "Artist";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(112, 216);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(29, 15);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Title";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new System.Drawing.Point(218, 216);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new System.Drawing.Size(53, 15);
            lblDuration.TabIndex = 8;
            lblDuration.Text = "Duration";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new System.Drawing.Point(324, 216);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new System.Drawing.Size(38, 15);
            lblGenre.TabIndex = 9;
            lblGenre.Text = "Genre";
            // 
            // tabUsers
            // 
            tabUsers.BackColor = System.Drawing.Color.MediumSeaGreen;
            tabUsers.Controls.Add(lblEmail);
            tabUsers.Controls.Add(lstUsers);
            tabUsers.Controls.Add(btnAddUser);
            tabUsers.Controls.Add(txtUserName);
            tabUsers.Controls.Add(txtUserEmail);
            tabUsers.Controls.Add(lblUserName);
            tabUsers.Location = new System.Drawing.Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new System.Windows.Forms.Padding(3);
            tabUsers.Size = new System.Drawing.Size(457, 398);
            tabUsers.TabIndex = 1;
            tabUsers.Text = "Users";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(112, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lstUsers
            // 
            lstUsers.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 15;
            lstUsers.Location = new System.Drawing.Point(6, 6);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new System.Drawing.Size(440, 199);
            lstUsers.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            btnAddUser.Location = new System.Drawing.Point(371, 234);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new System.Drawing.Size(75, 23);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtUserName.Location = new System.Drawing.Point(6, 234);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(100, 23);
            txtUserName.TabIndex = 2;
            // 
            // txtUserEmail
            // 
            txtUserEmail.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtUserEmail.Location = new System.Drawing.Point(112, 235);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new System.Drawing.Size(100, 23);
            txtUserEmail.TabIndex = 3;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new System.Drawing.Point(6, 216);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(65, 15);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "User Name";
            // 
            // tabPlaylists
            // 
            tabPlaylists.BackColor = System.Drawing.Color.MediumSeaGreen;
            tabPlaylists.Controls.Add(lstPlaylists);
            tabPlaylists.Controls.Add(btnAddPlaylist);
            tabPlaylists.Controls.Add(txtPlaylistName);
            tabPlaylists.Controls.Add(lblPlaylistName);
            tabPlaylists.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            tabPlaylists.Location = new System.Drawing.Point(4, 24);
            tabPlaylists.Name = "tabPlaylists";
            tabPlaylists.Padding = new System.Windows.Forms.Padding(3);
            tabPlaylists.Size = new System.Drawing.Size(457, 398);
            tabPlaylists.TabIndex = 2;
            tabPlaylists.Text = "Playlists";
            // 
            // lstPlaylists
            // 
            lstPlaylists.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lstPlaylists.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lstPlaylists.FormattingEnabled = true;
            lstPlaylists.ItemHeight = 15;
            lstPlaylists.Location = new System.Drawing.Point(6, 6);
            lstPlaylists.Name = "lstPlaylists";
            lstPlaylists.Size = new System.Drawing.Size(445, 199);
            lstPlaylists.TabIndex = 0;
            // 
            // btnAddPlaylist
            // 
            btnAddPlaylist.BackColor = System.Drawing.SystemColors.ButtonShadow;
            btnAddPlaylist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAddPlaylist.Location = new System.Drawing.Point(376, 234);
            btnAddPlaylist.Name = "btnAddPlaylist";
            btnAddPlaylist.Size = new System.Drawing.Size(75, 23);
            btnAddPlaylist.TabIndex = 1;
            btnAddPlaylist.Text = "Add Playlist";
            btnAddPlaylist.UseVisualStyleBackColor = false;
            btnAddPlaylist.Click += btnAddPlaylist_Click;
            // 
            // txtPlaylistName
            // 
            txtPlaylistName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtPlaylistName.Location = new System.Drawing.Point(6, 234);
            txtPlaylistName.Name = "txtPlaylistName";
            txtPlaylistName.Size = new System.Drawing.Size(100, 23);
            txtPlaylistName.TabIndex = 2;
            // 
            // lblPlaylistName
            // 
            lblPlaylistName.AutoSize = true;
            lblPlaylistName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblPlaylistName.Location = new System.Drawing.Point(6, 216);
            lblPlaylistName.Name = "lblPlaylistName";
            lblPlaylistName.Size = new System.Drawing.Size(79, 15);
            lblPlaylistName.TabIndex = 3;
            lblPlaylistName.Text = "Playlist Name";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(481, 450);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Streaming Music Service";
            tabControl.ResumeLayout(false);
            tabSongs.ResumeLayout(false);
            tabSongs.PerformLayout();
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            tabPlaylists.ResumeLayout(false);
            tabPlaylists.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblEmail;
    }
}
