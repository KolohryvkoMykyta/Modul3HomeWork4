using System.Linq;
using Modul3HomeWork4;
using Modul3HomeWork4.Models;

var task1 = new Task1();

var result = task1.GetSum(4, 5);

Console.WriteLine($"Result for 1 task: {result}\n");

Console.WriteLine("2 Task: \n");
var contacts = PhoneBook.Contacts;
Console.WriteLine($"First contact with name 'Jack' {contacts.FirstOrDefault(c => c.Name == "Jack")}\n");
var namesForJohnson = contacts.Where(c => c.SurName == "Johnson").Select(c => c.Name);
Console.Write("Names of Johnsons:");

foreach (var name in namesForJohnson)
{
    Console.Write($" {name}");
}

Console.WriteLine("\n");

var namesInAlphabetOrder = namesForJohnson.OrderBy(n => n);
Console.Write("Names of Johnsons in alphabet order:");

foreach (var name in namesInAlphabetOrder)
{
    Console.Write($" {name}");
}

Console.WriteLine("\n");

Console.WriteLine($"Count of Johnsons: {namesForJohnson.Count()}\n");

var secondAndThird = namesInAlphabetOrder.Skip(1).Take(2).ToList();

Console.Write("Second and third Johnson in alphabetical order:");

foreach (var name in secondAndThird)
{
    Console.Write($" {name}");
}

Console.WriteLine();