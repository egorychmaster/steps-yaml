using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;
using Step.Lib.Common.Dtos.Documents;
using Step.Lib.Common.Enums;

namespace Gir.Vns.Controllers.Common;

/// <summary>
/// Документы.
/// </summary>
[ApiController]
[Route("api/v1/vns/{processType:alpha}/{bcVersionSliceId:guid}/gir/documents")]
public class DocumentsController : ControllerBase
{
    /// <summary>
    /// Получение списка документов с фильтрацией и сортировкой.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <param name="query"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<DocumentDto>> GetModuleTypesAsync([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId,
        [FromQuery] GetDocumentsQuery query)
    {
        return Ok();
    }

    /// <summary>
    /// Сохраняем файлы в хранилище.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CreateDocumentResultDto> CreateDocument([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId, 
        [FromForm] CreateDocumentCommand dto)
    {
        return StatusCode(StatusCodes.Status201Created, new { Id = Guid.NewGuid() });
    }

    /// <summary>
    /// Удалить документ по Id.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <param name="id">Идентификатор документа.</param>
    /// <returns></returns>
    [HttpDelete("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult DeleteDocument([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId, 
        Guid id)
    {
        return NoContent();
    }

    /// <summary>
    /// Скачивание файла по идентификатору.
    /// </summary>
    /// <param name="processType">Выбор Fbc или Uibk.</param>
    /// <param name="bcVersionSliceId">Срез версии БК.</param>
    /// <param name="id">Идентификатор документа.</param>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <returns></returns>
    [HttpGet("{id:guid}/file")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<string> DownloadDocument([FromRoute] ProcessType processType, [FromRoute] Guid bcVersionSliceId, 
        Guid id, Guid? userId)
    {
        return Ok();
    }
}
