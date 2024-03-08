using infraAlerta.Models;
using Microsoft.AspNetCore.Mvc;

namespace infraAlerta.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{

    [HttpGet("getUsers", Name = "getUsers")]
    public string Get()
    {
        return "usuários";
    }

    [HttpPost("createUser", Name = "createUser")]
    public User Create(string name){
        
        return new User();
    }
}
