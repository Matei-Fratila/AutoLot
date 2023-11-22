﻿using AutoLot.Services.Logging.Interfaces;

namespace AutoLot.Api.Controllers.Base;

[ApiController]
[Route("api/[controller]")]
[Route("api/v{version:apiVersion}/[controller]")]
public abstract class BaseCrudController<TEntity, TController> : ControllerBase
    where TEntity : BaseEntity, new()
    where TController : class
{
    protected readonly IBaseRepo<TEntity> MainRepo;
    protected readonly IAppLogging<TController> Logger;
    protected BaseCrudController(IAppLogging<TController> logger, IBaseRepo<TEntity> repo)
    {
        Logger = logger;
        MainRepo = repo;
    }

    /// <summary>
    /// DON'T USE THIS ONE. BAD THINGS WILL HAPPEN
    /// </summary>
    /// <returns>All records</returns>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [SwaggerResponse(200, "The execution was successful")]
    [SwaggerResponse(400, "The request was invalid")]
    [SwaggerResponse(401, "Unauthorized access attempted")]
    [ApiVersion("0.5", Deprecated = true)]
    [HttpGet]
    public ActionResult<IEnumerable<TEntity>> GetAllBad()
    {
        throw new Exception("I said not to use this one");
    }

    /// <summary>
    /// Gets all records really fast (when it’s written)
    /// </summary>
    /// <returns>All records</returns>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [SwaggerResponse(200, "The execution was successful")]
    [SwaggerResponse(400, "The request was invalid")]
    [SwaggerResponse(401, "Unauthorized access attempted access attempted")]
    [ApiVersion("2.0-Beta")]
    [HttpGet]
    public ActionResult<IEnumerable<TEntity>> GetAllFuture()
    {
        throw new NotImplementedException("I'm working on it");
    }

    /// <summary>
    /// Gets all records
    /// </summary>
    /// <returns>All records</returns>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [SwaggerResponse(200, "The execution was successful")]
    [SwaggerResponse(400, "The request was invalid")]
    [SwaggerResponse(401, "Unauthorized access attempted")]
    [ApiVersion("1.0")]
    [HttpGet]
    public ActionResult<IEnumerable<TEntity>> GetAll()
    {
        return Ok(MainRepo.GetAllIgnoreQueryFilters());
    }

    /// <summary>
    /// Gets a single record
    /// </summary>
    /// <param name="id">Primary key of the record</param>
    /// <returns>Single record</returns>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [SwaggerResponse(200, "The execution was successful")]
    [SwaggerResponse(204, "No content")]
    [SwaggerResponse(400, "The request was invalid")]
    [SwaggerResponse(401, "Unauthorized access attempted")]
    [ApiVersion("1.0")]
    [HttpGet("{id}")]
    public ActionResult<TEntity> GetOne(int id)
    {
        var entity = MainRepo.Find(id);
        if (entity == null)
        {
            return NoContent();
        }
        return Ok(entity);
    }

    /// <summary>
    /// Updates a single record
    /// </summary>
    /// <remarks>
    /// Sample body:
    /// <pre>
    /// {
    /// "Id": 1,
    /// "TimeStamp": "AAAAAAAAB+E="
    /// /// "MakeId": 1,
    /// "Color": "Black",
    /// "PetName": "Zippy",
    /// "MakeColor": "VW (Black)",
    /// }
    /// </pre>
    /// </remarks>
    /// <param name="id">Primary key of the record to update</param>
    /// <param name="entity">Entity to update</param>
    /// <returns>Single record</returns>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [SwaggerResponse(200, "The execution was successful")]
    [SwaggerResponse(400, "The request was invalid")]
    [SwaggerResponse(401, "Unauthorized access attempted")]
    [HttpPut("{id}")]
    [ApiVersion("1.0")]
    public IActionResult UpdateOne(int id, TEntity entity)
    {
        if (id != entity.Id)
        {
            return BadRequest();
        }
        if (!ModelState.IsValid)
        {
            return ValidationProblem(ModelState);
        }
        try
        {
            MainRepo.Update(entity);
        }
        catch (CustomException ex)
        {
            //This shows an example with the custom exception
            //Should handle more gracefully
            return BadRequest(ex);
        }
        catch (Exception ex)
        {
            //Should handle more gracefully
            return BadRequest(ex);
        }
        return Ok(entity);
    }

    /// <summary>
    /// <summary>
    /// Adds a single record
    /// </summary>
    /// <remarks>
    /// Sample body:
    /// <pre>
    /// {
    /// "Id": 1,
    /// "TimeStamp": "AAAAAAAAB+E="
    /// "MakeId": 1,
    /// "Color": "Black",
    /// "PetName": "Zippy",
    /// "MakeColor": "VW (Black)",
    /// }
    /// </pre>
    /// </remarks>
    /// <returns>Added record</returns>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [SwaggerResponse(201, "The execution was successful")]
    [SwaggerResponse(400, "The request was invalid")]
    [SwaggerResponse(401, "Unauthorized access attempted")]
    [HttpPost]
    [ApiVersion("1.0")]
    public ActionResult<TEntity> AddOne(TEntity entity)
    {
        if (!ModelState.IsValid)
        {
            return ValidationProblem(ModelState);
        }
        try
        {
            MainRepo.Add(entity);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
        return CreatedAtAction(nameof(GetOne), new { id = entity.Id }, entity);
    }

    /// <summary>
    /// Deletes a single record
    /// </summary>
    /// <remarks>
    /// Sample body:
    /// <pre>
    /// {
    /// "Id": 1,
    /// "TimeStamp": "AAAAAAAAB+E="
    /// }
    /// </pre>
    /// </remarks>
    /// <returns>Nothing</returns>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [SwaggerResponse(200, "The execution was successful")]
    [SwaggerResponse(400, "The request was invalid")]
    [SwaggerResponse(401, "Unauthorized access attempted")]
    [HttpDelete("{id}")]
    [ApiVersion("1.0")]
    public ActionResult<TEntity> DeleteOne(int id, TEntity entity)
    {
        if (id != entity.Id)
        {
            return BadRequest();
        }
        try
        {
            MainRepo.Delete(entity);
        }
        catch (Exception ex)
        {
            //Should handle more gracefully
            return new BadRequestObjectResult(ex.GetBaseException()?.Message);
        }
        return Ok();
    }
}
