namespace AnimalApp.Animals;

public static class AnimalEndpoints
{
    public static void Register(WebApplication app, List<Animal> animals)
    {
        // Pobranie listy zwierząt. 
        app.MapGet("/animals", () => animals);

        // Pobranie konkretnego zwierzęcia po Id.
        app.MapGet("/animals/{id:int}", (int id) =>
            animals.FirstOrDefault(a => a.Id == id) is { } animal ? Results.Ok(animal) : Results.NotFound());

        // Dodawanie zwierzęcia.
        app.MapPost("/animals", (Animal animal) =>
        {
            animals.Add(animal);
            return Results.Created($"/animals/{animal.Id}", animal);
        });

        // Edycja zwierzęcia.
        app.MapPost("/animals", (Animal oldAnimal, Animal newAnimal) =>
        {
            // oldAnimal.Id = newAnimal.Id;
            oldAnimal.Name = newAnimal.Name;
            oldAnimal.Category = newAnimal.Category;
            oldAnimal.Mass = newAnimal.Mass;
            oldAnimal.Color = newAnimal.Color;

            return Results.Ok();
        });

        // Usuwanie zwierzęcia.
        app.MapPost("/animals", (Animal animal) =>
        {
            animals.Remove(animal);
            return Results.Ok();
        });
    }
}