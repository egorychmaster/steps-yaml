using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos.ApplicationConfig;

namespace Gir.Vns.Controllers;

///// <summary>
///// Приложение.
///// </summary>
//[ApiController]
//[Route("api/v1/gir/application")]
//public class ApplicationController : ControllerBase
//{
//    /// <summary>
//    /// Получение конфигурации шага (доступные загрузчики, название, группа, тип).
//    /// </summary>
//    /// <returns></returns>
//    [HttpGet("config")]
//    [ProducesResponseType(StatusCodes.Status200OK)]
//    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
//    public ActionResult<ApplicationConfig> GetConfigs()
//    {
//        return Ok();
//    }
//}
