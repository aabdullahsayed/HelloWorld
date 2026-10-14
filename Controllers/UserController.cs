
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/users")]
public class UserController: ControllerBase
{
    [HttpGet]
    public IActionResult Check()
    {
        var Message = "This Endpoint is working";
        return Ok(Message);
    }
}