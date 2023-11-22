namespace AutoLot.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarDriversController : BaseCrudController<CarDriver, CarDriversController>
{
    public CarDriversController(IAppLogging<CarDriversController> logger, ICarDriverRepo repo) : base(logger, repo)
    {
    }
}
