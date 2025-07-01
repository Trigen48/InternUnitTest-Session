namespace Session1Library.Animals;

public class Frog : Animal
{
    public bool IsPoisonous { get; set; }
    public string SkinPattern { get; set; }
    public int JumpDistance { get; set; }
    public int TongueLength { get; set; }
    public int LeapHeight { get; set; }

    public Frog(string name, int id, bool isPoisonous, string skinPattern, int jumpDistance, int tongueLength, int leapHeight) : base(name, id, "Amphibian")
    {
        IsPoisonous = isPoisonous;
        SkinPattern = skinPattern;
        JumpDistance = jumpDistance;
        TongueLength = tongueLength;
        LeapHeight = leapHeight;
    }

    public int CalculateJumpDistanceInMeters()
    {
        return JumpDistance / 100;
    }

    public int CalculateLeapDistance(int hours)
    {
        return LeapHeight * hours;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Is Poisonous: {IsPoisonous}, Skin Pattern: {SkinPattern}, Jump Distance: {JumpDistance} cm, Tongue Length: {TongueLength} cm, Leap Height: {LeapHeight} cm";
    }

    public override string MakeSound()
    {
        return "Ribbit";
    }
}
