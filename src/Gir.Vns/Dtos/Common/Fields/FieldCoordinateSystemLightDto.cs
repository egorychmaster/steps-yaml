namespace Gir.Vns.Dtos.Common.Fields;

/// <summary>
/// Месторождение системы координат.
/// </summary>
public class FieldCoordinateSystemLightDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Идентификатор месторождения.
    /// </summary>
    public Guid FieldId { get; set; }

    /// <summary>
    /// Идентификатор системы координат.
    /// </summary>
    public Guid CoordinateSystemId { get; set; }
}