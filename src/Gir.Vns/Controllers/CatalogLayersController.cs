using Gir.Vns.Dtos.Layers;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Слои (пласты) месторождений.
/// </summary>
[ApiController]
[Route("api/v1/vns/gir/catalog/layers")]
public class CatalogLayersController : ControllerBase
{
    /// <summary>
    /// Получение списка слоёв (пластов) месторожедний с фильтрацией и сортировкой.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<LayerDto>> GetLayersAsync([FromQuery] GetLayersQuery query)
    {
        return Ok();
    }
}
