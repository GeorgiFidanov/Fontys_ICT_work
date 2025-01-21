using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        private AddressBook addressBook = new AddressBook();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var contact = new Contact
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };

                addressBook.AddContact(contact);
                lstContacts.Items.Add($"{contact.Name} - {contact.Email} - {contact.PhoneNumber} - {contact.Address}" +
                    $" - {contact.City} - {contact.Country}");
            }
            catch (InvalidContactException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json",
                DefaultExt = "json"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                addressBook.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json",
                DefaultExt = "json"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                addressBook.LoadFromFile(openFileDialog.FileName);
                lstContacts.Items.Clear();
                foreach (var contact in addressBook.GetContacts())
                {
                    lstContacts.Items.Add($"{contact.Name} - {contact.Email} - {contact.PhoneNumber} - {contact.Address}" +
                    $" - {contact.City} - {contact.Country}");
                }
            }
        }
    }
}
