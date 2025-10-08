namespace Gir.Vns.Dtos.BcVersionDataWells.GetBcVersionDataWellCoordinate;

public class DataWellCoordinatesUpdateDto
{
    /// <summary>
    /// ID скважины данных версии БК.
    /// </summary>
    public Guid BcVersionDataWellId {  get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IEnumerable<BcVersionDataWellboreUpdateDto> Bores { get; set; }
}


public class BcVersionDataWellboreUpdateDto
{
    /// <summary>
    /// ID записи.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Координаты ствола.
    /// </summary>
    public List<WellBoreCoordinateItemDto> Coordinates { get; set; } = new();
}