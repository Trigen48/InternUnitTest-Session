namespace Session1Library.Animals;

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int id, string breed) : base(name, id, "Mammal")
    {
        Breed = breed;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Breed: {Breed}";
    }

    public int CalculateAgeInDogYears(int humanYears)
    {
        return humanYears * 7;
    }

    public override string MakeSound()
    {
        return "Bark";
    }
}
