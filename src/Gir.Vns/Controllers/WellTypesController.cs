using Gir.Vns.Dtos.WellTypes;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Типы скважин.
/// </summary>
[ApiController]
[Route("api/v1/gir/wells/types")]
public class WellTypesController : ControllerBase
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
