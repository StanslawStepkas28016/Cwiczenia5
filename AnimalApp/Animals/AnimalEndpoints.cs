using Microsoft.AspNetCore.Mvc;

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
        app.MapPut("/animals/add", ([FromBody] Animal animal) =>
        {
            animals.Add(animal);
            return Results.Created($"/animals/{animal.Id}", animal);
        });

        // Edycja zwierzęcia, z użyciem DTO (Data Transfer Object).
        app.MapPost("/animals/modify", ([FromBody] AnimalUpdateDTO updateDto) =>
        {
            var oldAnimal = animals.FirstOrDefault(a => a.Id == updateDto.OldAnimal.Id);
            if (oldAnimal == null)
                return Results.NotFound();

            oldAnimal.Name = updateDto.NewAnimal.Name;
            oldAnimal.Category = updateDto.NewAnimal.Category;
            oldAnimal.Mass = updateDto.NewAnimal.Mass;
            oldAnimal.Color = updateDto.NewAnimal.Color;

            return Results.Ok(oldAnimal);
        });

        // Usuwanie zwierzęcia.
        app.MapDelete("/animals/delete", ([FromBody] Animal animal) =>
        {
            animals.Remove(animal);
            return Results.Ok();
        });
    }
}