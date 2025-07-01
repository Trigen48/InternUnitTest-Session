namespace Session1Library.Animals;

/// <summary>
/// Represents a Horse, a type of Animal with a specific speed property.
/// </summary>
public class Horse : Animal
{
    /// <summary>
    /// The speed of the horse in km/h.
    /// </summary>
    public int Speed { get; set; }

    /// <summary>
    /// Initializes a new instance of the Horse class.
    /// </summary>
    public Horse(string name, int id, int speed) : base(name, id, "Mammal")
    {
        Speed = speed;
    }

    /// <summary>
    /// Gets a description of the horse including its speed.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Speed: {Speed} km/h";
    }

    /// <summary>
    /// Calculates the distance the horse can travel in a given number of hours.
    /// Equation: Distance = Speed * hours
    /// </summary>
    public int CalculateDistance(int hours)
    {
        return Speed * hours;
    }

    /// <summary>
    /// Returns the sound a horse makes.
    /// </summary>
    public override string MakeSound()
    {
        return "Neigh";
    }
}
