namespace Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWellsBore;

public class DataWellCoordinatesUpdateDto
{
    /// <summary>
    /// Скважины с координатами.
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