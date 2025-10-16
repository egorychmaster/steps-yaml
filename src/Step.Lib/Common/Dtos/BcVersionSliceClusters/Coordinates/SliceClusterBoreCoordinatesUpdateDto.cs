using Step.Lib.Common.Dtos.BcVersionSliceClusters.Coordinates.Enums;

namespace Step.Lib.Common.Dtos.BcVersionSliceClusters.Coordinates;

public class SliceClusterBoreCoordinatesUpdateDto
{
    public Guid Id { get; set; }

    /// <summary>
    /// ID системы координат (из справочника Catalog)
    /// </summary>
    public Guid? CoordinateSystemId { get; set; }

    /// <summary>
    /// Тип координат (1 - первоначальные, 2 - уточненные, 3 - предпочтительные)
    /// </summary>
    public ClusterCoordinateType Type { get; set; }

    /// <summary>
    /// Координата X
    /// </summary>
    public decimal X { get; set; }

    /// <summary>
    /// Координата Y
    /// </summary>
    public decimal Y { get; set; }

    /// <summary>
    /// Координата Z
    /// </summary>
    public decimal? Z { get; set; }

    /// <summary>
    /// НДС - Направление Движения Станка
    /// </summary>
    public string? Direction { get; set; }
}