namespace Session1Library.Animals;

public class Owl : Animal
{
    public bool IsNocturnal { get; set; }
    public int WingSpan { get; set; }
    public int NightVisionRange { get; set; }

    public Owl(string name, int id, bool isNocturnal, int wingSpan, int nightVisionRange) : base(name, id, "Bird")
    {
        IsNocturnal = isNocturnal;
        WingSpan = wingSpan;
        NightVisionRange = nightVisionRange;
    }

    public int CalculateNightVisionCoverage(int hours)
    {
        return NightVisionRange * hours;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Is Nocturnal: {IsNocturnal}, Wing Span: {WingSpan} cm, Night Vision Range: {NightVisionRange} meters";
    }

    public override string MakeSound()
    {
        return "Hoot";
    }
}
