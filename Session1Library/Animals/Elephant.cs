namespace Session1Library.Animals;

/// <summary>
/// Represents an Elephant, a type of Animal with properties like trunk length, ear size, and water consumption.
/// </summary>
public class Elephant : Animal
{
    /// <summary>
    /// The length of the elephant's trunk in centimeters.
    /// </summary>
    public int TrunkLength { get; set; }
    /// <summary>
    /// The size of the elephant's ears in centimeters.
    /// </summary>
    public int EarSize { get; set; }
    /// <summary>
    /// The water consumption of the elephant in liters per hour.
    /// </summary>
    public int WaterConsumption { get; set; }

    /// <summary>
    /// Initializes a new instance of the Elephant class.
    /// </summary>
    public Elephant(string name, int id, int trunkLength, int earSize, int waterConsumption) : base(name, id, "Mammal")
    {
        TrunkLength = trunkLength;
        EarSize = earSize;
        WaterConsumption = waterConsumption;
    }

    /// <summary>
    /// Calculates the total water consumption based on hours.
    /// Equation: Water Consumption = WaterConsumption * hours
    /// </summary>
    public int CalculateDailyWaterConsumption(int hours)
    {
        return (WaterConsumption * hours) + 5;
    }

    /// <summary>
    /// Gets a description of the elephant including its unique properties.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Trunk Length: {TrunkLength} cm, Ear Size: {EarSize} cm, Water Consumption: {WaterConsumption} liters/hour";
    }

    /// <summary>
    /// Returns the sound an elephant makes. Should return: "Trumpet"
    /// </summary>
    public override string MakeSound()
    {
        return "Trumpet";
    }
}
