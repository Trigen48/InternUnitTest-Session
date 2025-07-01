namespace Session1Library.Animals;

public class Horse : Animal
{
    public int Speed { get; set; }

    public Horse(string name, int id, int speed) : base(name, id, "Mammal")
    {
        Speed = speed;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Speed: {Speed} km/h";
    }

    public int CalculateDistance(int hours)
    {
        return Speed * hours;
    }

    public override string MakeSound()
    {
        return "Neigh";
    }
}
