using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;
using Step.Lib.Common.Dtos.BcVersionSliceClusters;

namespace Step02.PkpKp.Api.Controllers;

/// <summary>
/// Кусты шага.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/pkp-kp/clusters")]
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
}
