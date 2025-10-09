using Gir.Vns.Dtos.CatalogModuleTypes;
using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;

namespace Gir.Vns.Controllers;

/// <summary>
/// Типы модулей.
/// </summary>
[ApiController]
[Route("api/v1/vns/gir/catalog/module-types")]
public class CatalogModuleTypesController : ControllerBase
{
    /// <summary>
    /// Получение списка типов модулей с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<ModuleTypeDto>> GetModuleTypesAsync([FromQuery] GetModuleTypesQuery query)
    {        
        return Ok();
    }
}
