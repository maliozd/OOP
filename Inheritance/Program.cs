public class Cat
{
    public bool Tired { get; set; } = false;
    public bool Hungry { get; set; } = false;
    public double Weight { get; set; }
    public string Family { get; } = "Felidae";

    public Cat(double weight)
    {
        Weight = weight;
    }

    // On this line, add a no-argument constructor

    public void Sleep()
    {
        Tired = false;
        Hungry = true;
    }

    public void Eat()
    {
        if (!Hungry)
        {
            Tired = true;
        }

        Hungry = false;
    }

    public virtual string Noise()
    {
        return "Meow!";
    }
}

public class Scottish : Cat
{
    public string Name { get; set; }
    public string Species { get; } = "Felis catus";


    public Scottish(string name, double weight) : base(weight)
    {
        Name = name;
    }

    // On this line, write a constructor that uses the no-arg constructor in the Cat class.
    public bool IsSatisfied()
    {
        return !Hungry && !Tired;
    }
    public override string Noise()
    {
        return "Hello, my name is " + Name + "!";
    }

    public string Purr()
    {
        return "I'm a housecat";
    }
}