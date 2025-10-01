using Gir.Vns.Dtos.BcCycles;
using Microsoft.AspNetCore.Mvc;

namespace Gir.Vns.Controllers;

/// <summary>
/// Цикл (шаг) данных версии БК.
/// </summary>
[ApiController]
[Route("api/v1/gir/bcs/versions/cycles")]
public class BcCyclesController : ControllerBase
{
    /// <summary>
    /// Вернуть данные цикла(шага) по ID, в том числе и его статус.
    /// </summary>
    /// <param name="id">Идентификатор шага.</param>
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<BcCycleDto> GetBcCycleById(Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Полное множественное редактирование цикла(шага) по ID.
    /// </summary>
    [HttpPut("batch")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult UpdateBcCycle([FromBody] IEnumerable<BcCycleUpdateCommand> dto)
    {
        return NoContent();
    }
}
