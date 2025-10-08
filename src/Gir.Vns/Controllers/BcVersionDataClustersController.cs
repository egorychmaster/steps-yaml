using Gir.Vns.Dtos.BcVersionDataClusters;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Кусты шага.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionDataId:guid}/gir/clusters")]
public class BcVersionDataClustersController : ControllerBase
{
    /// <summary>
    /// Получение списка кустов в шаге.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<BcVersionDataClusterDto>> GetLoadersAsync()
    {
        return Ok();
    }
}
