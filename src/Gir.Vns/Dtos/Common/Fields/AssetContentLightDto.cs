namespace Gir.Vns.Dtos.Common.Fields;

/// <summary>
/// Состав актива.
/// </summary>
public class AssetContentLightDto
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Идентификатор из КСУ НСИ.
    /// </summary>
    public Guid? NsiId { get; set; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Идентификатор актива.
    /// </summary>
    public Guid AssetId { get; set; }

    /// <summary>
    /// Идентификатор месторождения.
    /// </summary>
    public Guid FieldId { get; set; }

    /// <summary>
    /// Идентификатор лицензионного участка (ЛУ).
    /// </summary>
    public Guid LicenseAreaId { get; set; }
}