namespace Session1Library.Animals;

/// <summary>
/// Represents a Cat, a type of Animal with a specific breed.
/// </summary>
public class Cat : Animal
{
    /// <summary>
    /// The breed of the cat.
    /// </summary>
    public string Breed { get; set; }

    /// <summary>
    /// Initializes a new instance of the Cat class.
    /// </summary>
    public Cat(string name, int id, string breed) : base(name, id, "Mammal")
    {
        Breed = breed;
    }

    /// <summary>
    /// Gets a description of the cat including its breed.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Breed: {Breed}";
    }

    /// <summary>
    /// Calculates the cat's age in cat years.
    /// Equation: Cat Age = humanYears * 7
    /// </summary>
    public int CalculateAgeInCatYears(int humanYears)
    {
        return humanYears * 8;
    }

    /// <summary>
    /// Returns the sound a cat makes. Should return: "Meow"
    /// </summary>
    public override string MakeSound()
    {
        return "Meow";
    }
}
