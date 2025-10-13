using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;
using Step.Lib.Common.Dtos.Loaders;
using Step.Lib.Common.Dtos.Loaders.Geology;
using Step.Lib.Common.Enums;

namespace Gir.Vns.Controllers.Common;

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
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <param name="ValidateOnly">Флаг режима "только валидация".
    /// <br/>Если true - будут возвращены только логи, сохранение данных не произойдет.
    /// <br/>Если false (по умолчанию) - будут возвращены логи, при этом данные будут сохранены в БД.</param>
    /// <param name="dto"></param>
    /// <returns>Возвращает id загрузки (loaderId).</returns>
    [HttpPost("geology")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<LoaderCreateResultDto> CreateDocument([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId, 
        [FromQuery] bool ValidateOnly, [FromBody] GeologyOptions dto)
    {
        return StatusCode(StatusCodes.Status201Created, new { Id = Guid.NewGuid() });
    }

    /// <summary>
    /// Получение списка загрузок в шаге с фильтрацией и сортировкой.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <param name="query"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<LoaderListDto>> GetLoadersAsync([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId, 
        [FromQuery] GetLoadersQuery query)
    {
        return Ok();
    }

    /// <summary>
    /// Скачивание файла по идентификатору.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <param name="id">Идентификатор загрузки.</param>
    /// <returns>Содержимое файла.</returns>
    [HttpGet("{id:guid}/file")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<string> GetFileAsync([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId, 
        Guid id)
    {
        return Ok();
    }
}
