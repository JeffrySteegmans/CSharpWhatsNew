var person = new Person
{
    Name = "John Doe",
    Address = new Address
    {
        Street = "Example street"
    }
};

if (person is Person { Address.Street: "Example street" })
{
    Console.WriteLine(person.Name);
}

class Person
{
    public string Name { get; set; }
    public Address Address { get; set; }
}

class Address
{
    public string Street { get; set; }
}
