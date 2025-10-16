using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;
using Step.Lib.Common.Dtos.BcVersionSliceClusters;
using Step.Lib.Common.Dtos.BcVersionSliceClusters.Coordinates;
using Step.Lib.Common.Enums;

namespace Step02.PkpKp.Api.Controllers;

/// <summary>
/// Кусты шага.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/pkp-kp/clusters")]
public class BcVersionSliceClustersController : ControllerBase
{
    /// <summary>
    /// Получение списка кустов в шаге.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BcVersionSliceClusterDto>> GetClustersAsync([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId)
    {
        return Ok();
    }

    /// <summary>
    /// Получение списка координат кустов в шаге.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <returns></returns>
    [HttpGet("coordinates")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BcVersionSliceClusterCoordinateDto>> GetClusterCoordinatesAsync(
        [FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId,
        [FromQuery] GetClusterCoordinatesQuery query)
    {
        return Ok();
    }

    /// <summary>
    /// Множественное редактирование координат кустов.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPut("coordinates/batch")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult UpdateWellCoordinates(
        [FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId,
        [FromBody] ICollection<SliceWellBoreCoordinatesUpdateDto> dto)
    {
        return NoContent();
    }
}
