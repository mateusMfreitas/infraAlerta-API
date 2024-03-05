using Microsoft.AspNetCore.Mvc;

namespace infraAlerta.Controllers;

[ApiController]
[Route("problem")]
public class ProblemController : ControllerBase
{

    [HttpGet("getProblems", Name = "getProblems")]
    public string Get()
    {
        return "Problemas";
    }
}
