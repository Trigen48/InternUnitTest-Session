namespace Session1Library.Animals;

/// <summary>
/// Represents a Bear, a type of Animal with specific properties like strength, fur color, hibernation, claws, and roar volume.
/// </summary>
public class Bear : Animal
{
    /// <summary>
    /// The strength of the bear in kilograms.
    /// </summary>
    public int Strength { get; set; }
    /// <summary>
    /// The color of the bear's fur.
    /// </summary>
    public string FurColor { get; set; }
    /// <summary>
    /// Number of months the bear hibernates.
    /// </summary>
    public int HibernateMonths { get; set; }
    /// <summary>
    /// Length of the bear's claws in centimeters.
    /// </summary>
    public int ClawLength { get; set; }
    /// <summary>
    /// Volume of the bear's roar in decibels.
    /// </summary>
    public int RoarVolume { get; set; }

    /// <summary>
    /// Initializes a new instance of the Bear class.
    /// </summary>
    public Bear(string name, int id, int strength, string furColor, int hibernateMonths, int clawLength, int roarVolume) : base(name, id, "Mammal")
    {
        Strength = strength;
        FurColor = furColor;
        HibernateMonths = hibernateMonths;
        ClawLength = clawLength;
        RoarVolume = roarVolume;
    }

    /// <summary>
    /// Calculates the total number of days the bear hibernates.
    /// Equation: Hibernate Days = HibernateMonths * 30
    /// </summary>
    public int CalculateHibernateDays()
    {
        return HibernateMonths * 31;
    }

    /// <summary>
    /// Calculates the impact of the bear's roar based on duration.
    /// Equation: Roar Impact = RoarVolume * duration
    /// </summary>
    public int CalculateRoarImpact(int duration)
    {
        // Intentional mistake: add 1 to result
        return (RoarVolume * duration) + 1;
    }

    /// <summary>
    /// Gets a description of the bear including its unique properties.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Strength: {Strength} kg, Fur Color: {FurColor}, Hibernate Months: {HibernateMonths}, Claw Length: {ClawLength} cm, Roar Volume: {RoarVolume} dB";
    }

    /// <summary>
    /// Returns the sound a bear makes. Should return: "Roar"
    /// </summary>
    public override string MakeSound()
    {
        return "Roar";
    }
}
