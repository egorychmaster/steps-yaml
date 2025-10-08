using Gir.Vns.Dtos.BcVersionDataWells.GetBcVersionDataWellCoordinate;
using Gir.Vns.Dtos.BcVersionDataWells.GetBcVersionDataWells;
using Gir.Vns.Dtos.Clusters;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Скважина среза версии БК.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/gir/wells")]
public class BcVersionSliceWellsController : ControllerBase
{
    /// <summary>
    /// Получение списка скважин с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BcVersionDataWellDto>> GetBcVersionDataWellAsync([FromQuery] GetBcVersionDataWellsQuery query)
    {
        var result = new CollectionResult<ClusterDto>(result: new List<ClusterDto>(), totalCount: 0);
        return Ok(result);
    }

    /// <summary>
    /// Получение координат ствола скважины.
    /// </summary>
    /// <returns></returns>
    [HttpGet("bore-coordinates")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<WellBoreCoordinateDto>> GetBcVersionDataWellCoordinatesAsync([FromQuery] GetBcVersionDataWellCoordinatesQuery query)
    {
        var result = new CollectionResult<WellBoreCoordinateDto>(result: new List<WellBoreCoordinateDto>(), totalCount: 0);
        return Ok(result);
    }
}
