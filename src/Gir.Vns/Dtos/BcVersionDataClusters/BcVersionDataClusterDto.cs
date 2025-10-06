using Gir.Vns.Dtos.Common.EconomicSummaryModule;

namespace Gir.Vns.Dtos.BcVersionDataClusters;

/// <summary>
/// Куст данных версии БК.
/// </summary>
public class BcVersionDataClusterDto
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
    // TODO: сделать аналогичную обертку в entity BcVersionDataCluster.
    public EconomicSummaryGroupDto Economic { get; set; } = null!;
}