using System.Text;

namespace Modul3HomeWork4.Models
{
    public static class PhoneBook
    {
        private static readonly string[] _namesList = new string[]
        {
            "Harry", "Oliver", "Jack", "Charlie", "Thomas", "Jacob", "Alfie", "Riley", "William", "James", "Amelia", "Daniel ", "Ethan", "Matthew", "Ryen", "Noah", "Lewis",
            "Olivia", "Jessica", "Emily", "Lily", "Ava", "Heather", "Sophie", "Mia", "Isabella", "Grace", "Lucy", "Katie", "Eva", "Aoife", "Ruby", "Seren", "Ella", "Isla"
        };
        private static readonly string[] _surnamesList = new string[]
        {
            "Abramson", "Adamson", "Andrews", "Barnes", "Benson", "Black", "Brown", "Campbell", "Carrington", "Chapman", "Clifford", "Davidson", "Derrick", "Dyson", "Eddington",
            "Edwards", "Erickson", "Farmer", "Finch", "Fisher", "Ford", "Garrison", "Gibbs", "Goodman", "Hancock", "Harrison", "Hawkins", "Holmes", "Howard", "Jacobson",
            "James", "Jenkin", "Johnson", "Kendal", "Kennedy", "Kingsman", "Little", "MacAlister", "MacDonald", "Miller", "Murphy", "Nelson", "Page", "Philips", "Roger"
        };

        static PhoneBook()
        {
            for (int i = 0; i < 500; i++)
            {
                Contacts.Add(new Contact(GetRandomName(), GetRandomSurname(), GetRandomPhoneNumber()));
            }
        }

        public static List<Contact> Contacts { get; set; } = new List<Contact>();

        private static string GetRandomName()
        {
            return _namesList[new Random().Next(_namesList.Length)];
        }

        private static string GetRandomSurname()
        {
            return _surnamesList[new Random().Next(_surnamesList.Length)];
        }

        private static string GetRandomPhoneNumber()
        {
            var builder = new StringBuilder("+44");
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                builder.Append(random.Next(10));
            }

            return builder.ToString();
        }
    }
}
