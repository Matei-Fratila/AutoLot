namespace AutoLot.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CustomersController : BaseCrudController<Customer, CustomersController>
{
    public CustomersController(IAppLogging<CustomersController> logger, ICustomerRepo repo) : base(logger, repo)
    {
    }
}
