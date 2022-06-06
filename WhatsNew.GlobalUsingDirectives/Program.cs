using WhatsNew.GlobalUsingDirectives.Models;

var persons = new List<Person>
{
    new Person("John", "doe"),
    new Person("Joe", "Doe"),
    new Person("Jake", "Doe"),
};

foreach (var firstName in persons.Select(x => x.FirstName))
{
    Console.WriteLine(firstName);
}