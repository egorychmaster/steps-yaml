using Gir.Vns.Dtos;
using Gir.Vns.Dtos.Layers;
using Microsoft.AspNetCore.Mvc;

namespace Gir.Vns.Controllers;

/// <summary>
/// Слои месторождений.
/// </summary>
[ApiController]
[Route("api/v1/gir/layers")]
public class LayersController : ControllerBase
{
    /// <summary>
    /// Получение списка слоёв (пластов) месторожедний с фильтрацией и сортировкой.
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<LayerDto>> GetLayersAsync([FromQuery] GetLayersQuery query)
    {
        return Ok();
    }
}
