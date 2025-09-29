using Gir.Vns.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace Gir.Vns.Dtos.Comments;

/// <summary>
/// Модель обновления комментария.
/// </summary>
public class UpdateCommentDto
{
    /// <summary>
    /// Текст комментария.
    /// </summary>
    [Required]
    [MaxLength(CommentConstants.TextFieldLength)]
    public string Text { get; set; } = null!;

    //[Required]
    //public Guid UpdatedByUserId { get; set; }
}