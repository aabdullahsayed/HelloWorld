
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Data;
using HelloWorld.Models;
namespace HelloWorld.Controllers;

[ApiController]
[Route("api/users")]

public class UserController: ControllerBase
{
    private readonly AppDbContext _context;
    public UserController(AppDbContext context)
    {
        _context = context;
    }
    [HttpPost]
    public IActionResult Create(User user)
    {
        _context.Add(user);
        _context.SaveChanges();
        return Ok(_context.users);
    }
}