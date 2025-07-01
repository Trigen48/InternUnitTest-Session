namespace Session1Library.Animals;

/// <summary>
/// Represents a Penguin, a type of Animal with properties like swimming ability, swim speed, and dive depth.
/// </summary>
public class Penguin : Animal
{
    /// <summary>
    /// Indicates if the penguin can swim.
    /// </summary>
    public bool CanSwim { get; set; }
    /// <summary>
    /// The swimming speed of the penguin in km/h.
    /// </summary>
    public int SwimSpeed { get; set; }
    /// <summary>
    /// The dive depth of the penguin in meters.
    /// </summary>
    public int DiveDepth { get; set; }

    /// <summary>
    /// Initializes a new instance of the Penguin class.
    /// </summary>
    public Penguin(string name, int id, bool canSwim, int swimSpeed, int diveDepth) : base(name, id, "Bird")
    {
        CanSwim = canSwim;
        SwimSpeed = swimSpeed;
        DiveDepth = diveDepth;
    }

    /// <summary>
    /// Calculates the dive distance based on hours.
    /// Equation: Dive Distance = SwimSpeed * hours
    /// </summary>
    public int CalculateDiveDistance(int hours)
    {
        return SwimSpeed * hours;
    }

    /// <summary>
    /// Gets a description of the penguin including its unique properties.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Can Swim: {CanSwim}, Swim Speed: {SwimSpeed} km/h, Dive Depth: {DiveDepth} meters";
    }

    /// <summary>
    /// Returns the sound a penguin makes.
    /// </summary>
    public override string MakeSound()
    {
        return "Honk";
    }
}
