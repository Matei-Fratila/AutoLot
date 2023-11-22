namespace AutoLot.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CreditRisksController : BaseCrudController<CreditRisk, CreditRisksController>
{
    public CreditRisksController(IAppLogging<CreditRisksController> logger, ICreditRiskRepo repo) : base(logger, repo)
    {
    }
}
