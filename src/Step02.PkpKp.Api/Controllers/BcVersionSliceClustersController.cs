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
}
