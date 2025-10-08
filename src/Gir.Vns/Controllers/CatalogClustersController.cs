using Gir.Vns.Dtos.Clusters;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Кусты.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/gir/clusters/catalog")]
public class CatalogClustersController : ControllerBase
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
    public ActionResult<ClusterCreateResultDto> CreateCluster([FromBody] ClusterCreateDto dto)
    {
        return StatusCode(StatusCodes.Status201Created, new { Id = Guid.NewGuid() });
    }
}
