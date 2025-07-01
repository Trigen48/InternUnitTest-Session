namespace Session1Library.Animals;

public class Elephant : Animal
{
    public int TrunkLength { get; set; }
    public int EarSize { get; set; }
    public int WaterConsumption { get; set; }

    public Elephant(string name, int id, int trunkLength, int earSize, int waterConsumption) : base(name, id, "Mammal")
    {
        TrunkLength = trunkLength;
        EarSize = earSize;
        WaterConsumption = waterConsumption;
    }

    public int CalculateDailyWaterConsumption(int hours)
    {
        return WaterConsumption * hours;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Trunk Length: {TrunkLength} cm, Ear Size: {EarSize} cm, Water Consumption: {WaterConsumption} liters/hour";
    }

    public override string MakeSound()
    {
        return "Trumpet";
    }
}
