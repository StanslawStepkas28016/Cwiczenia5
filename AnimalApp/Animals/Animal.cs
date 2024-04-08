namespace AnimalApp.Animals;

public class Animal(int id, string name, string category, double mass, string color)
{
    public int Id = id;
    public string Name = name;
    public string Category = category;
    public double Mass = mass;
    public string Color = color;
}