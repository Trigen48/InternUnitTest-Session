namespace Session1Library.Animals;

/// <summary>
/// Represents a Crocodile, a type of Animal with properties like jaw strength, tail length, and bite force.
/// </summary>
public class Crocodile : Animal
{
    /// <summary>
    /// The strength of the crocodile's jaw in PSI.
    /// </summary>
    public int JawStrength { get; set; }
    /// <summary>
    /// The length of the crocodile's tail in centimeters.
    /// </summary>
    public int TailLength { get; set; }
    /// <summary>
    /// The bite force of the crocodile in Newtons.
    /// </summary>
    public int BiteForce { get; set; }

    /// <summary>
    /// Initializes a new instance of the Crocodile class.
    /// </summary>
    public Crocodile(string name, int id, int jawStrength, int tailLength, int biteForce) : base(name, id, "Reptile")
    {
        JawStrength = jawStrength;
        TailLength = tailLength;
        BiteForce = biteForce;
    }

    /// <summary>
    /// Calculates the impact of the crocodile's bite based on duration.
    /// Equation: Bite Impact = BiteForce * duration
    /// </summary>
    public int CalculateBiteImpact(int duration)
    {
        // Intentional mistake: subtract 1 from result
        return (BiteForce * duration) - 1;
    }

    /// <summary>
    /// Gets a description of the crocodile including its unique properties.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Jaw Strength: {JawStrength} PSI, Tail Length: {TailLength} cm, Bite Force: {BiteForce} N";
    }

    /// <summary>
    /// Returns the sound a crocodile makes. Should return: "Growl"
    /// </summary>
    public override string MakeSound()
    {
        return "Growl";
    }
}
