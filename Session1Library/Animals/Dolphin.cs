namespace Session1Library.Animals;

/// <summary>
/// Represents a Dolphin, a type of Animal with properties like intelligence, echo range, and swim speed.
/// </summary>
public class Dolphin : Animal
{
    /// <summary>
    /// The intelligence level of the dolphin.
    /// </summary>
    public int IntelligenceLevel { get; set; }
    /// <summary>
    /// The range of the dolphin's echolocation in meters.
    /// </summary>
    public int EchoRange { get; set; }
    /// <summary>
    /// The swimming speed of the dolphin in km/h.
    /// </summary>
    public int SwimSpeed { get; set; }

    /// <summary>
    /// Initializes a new instance of the Dolphin class.
    /// </summary>
    public Dolphin(string name, int id, int intelligenceLevel, int echoRange, int swimSpeed) : base(name, id, "Mammal")
    {
        IntelligenceLevel = intelligenceLevel;
        EchoRange = echoRange;
        SwimSpeed = swimSpeed;
    }

    /// <summary>
    /// Calculates the total echo coverage based on hours.
    /// Equation: Echo Coverage = EchoRange * hours
    /// </summary>
    public int CalculateEchoCoverage(int hours)
    {
        return EchoRange * hours;
    }

    /// <summary>
    /// Gets a description of the dolphin including its unique properties.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Intelligence Level: {IntelligenceLevel}, Echo Range: {EchoRange} meters, Swim Speed: {SwimSpeed} km/h";
    }

    /// <summary>
    /// Returns the sound a dolphin makes.
    /// </summary>
    public override string MakeSound()
    {
        return "Click";
    }
}
