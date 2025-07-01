namespace Session1Library.Animals;

/// <summary>
/// Represents a Kangaroo, a type of Animal with properties like jump height, pouch capacity, and jump speed.
/// </summary>
public class Kangaroo : Animal
{
    /// <summary>
    /// The jump height of the kangaroo in centimeters.
    /// </summary>
    public int JumpHeight { get; set; }
    /// <summary>
    /// The pouch capacity of the kangaroo in liters.
    /// </summary>
    public int PouchCapacity { get; set; }
    /// <summary>
    /// The jump speed of the kangaroo in km/h.
    /// </summary>
    public int JumpSpeed { get; set; }

    /// <summary>
    /// Initializes a new instance of the Kangaroo class.
    /// </summary>
    public Kangaroo(string name, int id, int jumpHeight, int pouchCapacity, int jumpSpeed) : base(name, id, "Mammal")
    {
        JumpHeight = jumpHeight;
        PouchCapacity = pouchCapacity;
        JumpSpeed = jumpSpeed;
    }

    /// <summary>
    /// Calculates the jump distance based on hours.
    /// Equation: Jump Distance = JumpSpeed * hours
    /// </summary>
    public int CalculateJumpDistance(int hours)
    {
        return JumpSpeed * hours;
    }

    /// <summary>
    /// Gets a description of the kangaroo including its unique properties.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Jump Height: {JumpHeight} cm, Pouch Capacity: {PouchCapacity} liters, Jump Speed: {JumpSpeed} km/h";
    }

    /// <summary>
    /// Returns the sound a kangaroo makes.
    /// </summary>
    public override string MakeSound()
    {
        return "Chortle";
    }
}
