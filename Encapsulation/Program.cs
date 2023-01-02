Person person = new();
person.Name = "Mehmet Ali"; //privateName == "Mehmet Ali"
Console.WriteLine(person.Name);


class Person
{
    //Property Encapsulation

    string privateName;
    public string Name
    {
        get
        {
            return privateName;
        }
        set => privateName = value;
    }


}