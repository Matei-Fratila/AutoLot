namespace AutoLot.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrdersController : BaseCrudController<Order, OrdersController>
{
    public OrdersController(IAppLogging<OrdersController> logger, IOrderRepo repo) : base(logger, repo)
    {
    }
}
