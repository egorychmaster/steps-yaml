using Gir.Vns.Dtos.CatalogWells;
using Microsoft.AspNetCore.Mvc;

namespace Gir.Vns.Controllers;

/// <summary>
/// Справочник скважин.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/gir/wells/catalog")]
public class CatalogWellsController : ControllerBase
{
    /// <summary>
    /// Создание скважины в справочнике.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CreateWellResultDto> CreateCluster([FromBody] CreateWellDto dto)
    {
        return StatusCode(StatusCodes.Status201Created, new CreateWellResultDto { WellId = Guid.NewGuid() });
    }
}
