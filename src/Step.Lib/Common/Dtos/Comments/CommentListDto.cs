using Step.Lib.Common.Dtos.Comments.Enums;

namespace Step.Lib.Common.Dtos.Comments;

/// <summary>
/// Облегчённая DTO комментария — используется для вывода списков комментариев.
/// </summary>
public record class CommentListDto
{
    /// <summary>
    /// Уникальный идентификатор комментария.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Идентификатор среза версии БК, к которой относится комментарий.
    /// </summary>
    public Guid BcVersionSliceId { get; init; }

    /// <summary>
    /// Идентификатор родительского комментария (если это ответ на другой комментарий).
    /// </summary>
    public Guid? ParentId { get; init; }

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
}