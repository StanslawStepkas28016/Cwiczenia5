namespace AnimalApp.Visits;

public class Visit(int id, int animalId, DateTime dateTime, string description, double price)
{
    public int Id = id;
    public int AnimalId = animalId;
    public DateTime DateTime = dateTime;
    public string Description = description;
    public double Price = price;
}