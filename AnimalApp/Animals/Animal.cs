namespace AnimalApp.Animals;

public class Animal(int id, string name, string category, double mass, string color)
{
    public int Id = id;
    public string Name = name;
    public string Category = category;
    public double Mass = mass;
    public string Color = color;

    public int Id1
    {
        get => Id;
        set => Id = value;
    }

    public string Name1
    {
        get => Name;
        set => Name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Category1
    {
        get => Category;
        set => Category = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Mass1
    {
        get => Mass;
        set => Mass = value;
    }

    public string Color1
    {
        get => Color;
        set => Color = value ?? throw new ArgumentNullException(nameof(value));
    }
}