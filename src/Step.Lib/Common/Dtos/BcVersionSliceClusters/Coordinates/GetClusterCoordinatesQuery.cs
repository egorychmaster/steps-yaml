namespace Step.Lib.Common.Dtos.BcVersionSliceClusters.Coordinates;

public class GetClusterCoordinatesQuery
{
    /// <summary>
    /// Массив ID кластеров.
    /// </summary>
    public Guid[]? BcVersionSliceWellIds { get; init; }
}
