using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;
using Step.Lib.Common.Dtos.Users;
using Step.Lib.Common.Enums;

namespace Step02.PkpKp.Api.Controllers.Common;

/// <summary>
/// Пользователи.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/pkp-kp/users")]
public class UsersController : ControllerBase
{
    /// <summary>
    /// Получение списка пользователей с фильтрацией и сортировкой.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<UserDto>> GetModuleTypesAsync([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId, 
        [FromQuery] GetUsersQuery query)
    {
        return Ok();
    }
}
