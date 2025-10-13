using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos.BcCycles;
using Step.Lib.Common.Enums;

namespace Step02.PkpKp.Api.Controllers.Common;

/// <summary>
/// Шаг(цикл) данных версии БК.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/pkp-kp")]
public class PkpKpController : ControllerBase
{
    /// <summary>
    /// Вернуть данные цикла(шага) по ID, в том числе и его статус.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <param name="id">Идентификатор шага.</param>
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<BcCycleDto> GetBcCycleById([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId, 
        Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Редактирование шага(цикла) по ID.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    [HttpPut("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult UpdateBcCycle([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId, 
        [FromBody] IEnumerable<BcCycleUpdateCommand> dto)
    {
        return NoContent();
    }
}
