namespace Session1Library.Animals;

/// <summary>
/// Represents an Eagle, a type of Animal with properties like wingspan, flight speed, and vision range.
/// </summary>
public class Eagle : Animal
{
    /// <summary>
    /// The wingspan of the eagle in centimeters.
    /// </summary>
    public int Wingspan { get; set; }
    /// <summary>
    /// The flight speed of the eagle in km/h.
    /// </summary>
    public int FlightSpeed { get; set; }
    /// <summary>
    /// The vision range of the eagle in meters.
    /// </summary>
    public int VisionRange { get; set; }

    /// <summary>
    /// Initializes a new instance of the Eagle class.
    /// </summary>
    public Eagle(string name, int id, int wingspan, int flightSpeed, int visionRange) : base(name, id, "Bird")
    {
        Wingspan = wingspan;
        FlightSpeed = flightSpeed;
        VisionRange = visionRange;
    }

    /// <summary>
    /// Calculates the total flight distance based on hours.
    /// Equation: Flight Distance = FlightSpeed * hours
    /// </summary>
    public int CalculateFlightDistance(int hours)
    {
        return FlightSpeed * hours;
    }

    /// <summary>
    /// Gets a description of the eagle including its unique properties.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Wingspan: {Wingspan} cm, Flight Speed: {FlightSpeed} km/h, Vision Range: {VisionRange} meters";
    }

    /// <summary>
    /// Returns the sound an eagle makes.
    /// </summary>
    public override string MakeSound()
    {
        return "Screech";
    }
}
