namespace Gir.Vns.Dtos.BcVersionDataWells.GetBcVersionDataWellCoordinate;

public class GetBcVersionDataWellCoordinatesQuery
{
    /// <summary>
    /// Массив ID скважин.
    /// </summary>
    public Guid[]? BcVersionDataWellIds { get; init; }
}