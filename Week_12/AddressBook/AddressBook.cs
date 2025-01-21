using System.Text.Json;

namespace AddressBook
{
    public class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            if (string.IsNullOrWhiteSpace(contact.Name) || string.IsNullOrWhiteSpace(contact.Email))
            {
                throw new InvalidContactException("All of the fields are required.");
            }

            contacts.Add(contact);
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }

        public void SaveToFile(string filePath)
        {
            var json = JsonSerializer.Serialize(contacts);
            File.WriteAllText(filePath, json);
        }

        public void LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                contacts = JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
            }
        }
    }
}
