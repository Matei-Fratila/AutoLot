namespace AutoLot.Api.Controllers;

[ApiVersion("2.0")]
[ApiVersion("2.0-Beta")]
[ApiController]
[Route("api/[controller]")]
[Route("api/v{version:apiVersion}/[controller]")]
[AllowAnonymous]
public class Values2Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[] { "Version2:value1", "Version2:value2" });
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id, ApiVersion versionFromModelBinding)
    {
        var versionFromContext = HttpContext.GetRequestedApiVersion();
        return Ok(new[] { versionFromModelBinding.ToString(), versionFromContext.ToString() });
    }
}
