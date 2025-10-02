using Microsoft.AspNetCore.Http;

namespace Step.Lib.Common.Dtos.Documents;

public class CreateDocumentCommand
{
    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// Загружаемый файл.
    /// </summary>
    public IFormFile File { get; set; } = null!;
}