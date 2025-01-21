namespace AddressBook
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lstContacts;

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btnAdd = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            lstContacts = new ListBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 16);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(228, 27);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 55);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(228, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(14, 93);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(228, 27);
            txtPhoneNumber.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(14, 132);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(228, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(14, 171);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.Size = new Size(228, 27);
            txtCity.TabIndex = 4;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(14, 209);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.PlaceholderText = "Country";
            txtCountry.Size = new Size(228, 27);
            txtCountry.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 248);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 31);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(85, 248);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(73, 31);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(164, 248);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(78, 31);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lstContacts
            // 
            lstContacts.FormattingEnabled = true;
            lstContacts.Location = new Point(257, 16);
            lstContacts.Margin = new Padding(3, 4, 3, 4);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(453, 264);
            lstContacts.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 296);
            Controls.Add(lstContacts);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
