using Microsoft.AspNetCore.Mvc;
using Step.Lib.Common.Dtos;
using Step.Lib.Common.Dtos.Documents;

namespace Gir.Vns.Controllers;

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
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<DocumentDto>> GetModuleTypesAsync([FromQuery] GetDocumentsQuery query)
    {
        return Ok();
    }

    /// <summary>
    /// Сохраняем файлы в хранилище.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<Guid> CreateDocument([FromForm] CreateDocumentCommand dto)
    {
        return StatusCode(StatusCodes.Status201Created, new { Id = Guid.NewGuid() });
    }

    /// <summary>
    /// Удалить документ по Id.
    /// </summary>
    /// <param name="id">Идентификатор документа.</param>
    /// <returns></returns>
    [HttpDelete("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult DeleteDocument(Guid id)
    {
        return NoContent();
    }

    /// <summary>
    /// Скачивание файла по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор документа.</param>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <returns></returns>
    [HttpGet("{id:guid}/file")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<string> DownloadDocument(Guid id, Guid? userId)
    {
        return Ok();
    }
}
