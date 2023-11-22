namespace AutoLot.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RadiosController : BaseCrudController<Radio, RadiosController>
{
    public RadiosController(IAppLogging<RadiosController> logger, IRadioRepo repo) : base(logger, repo)
    {
    }
}
