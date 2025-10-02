using Gir.Vns.Dtos.WellPurposes;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Назначений(целей) скважин.
/// </summary>
[ApiController]
[Route("api/v1/gir/wells/purposes")]
public class WellPurposesController : ControllerBase
{
    /// <summary>
    /// Получение списка назначчений скважин с фильтрацией и сортировкой.
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
