namespace Session1Library.Animals;

/// <summary>
/// Represents a Snake, a type of Animal with a specific length property.
/// </summary>
public class Snake : Animal
{
    /// <summary>
    /// The length of the snake in centimeters.
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// Initializes a new instance of the Snake class.
    /// </summary>
    public Snake(string name, int id, int length) : base(name, id, "Reptile")
    {
        Length = length;
    }

    /// <summary>
    /// Gets a description of the snake including its length.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Length: {Length} cm";
    }

    /// <summary>
    /// Returns the sound a snake makes.
    /// </summary>
    public override string MakeSound()
    {
        return "Hiss";
    }
}
