using Gir.Vns.Dtos.AssetContents;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Содержимое активов.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/gir/asset-contents/catalog")]
public class CatalogAssetContentsController : ControllerBase
{
    /// <summary>
    /// Получение списка содержимого активов с фильтрацией и сортировкой.
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<AssetContentDto>> GetAssetContents([FromQuery] GetAssetContentsQuery query)
    {
        var result = new CollectionResult<AssetContentDto>(result: new List<AssetContentDto>(), totalCount: 0);
        return Ok(result);
    }
}
