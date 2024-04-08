namespace AnimalApp.Visits;

public static class VisitEndpoints
{
    public static void Register(WebApplication app, List<Visit> visits)
    {
        // Pobranie listy wizyt.
        app.MapGet("/visits", () => visits);
    }
}