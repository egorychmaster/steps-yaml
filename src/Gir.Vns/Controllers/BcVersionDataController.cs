//using Microsoft.AspNetCore.Mvc;
//using Step.Lib.Common.Dtos;
//using Step.Lib.Common.Dtos.Users;

//namespace Gir.Vns.Controllers;

///// <summary>
///// Данные версии БК.
///// </summary>
//[ApiController]
//[Route("api/v1/gir/bcs/versions/data")]
//public class BcVersionDataController : ControllerBase
//{
//    /// <summary>
//    /// Получение данных версии БК по ID.
//    /// </summary>
//    /// <returns></returns>
//    [HttpGet("{id:guid}")]
//    [ProducesResponseType(StatusCodes.Status200OK)]
//    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
//    public ActionResult<CollectionResult<BcVersionDataDto>> GetModuleTypesAsync()
//    {
//        return Ok();
//    }
//}
