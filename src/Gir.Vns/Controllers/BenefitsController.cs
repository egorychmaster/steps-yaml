using Gir.Vns.Dtos.Benefits;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Льготы версии БК.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/gir/benefits")]
public class BenefitsController : ControllerBase
{
    /*
     * Либо мы:
		1 получаем весь набор льгот по БК
		2 либо отправляем набор скважин и по ним получаем льготы, относящиеся к ним, конкретно в этом БК. 
     */

    /// <summary>
    /// Получение списка льгот с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BenefitDmo>> GetWellTypesAsync([FromQuery] GetBenefitsQuery query)
    {
        return Ok();
    }
}
