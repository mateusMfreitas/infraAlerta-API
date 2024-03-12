using infraAlerta.Data;
using infraAlerta.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace infraAlerta.Controllers;

[ApiController]
[Route("problem")]
public class ProblemController : ControllerBase
{
    private readonly ApiDbContext _context;

    public ProblemController(ApiDbContext context)
    {
        _context = context;
    }

    [HttpGet("getProblems", Name = "getProblems")]
    public IActionResult GetProblems()
    {
        var problems = _context.Problem.ToList();
        return Ok(problems);
    }

    [HttpPost("createProblem", Name = "createProblem")]

    public async Task<IActionResult> CreateProblem([FromBody] Problem newProblem)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.Problem.Add(newProblem);
        await _context.SaveChangesAsync();

        return Ok(newProblem);
    }   
}
