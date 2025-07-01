namespace Session1Library.Animals;

/// <summary>
/// Represents a Dog, a type of Animal with a specific breed.
/// </summary>
public class Dog : Animal
{
    /// <summary>
    /// The breed of the dog.
    /// </summary>
    public string Breed { get; set; }

    /// <summary>
    /// Initializes a new instance of the Dog class.
    /// </summary>
    public Dog(string name, int id, string breed) : base(name, id, "Mammal")
    {
        Breed = breed;
    }

    /// <summary>
    /// Gets a description of the dog including its breed.
    /// </summary>
    public override string GetDescription()
    {
        return base.GetDescription() + $", Breed: {Breed}";
    }

    /// <summary>
    /// Calculates the dog's age in dog years.
    /// Equation: Dog Age = humanYears * 7
    /// </summary>
    public int CalculateAgeInDogYears(int humanYears)
    {
        return humanYears * 6;
    }

    /// <summary>
    /// Returns the sound a dog makes. Should return: "Bark"
    /// </summary>
    public override string MakeSound()
    {
        return "Bark";
    }
}
