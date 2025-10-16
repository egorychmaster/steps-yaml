using Step.Lib.Common.Dtos.BcVersionSliceClusters.Coordinates.Enums;

namespace Step.Lib.Common.Dtos.BcVersionSliceClusters.Coordinates;

/// <summary>
/// Координаты куста среза версии БК
/// </summary>
public class BcVersionSliceClusterCoordinateDto
{
    public Guid Id { get; set; }

    /// <summary>
    /// ID куста среза версии БК на прогнозе
    /// </summary>
    public Guid BcVersionSliceClusterId { get; set; }

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

    /// <summary>
    /// Дата и время создания записи (UTC).
    /// </summary>
    public DateTime DateCreated { get; init; }

    ///// <summary>
    ///// Дата и время последнего изменения записи (UTC).
    ///// </summary>
    //public DateTime DateUpdated { get; init; }

    /// <summary>
    /// Идентификатор пользователя, создавшего запись.
    /// </summary>
    public Guid CreatedByUserId { get; init; }

    ///// <summary>
    ///// Идентификатор пользователя, выполнившего последнее обновление записи.
    ///// Может быть null, если изменений не было.
    ///// </summary>
    //public Guid? UpdatedByUserId { get; init; }
}
