using Gir.Vns.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace Gir.Vns.Dtos.Comments;

/// <summary>
/// DTO для создания комментария.
/// </summary>
public class CreateCommentDto
{
    /// <summary>
    /// Текст комментария.
    /// </summary>
    [Required]
    [MaxLength(CommentConstants.TextFieldLength)]
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Id пользователя-автора.
    /// </summary>
    //[Required]
    //public Guid AuthorId { get; set; }

    /// <summary>
    /// Id родительского комментария (если это ответ).
    /// </summary>
    public Guid? ParentId { get; set; }
}