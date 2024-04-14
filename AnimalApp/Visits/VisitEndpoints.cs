namespace AnimalApp.Visits;

public static class VisitEndpoints
{
    public static void Register(WebApplication app, List<Visit> visits)
    {
        // Pobranie listy wizyt dla danego zwierzęcia.
        app.MapGet("/visits/{id:int}", (int id) => visits[id]);

        // Dodanie nowej wizyty.
        app.MapPut("/visits/add", (Visit visit) =>
        {
            visits.Add(visit);
            return Results.Created($"/visits/{visit.Id}", visit);
        });
    }
}