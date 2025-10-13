using Step.Lib.Common.Dtos.BcVersionSliceWells.SliceWellsBore;

namespace Gir.Vns.Dtos.BcVersionSliceWells.GetBcVersionSliceWellsBore;

public class SliceWellBoreCoordinatesUpdateDto
{
    /// <summary>
    /// Скважины с координатами.
    /// </summary>
    public IEnumerable<BcVersionSliceWellboreUpdateDto> Bores { get; set; }
}


public class BcVersionSliceWellboreUpdateDto
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