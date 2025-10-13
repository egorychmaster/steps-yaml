namespace Step.Lib.Common.Dtos.BcVersionSliceWells.SliceWellsBore;

public class GetSliceWellBoreCoordinatesQuery
{
    /// <summary>
    /// Массив ID скважин.
    /// </summary>
    public Guid[]? BcVersionSliceWellIds { get; init; }
}