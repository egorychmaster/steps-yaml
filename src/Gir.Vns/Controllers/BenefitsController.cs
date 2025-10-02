using Gir.Vns.Dtos.Benefits;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Льготы.
/// </summary>
[ApiController]
[Route("api/v1/gir/benefits")]
public class BenefitsController : ControllerBase
{
    /// <summary>
    /// Получение списка льгот с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BenefitDto>> GetWellTypesAsync([FromQuery] GetBenefitsQuery query)
    {
        return Ok();
    }
}
