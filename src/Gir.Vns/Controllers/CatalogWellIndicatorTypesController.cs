using Gir.Vns.Dtos.CatalogWellIndicatorTypes;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Типы индикаторов скважин.
/// </summary>
[ApiController]
[Route("api/v1/vns/gir/catalog/wells/indicator-types")]
public class CatalogWellIndicatorTypesController : ControllerBase
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
