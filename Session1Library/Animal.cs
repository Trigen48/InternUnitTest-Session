namespace Session1Library;

public class Animal
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Type { get; set; }

    public Animal(string name, int id, string type)
    {
        Name = name;
        Id = id;
        Type = type;
    }

    public virtual string GetDescription()
    {
        return $"Name: {Name}, Id: {Id}, Type: {Type}";
    }

    public virtual string MakeSound()
    {
        return "silence";
    }
}

