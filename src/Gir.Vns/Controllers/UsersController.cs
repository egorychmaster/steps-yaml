using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;
using Step.Lib.Common.Dtos.Users;

namespace Gir.Vns.Controllers;

/// <summary>
/// Пользователи.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionDataId:guid}/gir/users")]
public class UsersController : ControllerBase
{
    /// <summary>
    /// Получение списка пользователей с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<UserDto>> GetModuleTypesAsync([FromQuery] GetUsersQuery query)
    {
        return Ok();
    }
}
