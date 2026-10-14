var builder = WebApplication.CreateBuilder(args);



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


app.Run();


public class User{

public string name {get; set;}

public string contact {get; set;}
public string address {get; set;}

public User(string name, string contact, string address)
    {
        this.name = name;
        this.contact = contact;
        this.address = address;

    }
}

