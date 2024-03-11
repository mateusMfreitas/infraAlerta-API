using infraAlerta.Data;
using infraAlerta.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace infraAlerta.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
        private readonly ApiDbContext _context;

    public UserController(ApiDbContext context)
    {
        _context = context;
    }

    [HttpGet("getUsers", Name = "getUsers")]
    public string Get()
    {
        return "usuários";
    }

    [HttpPost("createUser", Name = "createUser")]

    public async Task<IActionResult> CreateUser([FromBody] User newUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.User.Add(newUser);
        await _context.SaveChangesAsync();

        return Ok(newUser);
    }
}
