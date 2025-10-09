using Gir.Vns.Dtos.CatalogWellConditions;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Условия бурения скважин.
/// </summary>
[ApiController]
[Route("api/v1/vns/gir/catalog/wells/conditions")]
public class CatalogWellConditionsController : ControllerBase
{
    /// <summary>
    /// Получение списка состояний(условий бурения) скважин с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<WellConditionDto>> GetWellTypesAsync([FromQuery] GetWellConditionsQuery query)
    {
        return Ok();
    }
}
