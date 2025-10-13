using Step.Lib.Common.Dtos.EconomicSummaryModule;

namespace Step.Lib.Common.Dtos.BcVersionSliceClusters;

/// <summary>
/// Куст данных версии БК.
/// </summary>
public class BcVersionSliceClusterDto
{
    /// <summary>
    /// ID.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Куст БК, к которому относится данный куст.
    /// </summary>
    public BcClusterDto BcCluster { get; set; } = null!;

    /// <summary>
    /// Экономика данного куста.
    /// </summary>
    public EconomicSummaryGroupDto Economic { get; set; } = null!;
}