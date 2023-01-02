//MyClass class1 = new()
//{
//    Property = 5
//};
//class1.Property = 53;
//Console.Write(class1.Property);

#region Init-Only Properties 
class MyClass
{
    public int Property { get; init; } = 3;
}
#endregion

#region Records 
/*While records can be mutable, the new reference type is primarily intended to be used with immutable data models. It has the following key features:
Positional syntax for creating a reference type with immutable properties
Built-in formatting for display
Value-based equality
Non-destructive mutation with a concise syntax
Support for inheritance hierarchies
The declaration syntax of a record type is very similar to the one used by a class, except for the declaration keyword
*/
public record Pet
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public record Pet1
{
    public string Name { get; init; }
    public int Age { get; init; }
}

//Declaring a record type with positional parameters

public record Pet2(string name, int age);

public record Pet3(string name, int age)
{
    public string Color { get; init; }
}
//var dog = new Pet3("Cookie", 7) { Color = “Brown”};


/*
 * Inheritance
A record can inherit from another record. However, a record can't inherit from a class, and a class can't inherit from a record.

Example 14: Inheriting a record type
*/
public record Animal(string name, int age);
public record Cat(string name, int age, string color) : Animal(name, age);
//var cat = new Cat("Cookie", 7, “Brown”);

#endregion