namespace Session1Library.Animals;

public class Eagle : Animal
{
    public int Wingspan { get; set; }
    public int FlightSpeed { get; set; }
    public int VisionRange { get; set; }

    public Eagle(string name, int id, int wingspan, int flightSpeed, int visionRange) : base(name, id, "Bird")
    {
        Wingspan = wingspan;
        FlightSpeed = flightSpeed;
        VisionRange = visionRange;
    }

    public int CalculateFlightDistance(int hours)
    {
        return FlightSpeed * hours;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Wingspan: {Wingspan} cm, Flight Speed: {FlightSpeed} km/h, Vision Range: {VisionRange} meters";
    }

    public override string MakeSound()
    {
        return "Screech";
    }
}
