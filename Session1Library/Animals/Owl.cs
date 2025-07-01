namespace Session1Library.Animals;

/// <summary>
/// Represents an Owl, a type of Animal with properties like nocturnality, wingspan, and night vision range.
/// </summary>
public class Owl : Animal
{
    /// <summary>
    /// Indicates if the owl is nocturnal.
    /// </summary>
    public bool IsNocturnal { get; set; }
    /// <summary>
    /// The wingspan of the owl in centimeters.
    /// </summary>
    public int WingSpan { get; set; }
    /// <summary>
    /// The night vision range of the owl in meters.
    /// </summary>
    public int NightVisionRange { get; set; }

    /// <summary>
    /// Initializes a new instance of the Owl class.
    /// </summary>
    public Owl(string name, int id, bool isNocturnal, int wingSpan, int nightVisionRange) : base(name, id, "Bird")
    {
        IsNocturnal = isNocturnal;
        WingSpan = wingSpan;
        NightVisionRange = nightVisionRange;
    }

    /// <summary>
    /// Calculates the night vision coverage based on hours.
    /// Equation: Night Vision Coverage = NightVisionRange * hours
    /// </summary>
    public int CalculateNightVisionCoverage(int hours)
    {
        return NightVisionRange * hours;
    }

    /// <summary>
    /// Gets a description of the owl including its unique properties.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Is Nocturnal: {IsNocturnal}, Wing Span: {WingSpan} cm, Night Vision Range: {NightVisionRange} meters";
    }

    /// <summary>
    /// Returns the sound an owl makes. Should return: "Hoot"
    /// </summary>
    public override string MakeSound()
    {
        // Intentional mistake: wrong sound
        return "Whoo";
    }
}
