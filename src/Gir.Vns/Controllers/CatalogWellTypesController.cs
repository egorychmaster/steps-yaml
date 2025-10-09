using Gir.Vns.Dtos.CatalogWellTypes;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Типы скважин.
/// </summary>
[ApiController]
[Route("api/v1/gir/catalog/wells/types")]
public class CatalogWellTypesController : ControllerBase
{
    /// <summary>
    /// Получение списка типов скважин с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<WellTypeDto>> GetWellTypesAsync([FromQuery] GetWellTypesQuery query)
    {
        return Ok();
    }
}
