namespace HelloWorld.Models;

public class User{

public string email {get; set;}

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