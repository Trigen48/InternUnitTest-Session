namespace Session1Library.Animals;

public class Bear : Animal
{
    public int Strength { get; set; }
    public string FurColor { get; set; }
    public int HibernateMonths { get; set; }
    public int ClawLength { get; set; }
    public int RoarVolume { get; set; }

    public Bear(string name, int id, int strength, string furColor, int hibernateMonths, int clawLength, int roarVolume) : base(name, id, "Mammal")
    {
        Strength = strength;
        FurColor = furColor;
        HibernateMonths = hibernateMonths;
        ClawLength = clawLength;
        RoarVolume = roarVolume;
    }

    public int CalculateHibernateDays()
    {
        return HibernateMonths * 30;
    }

    public int CalculateRoarImpact(int duration)
    {
        return RoarVolume * duration;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Strength: {Strength} kg, Fur Color: {FurColor}, Hibernate Months: {HibernateMonths}, Claw Length: {ClawLength} cm, Roar Volume: {RoarVolume} dB";
    }

    public override string MakeSound()
    {
        return "Roar";
    }
}
