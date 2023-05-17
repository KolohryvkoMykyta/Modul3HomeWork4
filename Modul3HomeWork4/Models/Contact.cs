namespace Modul3HomeWork4.Models
{
    public class Contact : IComparable
    {
        private const string Gmail = "@gmail.com";

        public Contact(string name, string surName, string phoneNumber)
        {
            Name = name;
            SurName = surName;
            Email = surName + Gmail;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }

        public int CompareTo(object? obj)
        {
            if (obj is not Contact contact)
            {
                throw new ArgumentException("Incorrect parameter value");
            }

            int result = Name.CompareTo(contact.Name);

            if (result != 0)
            {
                return result;
            }
            else
            {
                return SurName.CompareTo(contact.SurName);
            }
        }

        public override string ToString()
        {
            return $"{Name} {SurName} {PhoneNumber} {Email}";
        }
    }
}
