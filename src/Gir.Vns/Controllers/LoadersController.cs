using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;
using Step.Lib.Common.Dtos.Loaders;
using Step.Lib.Common.Dtos.Loaders.Geology;

namespace Gir.Vns.Controllers;

/// <summary>
/// Загрузчики.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/gir/loaders")]
public class LoadersController : ControllerBase
{
    /// <summary>
    /// Сохраняет файл данные и разбирает "Геологический загрузчик".
    /// </summary>
    /// <param name="ValidateOnly">Флаг режима "только валидация".
    /// <br/>Если true - будут возвращены только логи, сохранение данных не произойдет.
    /// <br/>Если false (по умолчанию) - будут возвращены логи, при этом данные будут сохранены в БД.</param>
    /// <param name="dto"></param>
    /// <returns>Возвращает id загрузки (loaderId).</returns>
    [HttpPost("geology")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<LoaderCreateResult> CreateDocument([FromQuery] bool ValidateOnly, [FromBody] GeologyOptions dto)
    {
        return StatusCode(StatusCodes.Status201Created, new { Id = Guid.NewGuid() });
    }

    /// <summary>
    /// Получение списка загрузок в шаге с фильтрацией и сортировкой.
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<LoaderListDto>> GetLoadersAsync([FromQuery] GetLoadersQuery query)
    {
        return Ok();
    }

    /// <summary>
    /// Скачивание файла по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор загрузки.</param>
    /// <returns>Содержимое файла.</returns>
    [HttpGet("{id:guid}/file")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<string> GetFileAsync(Guid id)
    {
        return Ok();
    }
}
