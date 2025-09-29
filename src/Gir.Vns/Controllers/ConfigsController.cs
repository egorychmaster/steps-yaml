using Gir.Vns.Dtos.Configs;
using Microsoft.AspNetCore.Mvc;

namespace Gir.Vns.Controllers;

/// <summary>
/// Конфигурация шага.
/// </summary>
[ApiController]
[Route("api/v1/gir/configs")]
public class ConfigsController : ControllerBase
{
    /// <summary>
    /// Получение свойств шага из конфига (доступные загрузчики, название, группа, тип).
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<ConfigDto> GetConfigs()
    {
        var result = new ConfigDto();
        return Ok(result);
    }
}
