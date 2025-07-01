using Session1Library;
using Session1Library.Animals;
using Xunit;

namespace Session1UnitTest;

public class AnimalTests
{
    [Theory]
    [InlineData("Trumpet", "Elephant")]
    [InlineData("Screech", "Eagle")]
    [InlineData("Roars", "Bear")]
    [InlineData("Ribbits", "Frog")]
    [InlineData("Growl", "Crocodile")]
    [InlineData("Click", "Dolphin")]
    [InlineData("Honk", "Penguin")]
    [InlineData("Silent", "Shark")]
    [InlineData("Chortle", "Kangaroo")]
    [InlineData("Hott", "Owl")] // Intentional typo: should be "Hoot"
    public void TestAnimalSounds(string expectedSound, string animalType)
    {
        Animal animal = GetAnimalByType(animalType);
        Assert.Equal(animal.MakeSound(), expectedSound);
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

    [Fact]
    public void TestCat_CalculateAgeInCatYears()
    {
        var cat = new Cat("Kitty", 1, "Siamese");
        Assert.Equal(14, cat.CalculateAgeInCatYears(2));
    }

    [Fact]
    public void TestDog_CalculateAgeInDogYears()
    {
        var dog = new Dog("Rex", 2, "Labrador");
        Assert.Equal(21, dog.CalculateAgeInDogYears(3));
    }

    [Fact]
    public void TestBear_CalculateHibernateDays()
    {
        var bear = new Bear("Grizzly", 3, 400, "Brown", 5, 12, 120);
        Assert.Equal(150, bear.CalculateHibernateDays());
    }

    [Fact]
    public void TestBear_CalculateRoarImpact()
    {
        var bear = new Bear("Grizzly", 3, 400, "Brown", 5, 12, 120);
        Assert.Equal(240, bear.CalculateRoarImpact(2));
    }

    [Fact]
    public void TestCrocodile_CalculateBiteImpact()
    {
        var croc = new Crocodile("Croc", 4, 600, 200, 300);
        Assert.Equal(1200, croc.CalculateBiteImpact(4));
    }

    [Fact]
    public void TestDolphin_CalculateEchoCoverage()
    {
        var dolphin = new Dolphin("Flipper", 5, 500, 150, 60);
        Assert.Equal(450, dolphin.CalculateEchoCoverage(3));
    }

    [Fact]
    public void TestEagle_CalculateFlightDistance()
    {
        var eagle = new Eagle("Baldy", 6, 200, 90, 1000);
        Assert.Equal(180, eagle.CalculateFlightDistance(2));
    }

    [Fact]
    public void TestElephant_CalculateDailyWaterConsumption()
    {
        var elephant = new Elephant("Dumbo", 7, 250, 60, 12);
        Assert.Equal(48, elephant.CalculateDailyWaterConsumption(4));
    }

    [Fact]
    public void TestFrog_CalculateJumpDistanceInMeters()
    {
        var frog = new Frog("Froggy", 8, false, "Green", 250, 10, 30);
        Assert.Equal(2, frog.CalculateJumpDistanceInMeters());
    }

    [Fact]
    public void TestFrog_CalculateLeapDistance()
    {
        var frog = new Frog("Froggy", 8, false, "Green", 250, 10, 30);
        Assert.Equal(90, frog.CalculateLeapDistance(3));
    }

    [Fact]
    public void TestHorse_CalculateDistance()
    {
        var horse = new Horse("Spirit", 9, 50);
        Assert.Equal(100, horse.CalculateDistance(2));
    }

    [Fact]
    public void TestKangaroo_CalculateJumpDistance()
    {
        var kangaroo = new Kangaroo("Joey", 10, 120, 15, 25);
        Assert.Equal(100, kangaroo.CalculateJumpDistance(4));
    }

    [Fact]
    public void TestOwl_CalculateNightVisionCoverage()
    {
        var owl = new Owl("Hedwig", 11, true, 60, 120);
        Assert.Equal(240, owl.CalculateNightVisionCoverage(2));
    }

    [Fact]
    public void TestPenguin_CalculateDiveDistance()
    {
        var penguin = new Penguin("Pingu", 12, true, 15, 40);
        Assert.Equal(45, penguin.CalculateDiveDistance(3));
    }

    [Fact]
    public void TestShark_CalculateSwimDistance()
    {
        var shark = new Shark("Jaws", 13, 350, 60, 300);
        Assert.Equal(300, shark.CalculateSwimDistance(5));
    }

    [Fact]
    public void TestSnake_Length()
    {
        var snake = new Snake("Slither", 14, 180);
        Assert.Equal(180, snake.Length);
    }
}
