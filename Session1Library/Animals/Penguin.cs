namespace Session1Library.Animals;

public class Penguin : Animal
{
    public bool CanSwim { get; set; }
    public int SwimSpeed { get; set; }
    public int DiveDepth { get; set; }

    public Penguin(string name, int id, bool canSwim, int swimSpeed, int diveDepth) : base(name, id, "Bird")
    {
        CanSwim = canSwim;
        SwimSpeed = swimSpeed;
        DiveDepth = diveDepth;
    }

    public int CalculateDiveDistance(int hours)
    {
        return SwimSpeed * hours;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Can Swim: {CanSwim}, Swim Speed: {SwimSpeed} km/h, Dive Depth: {DiveDepth} meters";
    }

    public override string MakeSound()
    {
        return "Honk";
    }
}
