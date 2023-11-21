namespace AutoLot.Api.Controllers;

[ApiVersion("0.5", Deprecated = true)]
[ApiVersion("1.0")]
[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    /// <summary>
    /// This is an example Get method returning JSON
    /// </summary>
    /// <remarks>This is one of several examples for returning JSON:
    /// <pre>
    /// [
    /// "value1",
    /// "value2"
    /// ]
    /// </pre>
    /// </remarks>
    /// <returns>List of strings</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new string[] { "value1", "value2" });
    }

    [HttpGet("one")]
    public IEnumerable<string> Get1()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("two")]
    public ActionResult<IEnumerable<string>> Get2()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("three")]
    public string[] Get3()
    {
        return ["value1", "value2"];
    }

    [HttpGet("four")]
    public IActionResult Get4()
    {
        return new JsonResult(new string[] { "value1", "value2" });
    }

    [HttpPost]
    public IActionResult BadBindingExample(WeatherForecast forecast)
    {
        return Ok(forecast);
    }

    [HttpGet("error")]
    public IActionResult Error()
    {
        return NotFound();
    }
}
