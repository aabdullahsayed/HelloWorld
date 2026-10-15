using HelloWorld.Models;
using HelloWorld.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);


var app = builder.Build();

var person = new User(
    "Abdullah Al Sayed",
    "+8801855215087",
    "Uttara, Dhaka 1230"
);

app.MapGet("/", () => new
{
    Message = "Ubuntu 22 LTS"
});

app.MapGet("/jin", () => new
{
    Message = "I Love you Jaan<3" 
});

app.MapGet("/users", () => person );

app.MapControllers();

app.Run();




