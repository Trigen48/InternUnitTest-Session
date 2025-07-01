namespace Session1Library.Animals;

public class Snake : Animal
{
    public int Length { get; set; }

    public Snake(string name, int id, int length) : base(name, id, "Reptile")
    {
        Length = length;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Length: {Length} cm";
    }

    public override string MakeSound()
    {
        return "Hiss";
    }
}
