namespace AnimalApp.Animals;

public record AnimalUpdateDTO
{
    public Animal OldAnimal { get; set; }
    public Animal NewAnimal { get; set; }
}