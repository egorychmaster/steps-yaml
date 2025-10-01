namespace Gir.Vns.Dtos.Documents;

/// <summary>
/// DTO для документа.
/// </summary>
public class DocumentDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Сгенерированное название файла.
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// Оригинальное название файла.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Комментарий.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Метаданные.
    /// </summary>
    public DocumentMetadataDto Metadata { get; set; } = null!;

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }
}