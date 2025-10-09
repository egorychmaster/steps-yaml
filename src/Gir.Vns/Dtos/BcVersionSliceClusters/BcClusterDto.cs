namespace Gir.Vns.Dtos.BcVersionSliceClusters;

/// <summary>
/// Куст БК.
/// </summary>
public class BcClusterDto
{
    /// <summary>
    /// ID.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// ID куста (из MDM сервиса).
    /// </summary>
    public Guid ClusterId { get; set; }

    /// <summary>
    /// ID Состава актива (из MDM сервиса), ассоциированного с данным кустом БК.
    /// </summary>
    public Guid AssetContentId { get; set; }
}