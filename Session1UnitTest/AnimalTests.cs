using Session1Library;
using Session1Library.Animals;
using Xunit;

public class AnimalTests
{
    [Theory]
    [InlineData("Trumpet", "Elephant")]
    [InlineData("Screech", "Eagle")]
    [InlineData("Roar", "Bear")]
    [InlineData("Ribbit", "Frog")]
    [InlineData("Growl", "Crocodile")]
    [InlineData("Click", "Dolphin")]
    [InlineData("Honk", "Penguin")]
    [InlineData("Silent", "Shark")]
    [InlineData("Chortle", "Kangaroo")]
    [InlineData("Hoot", "Owl")]
    public void TestAnimalSounds(string expectedSound, string animalType)
    {
        Animal animal = GetAnimalByType(animalType);
        Assert.Equal(expectedSound, animal.MakeSound());
    }

    [Theory]
    [InlineData("Elephant", "Elephant")]
    [InlineData("Eagle", "Eagle")]
    [InlineData("Bear", "Bear")]
    [InlineData("Frog", "Frog")]
    [InlineData("Crocodile", "Crocodile")]
    [InlineData("Dolphin", "Dolphin")]
    [InlineData("Penguin", "Penguin")]
    [InlineData("Shark", "Shark")]
    [InlineData("Kangaroo", "Kangaroo")]
    [InlineData("Owl", "Owl")]
    public void TestAnimalNames(string expectedName, string animalType)
    {
        Animal animal = GetAnimalByType(animalType);
        Assert.Equal(expectedName, animal.Name);
    }

    private Animal GetAnimalByType(string type)
    {
        return type switch
        {
            "Elephant" => new Elephant("Elephant", 1, 200, 50, 10),
            "Eagle" => new Eagle("Eagle", 2, 100, 80, 500),
            "Bear" => new Bear("Bear", 3, 300, "Brown", 6, 10, 100),
            "Frog" => new Frog("Frog", 4, false, "Spotted", 50, 5, 20),
            "Crocodile" => new Crocodile("Crocodile", 5, 500, 150, 200),
            "Dolphin" => new Dolphin("Dolphin", 6, 400, 100, 50),
            "Penguin" => new Penguin("Penguin", 7, true, 20, 30),
            "Shark" => new Shark("Shark", 8, 300, 40, 200),
            "Kangaroo" => new Kangaroo("Kangaroo", 9, 100, 20, 30),
            "Owl" => new Owl("Owl", 10, true, 50, 100),
            _ => throw new ArgumentException("Unknown animal type")
        };
    }
}
