namespace AutoLot.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MakesController : BaseCrudController<Make, MakesController>
{
    public MakesController(IAppLogging<MakesController> logger, IMakeRepo repo) : base(logger, repo)
    {
    }
}
