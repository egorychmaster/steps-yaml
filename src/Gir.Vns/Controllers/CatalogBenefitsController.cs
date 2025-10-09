using Gir.Vns.Dtos.CatalogBenefits;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Льготы.
/// </summary>
[ApiController]
[Route("api/v1/vns/gir/catalog/benefits")]
public class CatalogBenefitsController : ControllerBase
{
    /// <summary>
    /// Получение списка льгот с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<CatalogBenefitDto>> GetWellTypesAsync([FromQuery] GetCatalogBenefitsQuery query)
    {
        return Ok();
    }
}
