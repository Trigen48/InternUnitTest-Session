namespace Session1Library.Animals;

public class Kangaroo : Animal
{
    public int JumpHeight { get; set; }
    public int PouchCapacity { get; set; }
    public int JumpSpeed { get; set; }

    public Kangaroo(string name, int id, int jumpHeight, int pouchCapacity, int jumpSpeed) : base(name, id, "Mammal")
    {
        JumpHeight = jumpHeight;
        PouchCapacity = pouchCapacity;
        JumpSpeed = jumpSpeed;
    }

    public int CalculateJumpDistance(int hours)
    {
        return JumpSpeed * hours;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + $", Jump Height: {JumpHeight} cm, Pouch Capacity: {PouchCapacity} liters, Jump Speed: {JumpSpeed} km/h";
    }

    public override string MakeSound()
    {
        return "Chortle";
    }
}
