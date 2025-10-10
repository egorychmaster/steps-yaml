namespace Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWellsBore;

public class GetSliceWellBoreCoordinatesQuery
{
    /// <summary>
    /// Массив ID скважин.
    /// </summary>
    public Guid[]? BcVersionSliceWellIds { get; init; }
}