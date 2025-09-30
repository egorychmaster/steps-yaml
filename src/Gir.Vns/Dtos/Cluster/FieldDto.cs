namespace Gir.Vns.Dtos.Cluster;

/// <summary>
/// Месторождение.
/// </summary>
public class FieldDto
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
    /// Идентификатор района расположения.
    /// </summary>
    public Guid? AreaId { get; set; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Составы активов, в которые входит данное месторождение.
    /// </summary>
    public List<AssetContentLightDto> AssetContents { get; set; } = new();

    /// <summary>
    /// Системы координат, к которым привязано данное месторождение.
    /// </summary>
    public List<FieldCoordinateSystemLightDto> CoordinateSystems { get; set; } = new();

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Кем создано.
    /// </summary>
    public Guid? CreatedByUserId { get; set; }
}