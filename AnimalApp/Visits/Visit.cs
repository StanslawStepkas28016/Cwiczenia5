namespace AnimalApp.Visits;

public class Visit(int id, int animalId, DateTime dateTime, string description, double price)
{
    public int Id = id;
    public int AnimalId = animalId;
    public DateTime DateTime = dateTime;
    public string Description = description;

    public int Id1
    {
        get => id;
        set => id = value;
    }

    public int AnimalId1
    {
        get => animalId;
        set => animalId = value;
    }

    public DateTime DateTime1
    {
        get => dateTime;
        set => dateTime = value;
    }

    public string Description1
    {
        get => description;
        set => description = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Price1
    {
        get => price;
        set => price = value;
    }

    public double Price = price;
}