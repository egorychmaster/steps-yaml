using Gir.Vns.Dtos.CatalogWells;
using Microsoft.AspNetCore.Mvc;

namespace Gir.Vns.Controllers;

/// <summary>
/// Справочник скважин.
/// </summary>
[ApiController]
[Route("api/v1/vns/gir/catalog/wells")]
public class CatalogWellsController : ControllerBase
{
    /// <summary>
    /// Создание скважины в справочнике.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CreateWellResultDto> CreateWell([FromBody] CreateWellDto dto)
    {
        return StatusCode(StatusCodes.Status201Created, new CreateWellResultDto { WellId = Guid.NewGuid() });
    }

    /// <summary>
    /// Редактирование скважины в справочнике.
    /// </summary>
    [HttpPut("{Id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult UpdateWell([FromBody] UpdateWellDto dto)
    {
        return NoContent();
    }
}
