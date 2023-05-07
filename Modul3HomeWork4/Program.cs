using Modul3HomeWork4.Models;

Contact[] contacts = PhoneBook.Contacts.ToArray();
Array.Sort(contacts);

foreach (var item in contacts)
{
    Console.WriteLine(item);
}

Console.ReadKey();