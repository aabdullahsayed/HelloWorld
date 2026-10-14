var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();


app.MapGet("/", () => new
{
    Message = "Ubuntu 22 LTS Abdullah Al Sayed"
});


app.Run();

