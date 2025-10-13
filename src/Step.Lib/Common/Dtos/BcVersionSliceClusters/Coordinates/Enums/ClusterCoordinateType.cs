namespace Step.Lib.Common.Dtos.BcVersionSliceClusters.Coordinates.Enums;

/// <summary>
/// Перечисление типов координат куста.
/// </summary>
public enum ClusterCoordinateType : short
{
    /// <summary>
    /// Первоначальные координаты КП.
    /// </summary>
    Initial = 1,

    /// <summary>
    /// Уточненные координаты КП.
    /// </summary>
    Accurate = 2,

    /// <summary>
    /// Предпочтительные координаты КП.
    /// </summary>
    Preffered = 3,
}