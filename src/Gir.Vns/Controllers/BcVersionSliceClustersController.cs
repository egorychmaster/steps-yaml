using Gir.Vns.Dtos.BcVersionSliceClusters;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;
using Step.Lib.Common.Dtos.BcVersionSliceClusters;

namespace Gir.Vns.Controllers;

/// <summary>
/// Кусты шага.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/gir/clusters")]
public class BcVersionSliceClustersController : ControllerBase
{
    /// <summary>
    /// Получение списка кустов в шаге.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BcVersionSliceClusterDto>> GetLoadersAsync()
    {
        return Ok();
    }

    /// <summary>
    /// Создание куста, относящегося к БК.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<BcVersionSliceClusterDto> CreateCluster([FromBody] BcClusterCreateDto dto)
    {
        return StatusCode(StatusCodes.Status201Created, new { Id = Guid.NewGuid() });
    }
}
