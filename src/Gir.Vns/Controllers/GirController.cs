using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos.BcCycles;

namespace Gir.Vns.Controllers;

/// <summary>
/// Шаг(цикл) данных версии БК.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionDataId:guid}/gir")]
public class GirController : ControllerBase
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
    /// Редактирование шага(цикла) по ID.
    /// </summary>
    [HttpPut("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult UpdateBcCycle([FromBody] IEnumerable<BcCycleUpdateCommand> dto)
    {
        return NoContent();
    }
}
