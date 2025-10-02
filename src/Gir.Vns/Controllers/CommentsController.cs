using Gir.Vns.Dtos;
using Gir.Vns.Dtos.Comments;
using Microsoft.AspNetCore.Mvc;

namespace Gir.Vns.Controllers;

/// <summary>
/// Комментарии.
/// </summary>
[ApiController]
[Route("api/v1/gir")]
public class CommentsController : ControllerBase
{
    /// <summary>
    /// Получить конкретный комментарий.
    /// </summary>
    /// <param name="id">Идентификатор комментария.</param>
    [HttpGet("comments/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CommentDto?> GetCommentById(Guid id)
    {
        return Ok(new CommentDto());
    }

    /// <summary>
    /// Получить все комментарии для версии БК.
    /// </summary>
    /// <param name="bcVersionId">Идентификатор версии БК.</param>
    /// <param name="includeArchived">Включать архивные.</param>
    /// <param name="includeDeleted">Включать удалённые.</param>
    /// <returns></returns>
    [HttpGet("{bcVersionId:guid}/comments")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<CollectionResult<CommentListDto>> GetComments(Guid bcVersionId, [FromQuery] bool includeArchived = false,
        [FromQuery] bool includeDeleted = false)
    {
        var result = new CollectionResult<CommentListDto>(result: new List<CommentListDto>(), totalCount: 0);
        return Ok(result);
    }

    /// <summary>
    /// Добавить комментарий.
    /// </summary>
    /// <param name="bcVersionId">Идентификатор версии БК.</param>
    [HttpPost("{bcVersionId:guid}/comments")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult<Guid> CreateComment(Guid bcVersionId, [FromBody] CreateCommentDto dto)
    {
        return StatusCode(StatusCodes.Status201Created, new { Id = Guid.NewGuid() });
    }

    /// <summary>
    /// Изменить комментарий.
    /// </summary>
    /// <param name="id">Идентификатор комментария.</param>
    [HttpPut("comments/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult UpdateComment(Guid id, [FromBody] UpdateCommentDto dto)
    {
        return NoContent();
    }

    /// <summary>
    /// Удалить комментарий (и все вложенные комментарии 1-го уровня).
    /// </summary>
    /// <param name="id">Идентификатор комментария.</param>
    /// <returns></returns>
    [HttpDelete("comments/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    //[ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult DeleteComment(Guid id)
    {
        return NoContent();
    }

    /// <summary>
    /// Отправить в архив комментарий и его дочерние комментарии.
    /// </summary>
    /// <param name="id">Идентификатор комментария.</param>
    [HttpPut("comments/{id:guid}/archive")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public ActionResult ArchiveComment(Guid id)
    {
        return NoContent();
    }
}
