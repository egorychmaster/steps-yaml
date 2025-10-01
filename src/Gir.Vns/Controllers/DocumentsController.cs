using Gir.Vns.Dtos.Documents;
using Microsoft.AspNetCore.Mvc;

namespace Gir.Vns.Controllers;

/// <summary>
/// Документы.
/// </summary>
[ApiController]
[Route("api/v1/gir/documents")]
public class DocumentsController : ControllerBase
{
    /// <summary>
    /// Получение списка документов с фильтрацией и сортировкой.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<DocumentDto> GetModuleTypesAsync([FromQuery] GetDocumentsQuery query)
    {
        return Ok();
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
    /// <returns></returns>
    [HttpGet("{id:guid}/file")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<string> DownloadDocument(Guid id)
    {
        return Ok();
    }

    /*
    +GET 	/api/v1/gir/documents Получение списка ресурсов с пагинацией, фильтрацией и сортировкой.
    +DELETE 	/api/v1/gir/documents/{id} Удаление ресурса по ID.
    GET 	/api/v1/gir/documents/{id}/download Загружаем файл из хранилища по идентификатору.
            /api/v1/gir/documents/{id}/file		Скачивание файла по идентификатору.
    POST 	/api/v1/gir/documents/upload Сохраняем файлы в хранилище.
            /api/v1/gir/documents Сохраняем файлы в хранилище
     */
}
