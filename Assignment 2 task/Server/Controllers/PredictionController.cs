using Assignment_2_task.Shared.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Web.Http;

namespace Assignment 2 Task.Server.Controllers
[ApiController]
[Route("api/[controller]")]
public class DiabetesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public DiabetesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] DiabetesInput input)
    {
        if (ModelState.IsValid)
        {
            await _context.DiabetesInputs.AddAsync(input);
            await _context.SaveChangesAsync();
            return Ok();
        }
        return BadRequest(ModelState);
    }

    [HttpGet]
    public ActionResult<IEnumerable<DiabetesInput>> Get()
    {
        return _context.DiabetesInputs.ToList();
    }
}

