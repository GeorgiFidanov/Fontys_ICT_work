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
            button1 = new System.Windows.Forms.Button();
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
            tabControl.Location = new System.Drawing.Point(14, 16);
            tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(531, 568);
            tabControl.TabIndex = 0;
            // 
            // tabSongs
            // 
            tabSongs.BackColor = System.Drawing.Color.MediumSeaGreen;
            tabSongs.Controls.Add(button1);
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
            tabSongs.Location = new System.Drawing.Point(4, 29);
            tabSongs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabSongs.Name = "tabSongs";
            tabSongs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabSongs.Size = new System.Drawing.Size(523, 535);
            tabSongs.TabIndex = 0;
            tabSongs.Text = "Songs";
            // 
            // lstSongs
            // 
            lstSongs.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lstSongs.FormattingEnabled = true;
            lstSongs.ItemHeight = 20;
            lstSongs.Location = new System.Drawing.Point(7, 8);
            lstSongs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstSongs.Name = "lstSongs";
            lstSongs.Size = new System.Drawing.Size(501, 264);
            lstSongs.TabIndex = 0;
            // 
            // btnAddSong
            // 
            btnAddSong.BackColor = System.Drawing.SystemColors.ButtonShadow;
            btnAddSong.Location = new System.Drawing.Point(423, 384);
            btnAddSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new System.Drawing.Size(86, 31);
            btnAddSong.TabIndex = 1;
            btnAddSong.Text = "Add Song";
            btnAddSong.UseVisualStyleBackColor = false;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // txtArtist
            // 
            txtArtist.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtArtist.Location = new System.Drawing.Point(7, 312);
            txtArtist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "e.g. 'Mac Miller'";
            txtArtist.Size = new System.Drawing.Size(114, 27);
            txtArtist.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtTitle.Location = new System.Drawing.Point(128, 312);
            txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "e.g. 'Blue World'";
            txtTitle.Size = new System.Drawing.Size(114, 27);
            txtTitle.TabIndex = 3;
            // 
            // txtDuration
            // 
            txtDuration.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtDuration.Location = new System.Drawing.Point(249, 312);
            txtDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDuration.Name = "txtDuration";
            txtDuration.PlaceholderText = "in 'seconds'";
            txtDuration.Size = new System.Drawing.Size(114, 27);
            txtDuration.TabIndex = 4;
            txtDuration.KeyPress += txtDuration_KeyPress;
            // 
            // cmbGenre
            // 
            cmbGenre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new System.Drawing.Point(370, 312);
            cmbGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new System.Drawing.Size(138, 28);
            cmbGenre.TabIndex = 5;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new System.Drawing.Point(7, 288);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new System.Drawing.Size(44, 20);
            lblArtist.TabIndex = 6;
            lblArtist.Text = "Artist";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(128, 288);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(38, 20);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Title";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new System.Drawing.Point(249, 288);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new System.Drawing.Size(67, 20);
            lblDuration.TabIndex = 8;
            lblDuration.Text = "Duration";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new System.Drawing.Point(370, 288);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new System.Drawing.Size(48, 20);
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
            tabUsers.Location = new System.Drawing.Point(4, 29);
            tabUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabUsers.Size = new System.Drawing.Size(523, 535);
            tabUsers.TabIndex = 1;
            tabUsers.Text = "Users";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(128, 288);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lstUsers
            // 
            lstUsers.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 20;
            lstUsers.Location = new System.Drawing.Point(7, 8);
            lstUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new System.Drawing.Size(502, 264);
            lstUsers.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            btnAddUser.Location = new System.Drawing.Point(424, 312);
            btnAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new System.Drawing.Size(86, 31);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtUserName.Location = new System.Drawing.Point(7, 312);
            txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(114, 27);
            txtUserName.TabIndex = 2;
            // 
            // txtUserEmail
            // 
            txtUserEmail.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtUserEmail.Location = new System.Drawing.Point(128, 313);
            txtUserEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new System.Drawing.Size(114, 27);
            txtUserEmail.TabIndex = 3;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new System.Drawing.Point(7, 288);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(82, 20);
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
            tabPlaylists.Location = new System.Drawing.Point(4, 29);
            tabPlaylists.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPlaylists.Name = "tabPlaylists";
            tabPlaylists.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPlaylists.Size = new System.Drawing.Size(523, 535);
            tabPlaylists.TabIndex = 2;
            tabPlaylists.Text = "Playlists";
            // 
            // lstPlaylists
            // 
            lstPlaylists.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lstPlaylists.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lstPlaylists.FormattingEnabled = true;
            lstPlaylists.ItemHeight = 20;
            lstPlaylists.Location = new System.Drawing.Point(7, 8);
            lstPlaylists.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstPlaylists.Name = "lstPlaylists";
            lstPlaylists.Size = new System.Drawing.Size(508, 264);
            lstPlaylists.TabIndex = 0;
            // 
            // btnAddPlaylist
            // 
            btnAddPlaylist.BackColor = System.Drawing.SystemColors.ButtonShadow;
            btnAddPlaylist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAddPlaylist.Location = new System.Drawing.Point(430, 312);
            btnAddPlaylist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddPlaylist.Name = "btnAddPlaylist";
            btnAddPlaylist.Size = new System.Drawing.Size(86, 31);
            btnAddPlaylist.TabIndex = 1;
            btnAddPlaylist.Text = "Add Playlist";
            btnAddPlaylist.UseVisualStyleBackColor = false;
            btnAddPlaylist.Click += btnAddPlaylist_Click;
            // 
            // txtPlaylistName
            // 
            txtPlaylistName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            txtPlaylistName.Location = new System.Drawing.Point(7, 312);
            txtPlaylistName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPlaylistName.Name = "txtPlaylistName";
            txtPlaylistName.Size = new System.Drawing.Size(114, 27);
            txtPlaylistName.TabIndex = 2;
            // 
            // lblPlaylistName
            // 
            lblPlaylistName.AutoSize = true;
            lblPlaylistName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblPlaylistName.Location = new System.Drawing.Point(7, 288);
            lblPlaylistName.Name = "lblPlaylistName";
            lblPlaylistName.Size = new System.Drawing.Size(99, 20);
            lblPlaylistName.TabIndex = 3;
            lblPlaylistName.Text = "Playlist Name";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(180, 399);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(550, 600);
            Controls.Add(tabControl);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button button1;
    }
}
