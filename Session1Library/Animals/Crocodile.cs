namespace Session1Library.Animals;

public class Crocodile : Animal
{
    public int JawStrength { get; set; }
    public int TailLength { get; set; }
    public int BiteForce { get; set; }

    public Crocodile(string name, int id, int jawStrength, int tailLength, int biteForce) : base(name, id, "Reptile")
    {
        JawStrength = jawStrength;
        TailLength = tailLength;
        BiteForce = biteForce;
    }

    public int CalculateBiteImpact(int duration)
    {
        return BiteForce * duration;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Jaw Strength: {JawStrength} PSI, Tail Length: {TailLength} cm, Bite Force: {BiteForce} N";
    }

    public override string MakeSound()
    {
        return "Growl";
    }
}
