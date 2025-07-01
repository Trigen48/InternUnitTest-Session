namespace Session1Library.Animals;

/// <summary>
/// Represents a Frog, a type of Animal with properties like poison, skin pattern, jump distance, tongue length, and leap height.
/// </summary>
public class Frog : Animal
{
    /// <summary>
    /// Indicates if the frog is poisonous.
    /// </summary>
    public bool IsPoisonous { get; set; }
    /// <summary>
    /// The skin pattern of the frog.
    /// </summary>
    public string SkinPattern { get; set; }
    /// <summary>
    /// The jump distance of the frog in centimeters.
    /// </summary>
    public int JumpDistance { get; set; }
    /// <summary>
    /// The length of the frog's tongue in centimeters.
    /// </summary>
    public int TongueLength { get; set; }
    /// <summary>
    /// The leap height of the frog in centimeters.
    /// </summary>
    public int LeapHeight { get; set; }

    /// <summary>
    /// Initializes a new instance of the Frog class.
    /// </summary>
    public Frog(string name, int id, bool isPoisonous, string skinPattern, int jumpDistance, int tongueLength, int leapHeight) : base(name, id, "Amphibian")
    {
        IsPoisonous = isPoisonous;
        SkinPattern = skinPattern;
        JumpDistance = jumpDistance;
        TongueLength = tongueLength;
        LeapHeight = leapHeight;
    }

    /// <summary>
    /// Calculates the jump distance in meters.
    /// Equation: Jump Distance (meters) = JumpDistance / 100
    /// </summary>
    public int CalculateJumpDistanceInMeters()
    {
        return JumpDistance / 100;
    }

    /// <summary>
    /// Calculates the leap distance based on hours.
    /// Equation: Leap Distance = LeapHeight * hours
    /// </summary>
    public int CalculateLeapDistance(int hours)
    {
        return LeapHeight * hours;
    }

    /// <summary>
    /// Gets a description of the frog including its unique properties.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Is Poisonous: {IsPoisonous}, Skin Pattern: {SkinPattern}, Jump Distance: {JumpDistance} cm, Tongue Length: {TongueLength} cm, Leap Height: {LeapHeight} cm";
    }

    /// <summary>
    /// Returns the sound a frog makes.
    /// </summary>
    public override string MakeSound()
    {
        return "Ribbit";
    }
}
