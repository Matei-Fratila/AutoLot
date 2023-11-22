namespace AutoLot.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DriversController : BaseCrudController<Driver, DriversController>
{
    public DriversController(IAppLogging<DriversController> logger, IDriverRepo repo) : base(logger, repo)
    {
    }
}
