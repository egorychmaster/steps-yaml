using Gir.Vns.Dtos.BcVersionSliceEconomic;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Экономические данные.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/gir/wells/economic")]
public class BcVersionSliceEconomicController : ControllerBase
{
    /// <summary>
    /// Получение экономических данных скважин с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BcVersionSliceEconomicDto>> GetBcVersionDataWellAsync([FromQuery] GetBcVersionSliceEconomicQuery query)
    {
        return Ok();
    }
}
