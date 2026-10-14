
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

var person = new User(
    "Abdullah Al Sayed",
    "+8801855215087",
    "Uttara, Dhaka 1230"
);

app.MapGet("/", () => new
{
    Message = "Ubuntu 22 LTS Abdullah Al Sayed"
});

app.MapGet("/users", () => person );

app.MapControllers();

app.Run();




