using notCorporate;
using System.Runtime.InteropServices;
DateTime oneTwentyDaysAgo = DateTime.Today.AddDays(120);
DateTime TwentyDaysAgo = DateTime.Today.AddDays(120);

SchoolFigure Joseyparent = new("wilmer", "rivera", "706@gmail", TwentyDaysAgo, 15.5, RollType.Developer, new int[32], notes: new string[32], oneTwentyDaysAgo);

if (Joseyparent != null)
{
    List<SchoolFigure> schoolFigures= new();
    Console.WriteLine("worked");

    Console.WriteLine(schoolFigures);
}
else
{
    Console.WriteLine("did not work");
}
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
