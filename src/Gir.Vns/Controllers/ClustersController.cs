using Gir.Vns.Dtos;
using Gir.Vns.Dtos.Clusters;
using Microsoft.AspNetCore.Mvc;

namespace Gir.Vns.Controllers;

/// <summary>
/// Кластеры.
/// </summary>
[ApiController]
[Route("api/v1/gir/clusters")]
public class ClustersController : ControllerBase
{
    /// <summary>
    /// Получение списка типов кластеров с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<ClusterDto>> GetModuleTypesAsync([FromQuery] GetClustersQuery query)
    {
        var result = new CollectionResult<ClusterDto>(result: new List<ClusterDto>(), totalCount: 0);
        return Ok(result);
    }

    /// <summary>
    /// Создание куста.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<Guid> CreateCluster([FromBody] ClusterCreateDto dto)
    {
        return StatusCode(StatusCodes.Status201Created, new { Id = Guid.NewGuid() });
    }
}
