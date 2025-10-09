using Gir.Vns.Dtos.CatalogWellPurposes;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Назначений(целей) скважин.
/// </summary>
[ApiController]
[Route("api/v1/vns/gir/catalog/wells/purposes")]
public class CatalogWellPurposesController : ControllerBase
{
    /// <summary>
    /// Получение списка назначений скважин с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<WellPurposeDto>> GetWellTypesAsync([FromQuery] GetWellPurposesQuery query)
    {
        return Ok();
    }
}
