using Gir.Vns.Dtos.Benefits;
using Gir.Vns.Dtos.CatalogBenefits;
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
		надо поговорить с Ириной и Аней: каким образом льготы будут хранится, если это будет хранится с привязкой к скважине, то записанные льготы должны иметь ссылку на скважины.
			нужно договорится с точки зрения бизнеса, как льготы должны сохранятся
			video "2025-10-06_185032 обсуждение ГИР 05" 2x 50min.
		льготы привязаны к скважине
     */

    /// <summary>
    /// Получение списка льгот с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BenefitSlmDto>> GetBenefitsAsync([FromQuery] GetBenefitsQuery query)
    {
        return Ok();
    }
}
