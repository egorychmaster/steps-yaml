using Step.Lib.Common.Dtos.Comments.Enums;

namespace Step.Lib.Common.Dtos.Comments;

/// <summary>
/// DTO комментария — используется для передачи данных о комментарии
/// между слоями приложения и наружу через API.
/// </summary>
public record class CommentDto
{
    /// <summary>
    /// Уникальный идентификатор комментария.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Идентификатор версии БК, к которой относится комментарий.
    /// </summary>
    public Guid BcVersionId { get; init; }

    /// <summary>
    /// Идентификатор родительского комментария (если это ответ).
    /// </summary>
    public Guid? ParentId { get; init; }

    /// <summary>
    /// Родительский комментарий в виде DTO (если есть).
    /// Может быть null, если комментарий верхнего уровня.
    /// </summary>
    public CommentDto? Parent { get; init; }

    /// <summary>
    /// Идентификатор автора комментария.
    /// </summary>
    public Guid AuthorId { get; init; }

    /// <summary>
    /// Текст комментария.
    /// </summary>
    public string Text { get; init; } = string.Empty;

    /// <summary>
    /// Статус комментария (Active, Archived, Deleted).
    /// </summary>
    public CommentStatus Status { get; init; }

    /// <summary>
    /// Дата и время создания комментария (UTC).
    /// </summary>
    public DateTime DateCreated { get; init; }

    /// <summary>
    /// Дата и время последнего изменения комментария (UTC).
    /// </summary>
    public DateTime DateUpdated { get; init; }

    /// <summary>
    /// Идентификатор пользователя, создавшего комментарий.
    /// </summary>
    public Guid CreatedByUserId { get; init; }

    /// <summary>
    /// Идентификатор пользователя, выполнившего последнее обновление комментария.
    /// Может быть null, если изменений не было.
    /// </summary>
    public Guid? UpdatedByUserId { get; init; }

    /// <summary>
    /// Идентификатор пользователя, удалившего комментарий.
    /// Может быть null, если комментарий не удалён.
    /// </summary>
    public Guid? DeletedByUserId { get; init; }
}