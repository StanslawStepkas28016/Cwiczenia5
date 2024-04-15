using AnimalApp.Animals;
using AnimalApp.Visits;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// Minimal API Approach.
List<Animal> animals =
[
    new Animal(1, "Max", "Dog", 3.5, "Black"),
    new Animal(2, "Alice", "Cat", 1.5, "Gray"),
    new Animal(3, "Bob", "Snake", 0.5, "Red")
];

List<Visit> visits =
[
    new Visit(1, 1, new DateTime(2024, 2, 28), "Annual checkup", 200),
    new Visit(2, 2, new DateTime(2024, 3, 15), "Teeth cleaning", 500)
];

AnimalEndpoints.Register(app, animals);
VisitEndpoints.Register(app, visits);

app.MapControllers();

app.Run();