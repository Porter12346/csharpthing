namespace csharpthing.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{
    private readonly ChoresService _choresService

    public ChoresController(ChoresService choresService){
        _choresService = choresService
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
        try
        {
            List<Chore> chores = [];
            return Ok(chores);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }
}