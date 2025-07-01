namespace Session1Library.Animals;

public class Shark : Animal
{
    public int TeethCount { get; set; }
    public int SwimSpeed { get; set; }
    public int DepthRange { get; set; }

    public Shark(string name, int id, int teethCount, int swimSpeed, int depthRange) : base(name, id, "Fish")
    {
        TeethCount = teethCount;
        SwimSpeed = swimSpeed;
        DepthRange = depthRange;
    }

    public int CalculateSwimDistance(int hours)
    {
        return SwimSpeed * hours;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Teeth Count: {TeethCount}, Swim Speed: {SwimSpeed} km/h, Depth Range: {DepthRange} meters";
    }

    public override string MakeSound()
    {
        return "Silent";
    }
}
