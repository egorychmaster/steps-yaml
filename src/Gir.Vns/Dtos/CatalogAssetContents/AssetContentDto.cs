using Gir.Vns.Dtos.Common.Fields;

namespace Gir.Vns.Dtos.CatalogAssetContents;

/// <summary>
/// Состав актива.
/// </summary>
public class AssetContentDto
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

    /// <summary>
    /// Актив.
    /// </summary>
    public AssetDto Asset { get; set; } = null!;

    /// <summary>
    /// Месторождение.
    /// </summary>
    public FieldDto Field { get; set; } = null!;

    /// <summary>
    /// Лицензионный участок (ЛУ).
    /// </summary>
    public LicenseAreaDto LicenseArea { get; set; } = null!;

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Кем создано.
    /// </summary>
    public Guid? CreatedByUserId { get; set; }
}