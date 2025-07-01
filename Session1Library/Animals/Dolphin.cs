namespace Session1Library.Animals;

public class Dolphin : Animal
{
    public int IntelligenceLevel { get; set; }
    public int EchoRange { get; set; }
    public int SwimSpeed { get; set; }

    public Dolphin(string name, int id, int intelligenceLevel, int echoRange, int swimSpeed) : base(name, id, "Mammal")
    {
        IntelligenceLevel = intelligenceLevel;
        EchoRange = echoRange;
        SwimSpeed = swimSpeed;
    }

    public int CalculateEchoCoverage(int hours)
    {
        return EchoRange * hours;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Intelligence Level: {IntelligenceLevel}, Echo Range: {EchoRange} meters, Swim Speed: {SwimSpeed} km/h";
    }

    public override string MakeSound()
    {
        return "Click";
    }
}
