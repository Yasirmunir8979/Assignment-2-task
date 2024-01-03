using Assignment_2_task.Shared.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiGrey.Server.Controllers
{
   [Route("api/[controller]")]
[ApiController]
public class PredictionController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public PredictionController(ApplicationDbContext context)
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
}
