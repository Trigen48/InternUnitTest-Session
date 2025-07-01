namespace Session1Library.Animals;

/// <summary>
/// Represents a Shark, a type of Animal with properties like teeth count, swim speed, and depth range.
/// </summary>
public class Shark : Animal
{
    /// <summary>
    /// The number of teeth the shark has.
    /// </summary>
    public int TeethCount { get; set; }
    /// <summary>
    /// The swimming speed of the shark in km/h.
    /// </summary>
    public int SwimSpeed { get; set; }
    /// <summary>
    /// The depth range the shark can reach in meters.
    /// </summary>
    public int DepthRange { get; set; }

    /// <summary>
    /// Initializes a new instance of the Shark class.
    /// </summary>
    public Shark(string name, int id, int teethCount, int swimSpeed, int depthRange) : base(name, id, "Fish")
    {
        TeethCount = teethCount;
        SwimSpeed = swimSpeed;
        DepthRange = depthRange;
    }

    /// <summary>
    /// Calculates the swim distance based on hours.
    /// Equation: Swim Distance = SwimSpeed * hours
    /// </summary>
    public int CalculateSwimDistance(int hours)
    {
        return SwimSpeed * hours;
    }

    /// <summary>
    /// Gets a description of the shark including its unique properties.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Teeth Count: {TeethCount}, Swim Speed: {SwimSpeed} km/h, Depth Range: {DepthRange} meters";
    }

    /// <summary>
    /// Returns the sound a shark makes.
    /// </summary>
    public override string MakeSound()
    {
        return "Silent";
    }
}
