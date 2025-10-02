using Gir.Vns.Dtos.WellIndicatorTypes;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Типы индикаторов скважин.
/// </summary>
[ApiController]
[Route("api/v1/gir/wells/indicator-types")]
public class WellIndicatorTypesController : ControllerBase
{
    /// <summary>
    /// Получение списка индикаторов скважин с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<WellIndicatorTypeDto>> GetWellTypesAsync([FromQuery] GetWellIndicatorTypesQuery query)
    {
        return Ok();
    }
}
