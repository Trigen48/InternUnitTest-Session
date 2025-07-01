namespace Session1Library.Animals;

public class Cat : Animal
{
    public string Breed { get; set; }

    public Cat(string name, int id, string breed) : base(name, id, "Mammal")
    {
        Breed = breed;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Breed: {Breed}";
    }

    public int CalculateAgeInCatYears(int humanYears)
    {
        return humanYears * 7;
    }

    public override string MakeSound()
    {
        return "Meow";
    }
}
