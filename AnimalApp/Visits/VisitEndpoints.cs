namespace AnimalApp.Visits;

public static class VisitEndpoints
{
    public static void Register(WebApplication app, List<Visit> visits)
    {
        // Pobranie listy wizyt dla danego zwierzęcia.
        app.MapGet("/visits/{id:int}", (int animalId) =>
        {
            Visit visitForId = null;

            foreach (var visit in visits)
            {
                if (visit.AnimalId == animalId)
                {
                    visitForId = visit;
                }
            }

            return visitForId;
        }).WithTags("Visits");

        // Dodanie nowej wizyty.
        app.MapPut("/visits/add", (Visit visit) =>
        {
            visits.Add(visit);
            return Results.Created($"/visits/{visit.Id}", visit);
        }).WithTags("Visits");
    }
}