public class Person
{
    public string Name { get; set; }
    public string[] Phone { get; set; }
    public Person()
    {

    }
    public Person(string name, string[] phone1)
    {
        Name = name;
        Phone = phone1;
    }
}