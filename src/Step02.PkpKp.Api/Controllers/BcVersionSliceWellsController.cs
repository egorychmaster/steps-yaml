using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;
using Step.Lib.Common.Dtos.BcVersionSliceWells.SliceWells;
using Step.Lib.Common.Dtos.BcVersionSliceWells.SliceWellsBore;
using Step.Lib.Common.Enums;

namespace Step02.PkpKp.Api.Controllers;

/// <summary>
/// Скважина среза версии БК.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/pkp-kp/wells")]
public class BcVersionSliceWellsController : ControllerBase
{
    /// <summary>
    /// Получение списка скважин с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BcVersionSliceWellDto>> GetBcVersionDataWellAsync([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId,
        [FromQuery] GetBcVersionSliceWellsQuery query)
    {
        return Ok();
    }

    /// <summary>
    /// Получение координат ствола скважины.
    /// </summary>
    /// <returns></returns>
    [HttpGet("bore-coordinates")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BcVersionSliceWellBoreCoordinateDto>> GetBcVersionDataWellCoordinatesAsync(
        [FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId, 
        [FromQuery] GetSliceWellBoreCoordinatesQuery query)
    {
        return Ok();
    }
}
